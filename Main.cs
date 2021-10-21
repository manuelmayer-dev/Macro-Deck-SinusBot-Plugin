using SuchByte.MacroDeck.Plugins;
using Newtonsoft.Json.Linq;
using SuchByte.SinusBotPlugin.GUI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Events;
using System.Reflection;
using SuchByte.MacroDeck.GUI.CustomControls;
using System.Drawing;
using System.Threading.Tasks;
using SuchByte.MacroDeck.GUI;

namespace SuchByte.SinusBotPlugin
{
    public class Main : MacroDeckPlugin
    {
        public static Sinusbot Sinusbot;

        public Main()
        {
            
        }

        public override string Description => "This plugin can control a SinusBot music bot.";

        public override List<PluginAction> Actions { get; set; }

        public override bool CanConfigure => true;

        public override Image Icon => Properties.Resources.SinusBot_Plugin;

        public override void Enable() {
            Task.Run(() =>
            {
                List<Dictionary<string, string>> credentialsList = PluginCredentials.GetPluginCredentials(this);
                Dictionary<string, string> credentials = null;
                if (credentialsList.Count > 0)
                {
                    credentials = credentialsList[0];
                }

                if (credentials != null)
                {
                    Sinusbot = new Sinusbot(credentials["url"], credentials["username"], credentials["password"]);
                }
            });
            this.Actions = new List<PluginAction>
            {
                new PlayBackFileAction(),
                new StopPlayBackAction(),
                new DecreaseVolumeAction(),
                new IncreaseVolumeAction()
            };

        }

        public override void OpenConfigurator()
        {
            new PluginConfig(this).ShowDialog();
        }

    }

    public class PlayBackStartedEvent : IMacroDeckEvent
    {
        public string Name => "SinusBot Playback started";

        public EventHandler<MacroDeckEventArgs> OnEvent { get; set; }
    }

    public class IncreaseVolumeAction : PluginAction
    {
        public override string Name => "Increase SinusBot volume";
        public override string Description => "Increases the bot volume by 5%";
        public override string DisplayName { get; set; } = "Increase SinusBot volume";
        public override bool CanConfigure => true;
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            if (Main.Sinusbot == null || Main.Sinusbot.LoggedIn == false) return;
            if (this.Configuration.Length == 0) return;
            try
            {
                string instanceId = JObject.Parse(this.Configuration)["instanceId"].ToString();
                Main.Sinusbot.IncreaseVolume(instanceId);
            }
            catch { }
        }

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new SelectInstanceDialog(this);
        }
    }

    public class DecreaseVolumeAction : PluginAction
    {
        public override string Name => "Decrease SinusBot volume";
        public override string Description => "Decreases the bot volume by 5%";
        public override string DisplayName { get; set; } = "Decrease SinusBot volume";
        public override bool CanConfigure => true;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            if (Main.Sinusbot == null || Main.Sinusbot.LoggedIn == false) return;
            if (this.Configuration.Length == 0) return;
            try
            {
                string instanceId = JObject.Parse(this.Configuration)["instanceId"].ToString();
                Main.Sinusbot.DecreaseVolume(instanceId);
            }
            catch { }
        }

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new SelectInstanceDialog(this);
        }
    }

    public class StopPlayBackAction : PluginAction
    {
        public override string Name => "Stop playback";
        public override string Description => "Stops the playback";
        public override string DisplayName { get; set; } = "Stop playback";
        public override bool CanConfigure => true;
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            if (Main.Sinusbot == null || Main.Sinusbot.LoggedIn == false) return;
            if (this.Configuration.Length == 0) return;
            try
            {
                string instanceId = JObject.Parse(this.Configuration)["instanceId"].ToString();
                Main.Sinusbot.StopPlayback(instanceId);
            }
            catch { }
        }

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new SelectInstanceDialog(this);
        }
    }

    public class PlayBackFileAction : PluginAction
    {
        public override string Name => "Playback file";

        public override string Description => "Starting the playback of a file";

        public override string DisplayName { get; set; } = "Playback file";

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
            } catch {}
            
        }

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new PlayBackFileActionConfigurator(this);
        }
    }
}
