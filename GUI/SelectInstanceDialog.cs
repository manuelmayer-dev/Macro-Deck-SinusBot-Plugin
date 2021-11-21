using SuchByte.MacroDeck.GUI.CustomControls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuchByte.MacroDeck.Plugins;
using System.Threading.Tasks;
using SuchByte.SinusBotPlugin.Language;

namespace SuchByte.SinusBotPlugin.GUI
{
    public partial class SelectInstanceDialog : ActionConfigControl
    {

        PluginAction _macroDeckAction;
        public SelectInstanceDialog(PluginAction macroDeckAction)
        {
            this._macroDeckAction = macroDeckAction;
            InitializeComponent();

            this.lblInstance.Text = PluginLanguageManager.PluginStrings.Instance;
            Task.Run(() =>
            {
                this.LoadInstances();
            });
        }

        private void LoadInstances()
        {
            if (Main.Sinusbot == null || Main.Sinusbot.GetBotInstances() == null)
            {
                this.Invoke(new Action(() =>
                {
                    using (var msgBox = new MacroDeck.GUI.CustomControls.MessageBox())
                    {
                        msgBox.ShowDialog(PluginLanguageManager.PluginStrings.NotReady, PluginLanguageManager.PluginStrings.SinusBotNotConfigured, MessageBoxButtons.OK);
                    }
                }));

                return;
            }
            this.Invoke(new Action(() =>
            {
                this.instanceBox.Items.Clear();
                foreach (JObject instanceObject in Main.Sinusbot.GetBotInstances())
                {
                    this.instanceBox.Items.Add(instanceObject["name"]);
                }
                this.instanceBox.SelectedIndex = 0;
            }));
            
        }

        public override bool OnActionSave()
        {
            string instanceId = Main.Sinusbot.GetInstanceId(this.instanceBox.Text);
            string instanceName = instanceBox.Text;
            if (String.IsNullOrWhiteSpace(instanceId) || String.IsNullOrWhiteSpace(instanceName)) return false;

            JObject configurationObject = JObject.FromObject(new
            {
                instanceId = instanceId,
            });

            this._macroDeckAction.Configuration = configurationObject.ToString();
            this._macroDeckAction.ConfigurationSummary = instanceName;
            return true;
        }



    }
}
