using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuchByte.SinusBotPlugin.GUI
{
    public partial class PluginConfig : DialogForm
    {
        Main main;

        public PluginConfig(Main main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void PluginConfig_Load(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> credentialsList = PluginCredentials.GetPluginCredentials(this.main);
            Dictionary<string, string> credentials = null;
            if (credentialsList.Count > 0)
            {
                credentials = credentialsList[0];
            }
            if (credentials != null)
            {
                this.inputUrl.Text = credentials["url"];
                this.inputUser.Text = credentials["username"];
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.inputUrl.Text.Length == 0)
            {
                using (var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox())
                {
                    messageBox.ShowDialog("Unable to connect to the SinusBot", "The url cannot be empty", MessageBoxButtons.OK);
                }
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            this.btnOk.Enabled = false;
            Task.Run(() =>
            {
                try
                {
                    Main.Sinusbot = new Sinusbot(this.inputUrl.Text, this.inputUser.Text, this.inputPassword.Text);
                } catch {}
                
                if (Main.Sinusbot.LoggedIn)
                {
                    Dictionary<string, string> credentials = new Dictionary<string, string>();
                    credentials["url"] = inputUrl.Text;
                    credentials["username"] = inputUser.Text;
                    credentials["password"] = inputPassword.Text;
                    PluginCredentials.SetCredentials(this.main, credentials);
                    this.Invoke(new Action(() =>
                    {
                        Cursor.Current = Cursors.Default;
                        using (var messageBox = new MacroDeck.GUI.CustomControls.MessageBox())
                        {
                            messageBox.ShowDialog("Success", "Successfully connected to the SinusBot server.", MessageBoxButtons.OK);
                        }
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }));
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    this.Invoke(new Action(() =>
                    {
                        using (var messageBox = new MacroDeck.GUI.CustomControls.MessageBox())
                        {
                            messageBox.ShowDialog("Unable to connect to the SinusBot", "Perhaps the url, username or password is wrong?", MessageBoxButtons.OK);
                        }
                        this.btnOk.Enabled = true;
                    }));
                }
            });
            
        }
    }
}
