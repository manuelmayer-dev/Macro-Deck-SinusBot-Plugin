using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Server;
using SuchByte.SinusBotPlugin.GUI;
using SuchByte.SinusBotPlugin.Language;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuchByte.SinusBotPlugin.Actions
{
    public class PlayBackFileAction : PluginAction
    {
        public override string Name => PluginLanguageManager.PluginStrings.ActionPlayBackFile;

        public override string Description => PluginLanguageManager.PluginStrings.ActionPlayBackFileDescription;

        public override bool CanConfigure => true;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            if (this.Configuration.Length == 0) return;
            try
            {
                if (Main.Sinusbot == null || Main.Sinusbot.LoggedIn == false) return;
                string instanceId = JObject.Parse(this.Configuration)["instanceId"].ToString();
                string fileId = JObject.Parse(this.Configuration)["fileId"].ToString();
                int volume = Int32.Parse(JObject.Parse(this.Configuration)["volume"].ToString());
                if (volume > -1)
                {
                    Main.Sinusbot.SetVolume(instanceId, volume);
                }
                Main.Sinusbot.PlayFile(instanceId, fileId);
            }
            catch { }
        }

        public override void OnActionButtonLoaded()
        {
            Main.Sinusbot.PlayingStateChanged += Sinusbot_PlayingStateChanged;
        }

        private void Sinusbot_PlayingStateChanged(object sender, PlayingStateEventArgs e)
        {
            Task.Run(() =>
            {
                JObject configObject = JObject.Parse(this.Configuration);
                if (configObject["syncButtonState"] != null)
                {
                    bool.TryParse(configObject["syncButtonState"].ToString(), out bool syncButtonState);
                    if (syncButtonState)
                    {
                        string instanceId = configObject["instanceId"].ToString();
                        string fileId = configObject["fileId"].ToString();

                        if (instanceId == sender as string && e.FileId == fileId)
                        {
                            MacroDeckServer.SetState(this.ActionButton, e.NewState);
                        }
                    }
                }
            });
        }

        public override void OnActionButtonDelete()
        {
            Main.Sinusbot.PlayingStateChanged -= Sinusbot_PlayingStateChanged;
        }

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new PlayBackFileActionConfigurator(this, actionConfigurator);
        }
    }
}
