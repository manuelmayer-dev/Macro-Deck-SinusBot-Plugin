
using SuchByte.MacroDeck.GUI.CustomControls;

namespace SuchByte.SinusBotPlugin.GUI
{
    partial class PlayBackFileActionConfigurator
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
            this.instanceBox = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileList = new System.Windows.Forms.ListBox();
            this.playBackVolume = new System.Windows.Forms.TrackBar();
            this.checkSetVolume = new System.Windows.Forms.CheckBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.search = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.playBackVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // instanceBox
            // 
            this.instanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.instanceBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instanceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instanceBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instanceBox.ForeColor = System.Drawing.Color.White;
            this.instanceBox.Icon = null;
            this.instanceBox.Location = new System.Drawing.Point(130, 1);
            this.instanceBox.Margin = new System.Windows.Forms.Padding(4);
            this.instanceBox.Name = "instanceBox";
            this.instanceBox.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.instanceBox.SelectedIndex = -1;
            this.instanceBox.SelectedItem = null;
            this.instanceBox.Size = new System.Drawing.Size(293, 30);
            this.instanceBox.TabIndex = 3;
            this.instanceBox.SelectedIndexChanged += new System.EventHandler(this.InstanceBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Instance:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileList
            // 
            this.fileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.fileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileList.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileList.ForeColor = System.Drawing.Color.White;
            this.fileList.FormattingEnabled = true;
            this.fileList.ItemHeight = 18;
            this.fileList.Location = new System.Drawing.Point(4, 63);
            this.fileList.Margin = new System.Windows.Forms.Padding(4);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(707, 180);
            this.fileList.TabIndex = 5;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged);
            // 
            // playBackVolume
            // 
            this.playBackVolume.AutoSize = false;
            this.playBackVolume.Enabled = false;
            this.playBackVolume.Location = new System.Drawing.Point(259, 247);
            this.playBackVolume.Margin = new System.Windows.Forms.Padding(4);
            this.playBackVolume.Maximum = 100;
            this.playBackVolume.Minimum = 1;
            this.playBackVolume.Name = "playBackVolume";
            this.playBackVolume.Size = new System.Drawing.Size(263, 43);
            this.playBackVolume.TabIndex = 7;
            this.playBackVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.playBackVolume.Value = 50;
            this.playBackVolume.Scroll += new System.EventHandler(this.PlayBackVolume_Scroll);
            // 
            // checkSetVolume
            // 
            this.checkSetVolume.AutoSize = true;
            this.checkSetVolume.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkSetVolume.Location = new System.Drawing.Point(151, 247);
            this.checkSetVolume.Margin = new System.Windows.Forms.Padding(4);
            this.checkSetVolume.Name = "checkSetVolume";
            this.checkSetVolume.Size = new System.Drawing.Size(100, 22);
            this.checkSetVolume.TabIndex = 8;
            this.checkSetVolume.Text = "Set volume";
            this.checkSetVolume.UseVisualStyleBackColor = true;
            this.checkSetVolume.CheckedChanged += new System.EventHandler(this.CheckSetVolume_CheckedChanged);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVolume.Location = new System.Drawing.Point(530, 250);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(33, 16);
            this.lblVolume.TabIndex = 9;
            this.lblVolume.Text = "50%";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Icon = global::SuchByte.SinusBotPlugin.Properties.Resources.magnifying_glass;
            this.search.Location = new System.Drawing.Point(430, 31);
            this.search.Multiline = false;
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(26, 5, 8, 5);
            this.search.PasswordChar = false;
            this.search.PlaceHolderColor = System.Drawing.Color.Gray;
            this.search.PlaceHolderText = "Search file";
            this.search.ReadOnly = false;
            this.search.SelectionStart = 0;
            this.search.Size = new System.Drawing.Size(281, 25);
            this.search.TabIndex = 10;
            this.search.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // PlayBackFileActionConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.search);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.checkSetVolume);
            this.Controls.Add(this.playBackVolume);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instanceBox);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PlayBackFileActionConfigurator";
            this.Size = new System.Drawing.Size(715, 287);
            this.Load += new System.EventHandler(this.PlayBackFileActionConfigurator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playBackVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedComboBox instanceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.TrackBar playBackVolume;
        private System.Windows.Forms.CheckBox checkSetVolume;
        private System.Windows.Forms.Label lblVolume;
        private RoundedTextBox search;
    }
}