using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serialization.Json;
using SuchByte.MacroDeck.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SuchByte.SinusBotPlugin
{
    public class PlayingStateEventArgs : EventArgs
    {
        public bool NewState { get; set; }
        public string FileId { get; set; }
    }

    public class Sinusbot
    {
        private readonly string _apiString = "/api/v1";
        private readonly string _bearerToken = "";
        private readonly string _botId = "";
        private readonly string _url = "";
        private readonly bool _loggedIn = false;

        private Dictionary<string, bool> _playing = new Dictionary<string, bool>();
        private Dictionary<string, string> _fileId = new Dictionary<string, string>();

        public event EventHandler<PlayingStateEventArgs> PlayingStateChanged;

        public bool LoggedIn { get { return this._loggedIn; } }

        private Timer _stateUpdateTimer;

        public Sinusbot(string url = "", string username = "", string password = "")
        {
            this._url = url;
            try
            {
                var botIdCall = ApiCallObject("/botId", null, HttpRequestMethod.GET);
                if (botIdCall != null && botIdCall["defaultBotId"] != null)
                {
                    this._botId = botIdCall["defaultBotId"];
                }

                if (string.IsNullOrWhiteSpace(this._botId))
                {
                    MacroDeckLogger.Warning(PluginInstance.Main, $"Could not initialize SinusBot instance because the BotId was null");
                    return;
                }
                var loginCall = ApiCallObject("/bot/login", new Dictionary<string, string>
                {
                    { "username", username },
                    { "password", password },
                    { "botId", this._botId }
                }, HttpRequestMethod.POST);

                    if (loginCall != null)
                    {
                        this._bearerToken = loginCall["token"];
                        this._loggedIn = true;

                        MacroDeckLogger.Info(PluginInstance.Main, $"Successfully connected to { this._url + Environment.NewLine + $"BotId: { this._botId }" }");

                        this._stateUpdateTimer = new Timer
                        {
                            Interval = 1000,
                            Enabled = true
                        };
                        this._stateUpdateTimer.Start();
                        this._stateUpdateTimer.Elapsed += StateUpdateTimer_Elapsed;
                    }
            } catch (Exception ex)
            {
                MacroDeckLogger.Error(PluginInstance.Main, $"Error while starting SinusBot instance: { ex.Message + Environment.NewLine + ex.StackTrace }");
            }
        }

        private void Login()
        {

        }

        private void StateUpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Task.Run(() =>
            {
                foreach (var instance in this.GetBotInstances())
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(instance.ToString())) return;
                        string instanceId = instance["uuid"].ToString();
                        string instanceNick = instance["nick"].ToString();
                        Dictionary<string, string> instanceStatus = this.GetInstanceStatus(instance["uuid"].ToString());
                        if (instanceStatus == null) return;
                        string playingStateString = instanceStatus["playing"];
                        JObject currentTrack = JObject.Parse(instanceStatus["currentTrack"]);
                        string fileId = currentTrack["uuid"].ToString();
                        string title = currentTrack["title"].ToString();
                        bool.TryParse(playingStateString, out bool playingState);


                        if (!this._playing.ContainsKey(instanceId) || !this._fileId.ContainsKey(instanceId) || playingState != this._playing[instanceId] || fileId != this._fileId[instanceId])
                        {
                            // Send playing state stop when changing track
                            if (playingState != false && this._fileId.ContainsKey(instanceId))
                            {
                                if (PlayingStateChanged != null)
                                {
                                    PlayingStateChanged(instanceId, new PlayingStateEventArgs { NewState = false, FileId = this._fileId[instanceId] });
                                }
                            }
                            this._playing[instanceId] = playingState;
                            this._fileId[instanceId] = fileId;
                            MacroDeck.Variables.VariableManager.SetValue(instanceNick + " title", title, MacroDeck.Variables.VariableType.String, PluginInstance.Main);
                            MacroDeck.Variables.VariableManager.SetValue(instanceNick + " playing", playingState, MacroDeck.Variables.VariableType.Bool, PluginInstance.Main);
                            if (PlayingStateChanged != null)
                            {
                                PlayingStateChanged(instanceId, new PlayingStateEventArgs { NewState = playingState, FileId = fileId });
                            }
                        }
                    } catch {}
                }
                
            });
        }

        public string GetInstanceId(string name)
        {
            try
            {
                foreach (JObject instanceObject in this.GetBotInstances())
                {
                    foreach (KeyValuePair<string, JToken> arg in instanceObject)
                    {
                        if (arg.Key.Equals("nick") && arg.Value.ToString().Equals(name))
                        {
                            return instanceObject["uuid"].ToString();
                        }
                    }
                }
            } catch { }
            return "";
        }

        public string GetFileId(string title)
        {
            try
            {
                foreach (JObject fileObject in this.GetFileList())
                {
                    foreach (KeyValuePair<string, JToken> arg in fileObject)
                    {
                        if (arg.Key.Equals("title") && arg.Value.ToString().Equals(title))
                        {
                            return fileObject["uuid"].ToString();
                        }
                    }
                }
            } catch { }
            return "";
        }

        public string GetInstanceName(string id)
        {
            try
            {
                foreach (JObject instanceObject in this.GetBotInstances())
                {
                    foreach (KeyValuePair<string, JToken> arg in instanceObject)
                    {
                        if (arg.Key.Equals("uuid") && arg.Value.ToString().Equals(id))
                        {
                            return instanceObject["nick"].ToString();
                        }
                    }
                }
            } catch { }
            return "";
        }

        public string GetFileTitle(string id)
        {
            try
            {
                foreach (JObject instanceObject in this.GetFileList())
                {
                    foreach (KeyValuePair<string, JToken> arg in instanceObject)
                    {
                        if (arg.Key.Equals("uuid") && arg.Value.ToString().Equals(id))
                        {
                            return instanceObject["title"].ToString();
                        }
                    }
                }
            } catch { }
            return "";
        }

        public void SetVolume(string instanceId, int volume)
        {
            if (!this._loggedIn)
                return;
            this.ApiCallObject("/bot/i/" + instanceId + "/volume/set/" + volume, null, HttpRequestMethod.POST);
        }

        public void IncreaseVolume(string instanceId)
        {
            if (!this._loggedIn)
                return;
            this.ApiCallObject("/bot/i/" + instanceId + "/volume/up", null, HttpRequestMethod.POST);
        }
        public void DecreaseVolume(string instanceId)
        {
            if (!this._loggedIn)
                return;
            this.ApiCallObject("/bot/i/" + instanceId + "/volume/down", null, HttpRequestMethod.POST);
        }

        public void StopPlayback(string instanceId)
        {
            if (!this._loggedIn)
                return;
            this.ApiCallObject("/bot/i/" + instanceId + "/stop", null, HttpRequestMethod.POST);
        }

        public void PlayFile(string instanceId, string fileId)
        {
            if (!this._loggedIn)
                return;
            this.ApiCallObject("/bot/i/" + instanceId + "/play/byId/" + fileId, null, HttpRequestMethod.POST);
        }

        public List<JObject> GetFileList()
        {
            if (!this._loggedIn)
                return null;
            List<JObject> files = new List<JObject>();
            foreach (string instanceJson in this.ApiCallArray("/bot/files", null, HttpRequestMethod.GET))
            {
                files.Add(JObject.Parse(instanceJson));
            }

            return files;
        }

        public Dictionary<string, string> GetInstanceStatus(string instanceId)
        {
            if (!this._loggedIn)
                return null;

            return this.ApiCallObject("/bot/i/" + instanceId + "/status", null, HttpRequestMethod.GET);
        }

        public List<JObject> GetBotInstances()
        {
            if (!this._loggedIn)
                return null;
            List<JObject> instances = new List<JObject>();
            foreach (string instanceJson in this.ApiCallArray("/bot/instances", null, HttpRequestMethod.GET))
            {
                instances.Add(JObject.Parse(instanceJson));
            }

            return instances;
        }

        private IRestResponse ApiCall(string api, Dictionary<string, string> args, HttpRequestMethod httpRequestMethod)
        {
            var client = new RestClient(this._url);
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", this._bearerToken));
            var request = new RestRequest(this._apiString + api);
            if (args != null)
            {
                foreach (KeyValuePair<string, string> arg in args)
                {
                    request.AddParameter(arg.Key, arg.Value);
                }
            }
            IRestResponse response = null;
            switch (httpRequestMethod)
            {
                case HttpRequestMethod.GET:
                    response = client.Get(request);
                    break;
                case HttpRequestMethod.POST:
                    response = client.Post(request);
                    break;
            }

            return response;
        }

        private Dictionary<string, string> ApiCallObject(string api, Dictionary<string, string> args, HttpRequestMethod httpRequestMethod)
        {
            Dictionary<string, string> jsonObject;
            var response = this.ApiCall(api, args, httpRequestMethod);
            JsonDeserializer deserial = new JsonDeserializer();
            try
            {
                jsonObject = deserial.Deserialize<Dictionary<string, string>>(response);
            }
            catch
            {
                jsonObject = null;
            }
            return jsonObject;
        }

        private List<string> ApiCallArray(string api, Dictionary<string, string> args, HttpRequestMethod httpRequestMethod)
        {
            List<string> jsonArray;
            var response = this.ApiCall(api, args, httpRequestMethod);
            JsonDeserializer deserial = new JsonDeserializer();
            try
            {
                jsonArray = deserial.Deserialize<List<string>>(response);
            }
            catch
            {
                jsonArray = null;
            }
            return jsonArray;
        }
    }

    public enum HttpRequestMethod
    {
        GET,
        POST
    }
}
