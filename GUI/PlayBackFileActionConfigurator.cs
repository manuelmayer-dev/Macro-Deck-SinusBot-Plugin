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
using SuchByte.MacroDeck.Utils;
using System.Threading.Tasks;
using System.Diagnostics;
using SuchByte.MacroDeck.GUI;
using SuchByte.SinusBotPlugin.Language;
using SuchByte.MacroDeck.Language;

namespace SuchByte.SinusBotPlugin.GUI
{
    public partial class PlayBackFileActionConfigurator : ActionConfigControl
    {
        string InstanceId = "";
        string FileId = "";

        string InstanceName = "";
        string FileTitle = "";
        int Volume = -1;

        List<JObject> files;

        PluginAction _macroDeckAction;

        public PlayBackFileActionConfigurator(PluginAction macroDeckAction, ActionConfigurator actionConfigurator)
        {
            this._macroDeckAction = macroDeckAction;
            InitializeComponent();
            this.search.PlaceHolderText = LanguageManager.Strings.Search;
            this.lblInstance.Text = PluginLanguageManager.PluginStrings.Instance;
            this.checkSetVolume.Text = PluginLanguageManager.PluginStrings.SetVolume;
            this.checkSyncButtonState.Text = PluginLanguageManager.PluginStrings.SyncButtonState;

            if (this._macroDeckAction.Configuration != null && !String.IsNullOrWhiteSpace(this._macroDeckAction.Configuration))
            {
                JObject currentConfiguration = JObject.Parse(this._macroDeckAction.Configuration);
                this.InstanceId = currentConfiguration["instanceId"].ToString();
                this.FileId = currentConfiguration["fileId"].ToString();
                this.Volume = Int32.Parse(currentConfiguration["volume"].ToString());
                if (currentConfiguration["syncButtonState"] != null)
                {
                    this.checkSyncButtonState.Checked = bool.Parse(currentConfiguration["syncButtonState"].ToString());
                }
                
                try
                {
                    this.InstanceName = Main.Sinusbot.GetInstanceName(this.InstanceId);
                    this.FileTitle = Main.Sinusbot.GetFileTitle(this.FileId);
                } catch { }
            }
        }

        public override bool OnActionSave()
        {
            if (String.IsNullOrWhiteSpace(this.InstanceId) || String.IsNullOrWhiteSpace(this.FileId))
            {
                return false;
            }
            this.Volume = this.checkSetVolume.Checked ? this.playBackVolume.Value : -1;
            JObject configurationObject = JObject.FromObject(new
            {
                instanceId = this.InstanceId,
                fileId = this.FileId,
                volume = this.Volume,
                syncButtonState = this.checkSyncButtonState.Checked,
            }) ;
            this._macroDeckAction.Configuration = configurationObject.ToString();
            this._macroDeckAction.ConfigurationSummary = this.InstanceName + " : " + this.FileTitle + (this.Volume > -1 ? String.Format(" : {0}%", this.Volume) : "") + (this.checkSyncButtonState.Checked ? " (" + PluginLanguageManager.PluginStrings.SyncButtonState + ")" : "");
            return true;
        }


        private void PlayBackFileActionConfigurator_Load(object sender, EventArgs e)
        {
            Task.Run(() => {
                this.LoadInstances();
                this.LoadFiles();
            });
            
            if (this.Volume > 0)
            {
                this.checkSetVolume.Checked = true;
                this.playBackVolume.Value = this.Volume;
                this.PlayBackVolume_Scroll(this.playBackVolume, EventArgs.Empty);
            }

        }

        private void InstanceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadFiles();
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
                    this.instanceBox.Items.Add(instanceObject["nick"]);
                }

                if (this.InstanceName != null && this.InstanceName.Length > 0)
                {
                    this.instanceBox.Text = this.InstanceName;

                }
                else
                {
                    this.instanceBox.SelectedIndex = 0;
                }
            }));
        }

        private void LoadFiles(string search = "")
        {
            if (Main.Sinusbot == null || Main.Sinusbot.GetBotInstances() == null)
            {
                return;
            }
            this.Invoke(new Action(() => {
                this.fileList.Items.Clear();
                if (this.files == null)
                {
                    this.files = Main.Sinusbot.GetFileList();
                }
                foreach (JObject instanceObject in this.files)
                {
                    if (search.Length > 1 && !StringSearch.StringContains(instanceObject["title"].ToString(), search)) continue;
                    this.fileList.Items.Add(instanceObject["title"]);
                }

                if (this.FileTitle != null && this.FileTitle.Length > 0)
                {
                    this.fileList.SetSelected(fileList.FindString(this.FileTitle), true);
                }
            }));
            
        }

        private void PlayBackVolume_Scroll(object sender, EventArgs e)
        {
            this.lblVolume.Text = String.Format("{0}%", this.playBackVolume.Value);
            this.Volume = this.playBackVolume.Value;
        }

        private void CheckSetVolume_CheckedChanged(object sender, EventArgs e)
        {
            this.playBackVolume.Enabled = this.checkSetVolume.Checked;
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            this.LoadFiles(search.Text);
        }

        private void FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InstanceId = Main.Sinusbot.GetInstanceId(this.instanceBox.Text);
            this.FileId = Main.Sinusbot.GetFileId(this.fileList.Text);
            this.InstanceName = this.instanceBox.Text;
            this.FileTitle = this.fileList.Text;
        }

    }
}
