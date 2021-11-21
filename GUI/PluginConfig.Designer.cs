
using SuchByte.MacroDeck.GUI.CustomControls;

namespace SuchByte.SinusBotPlugin.GUI
{
    partial class PluginConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUrl = new System.Windows.Forms.Label();
            this.inputUrl = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.inputUser = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.inputPassword = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnOk = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUrl.Location = new System.Drawing.Point(4, 17);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(91, 29);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "Url:";
            this.lblUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputUrl
            // 
            this.inputUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.inputUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputUrl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputUrl.ForeColor = System.Drawing.Color.White;
            this.inputUrl.Icon = null;
            this.inputUrl.Location = new System.Drawing.Point(101, 17);
            this.inputUrl.MaxCharacters = 32767;
            this.inputUrl.Multiline = false;
            this.inputUrl.Name = "inputUrl";
            this.inputUrl.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.inputUrl.PasswordChar = false;
            this.inputUrl.PlaceHolderColor = System.Drawing.Color.Gray;
            this.inputUrl.PlaceHolderText = "http://<hostname>:8087";
            this.inputUrl.ReadOnly = false;
            this.inputUrl.SelectionStart = 0;
            this.inputUrl.Size = new System.Drawing.Size(376, 29);
            this.inputUrl.TabIndex = 4;
            this.inputUrl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputUser
            // 
            this.inputUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.inputUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputUser.ForeColor = System.Drawing.Color.White;
            this.inputUser.Icon = null;
            this.inputUser.Location = new System.Drawing.Point(101, 52);
            this.inputUser.MaxCharacters = 32767;
            this.inputUser.Multiline = false;
            this.inputUser.Name = "inputUser";
            this.inputUser.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.inputUser.PasswordChar = false;
            this.inputUser.PlaceHolderColor = System.Drawing.Color.Gray;
            this.inputUser.PlaceHolderText = "";
            this.inputUser.ReadOnly = false;
            this.inputUser.SelectionStart = 0;
            this.inputUser.Size = new System.Drawing.Size(376, 29);
            this.inputUser.TabIndex = 7;
            this.inputUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(4, 52);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(91, 29);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputPassword
            // 
            this.inputPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.inputPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPassword.ForeColor = System.Drawing.Color.White;
            this.inputPassword.Icon = null;
            this.inputPassword.Location = new System.Drawing.Point(101, 87);
            this.inputPassword.MaxCharacters = 32767;
            this.inputPassword.Multiline = false;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.inputPassword.PasswordChar = true;
            this.inputPassword.PlaceHolderColor = System.Drawing.Color.Gray;
            this.inputPassword.PlaceHolderText = "";
            this.inputPassword.ReadOnly = false;
            this.inputPassword.SelectionStart = 0;
            this.inputPassword.Size = new System.Drawing.Size(376, 29);
            this.inputPassword.TabIndex = 9;
            this.inputPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(4, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 29);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnOk.BorderRadius = 8;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(184)))));
            this.btnOk.Icon = null;
            this.btnOk.Location = new System.Drawing.Point(431, 122);
            this.btnOk.Name = "btnOk";
            this.btnOk.Progress = 0;
            this.btnOk.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // PluginConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 158);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.inputUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.inputUrl);
            this.Controls.Add(this.lblUrl);
            this.Name = "PluginConfig";
            this.Text = "PluginConfig";
            this.Load += new System.EventHandler(this.PluginConfig_Load);
            this.Controls.SetChildIndex(this.lblUrl, 0);
            this.Controls.SetChildIndex(this.inputUrl, 0);
            this.Controls.SetChildIndex(this.lblUser, 0);
            this.Controls.SetChildIndex(this.inputUser, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.inputPassword, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private RoundedTextBox inputUrl;
        private RoundedTextBox inputUser;
        private System.Windows.Forms.Label lblUser;
        private RoundedTextBox inputPassword;
        private System.Windows.Forms.Label lblPassword;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary btnOk;
    }
}