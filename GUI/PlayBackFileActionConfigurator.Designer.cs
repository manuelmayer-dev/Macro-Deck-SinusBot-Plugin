
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
            this.instanceBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileList = new System.Windows.Forms.ListBox();
            this.playBackVolume = new System.Windows.Forms.TrackBar();
            this.checkSetVolume = new System.Windows.Forms.CheckBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playBackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // instanceBox
            // 
            this.instanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.instanceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instanceBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instanceBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instanceBox.ForeColor = System.Drawing.Color.White;
            this.instanceBox.FormattingEnabled = true;
            this.instanceBox.Location = new System.Drawing.Point(97, 1);
            this.instanceBox.Margin = new System.Windows.Forms.Padding(4);
            this.instanceBox.Name = "instanceBox";
            this.instanceBox.Size = new System.Drawing.Size(293, 26);
            this.instanceBox.TabIndex = 3;
            this.instanceBox.SelectedIndexChanged += new System.EventHandler(this.InstanceBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Instance:";
            // 
            // fileList
            // 
            this.fileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.fileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileList.ForeColor = System.Drawing.Color.White;
            this.fileList.FormattingEnabled = true;
            this.fileList.ItemHeight = 23;
            this.fileList.Location = new System.Drawing.Point(4, 73);
            this.fileList.Margin = new System.Windows.Forms.Padding(4);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(707, 163);
            this.fileList.TabIndex = 5;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged);
            // 
            // playBackVolume
            // 
            this.playBackVolume.AutoSize = false;
            this.playBackVolume.Enabled = false;
            this.playBackVolume.Location = new System.Drawing.Point(108, 244);
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
            this.checkSetVolume.Location = new System.Drawing.Point(0, 244);
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
            this.lblVolume.Location = new System.Drawing.Point(379, 247);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(33, 16);
            this.lblVolume.TabIndex = 9;
            this.lblVolume.Text = "50%";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(430, 36);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(281, 30);
            this.search.TabIndex = 10;
            this.search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SuchByte.SinusBotPlugin.Properties.Resources.magnifying_glass;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(400, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // PlayBackFileActionConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.checkSetVolume);
            this.Controls.Add(this.playBackVolume);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instanceBox);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PlayBackFileActionConfigurator";
            this.Load += new System.EventHandler(this.PlayBackFileActionConfigurator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playBackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox instanceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.TrackBar playBackVolume;
        private System.Windows.Forms.CheckBox checkSetVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}