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
using SuchByte.MacroDeck.Server;
using System.Diagnostics;
using SuchByte.SinusBotPlugin.Language;
using SuchByte.SinusBotPlugin.Actions;

namespace SuchByte.SinusBotPlugin
{
    public static class PluginInstance
    {
        public static Main Main { get; set; }
    }


    public class Main : MacroDeckPlugin
    {
        public static Sinusbot Sinusbot;
        public override string Description => "This plugin can control a SinusBot music bot.";
        public override bool CanConfigure => true;
        public override Image Icon => Properties.Resources.SinusBot_Plugin;

        public Main()
        {
            PluginInstance.Main = this;
        }

        public override void Enable() {
            PluginLanguageManager.Initialize();
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
}
