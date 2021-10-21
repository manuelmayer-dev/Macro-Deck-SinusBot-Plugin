
namespace SuchByte.SinusBotPlugin.GUI
{
    partial class SelectInstanceDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.instanceBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instance:";
            // 
            // instanceBox
            // 
            this.instanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.instanceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instanceBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instanceBox.ForeColor = System.Drawing.Color.White;
            this.instanceBox.FormattingEnabled = true;
            this.instanceBox.Location = new System.Drawing.Point(4, 46);
            this.instanceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instanceBox.Name = "instanceBox";
            this.instanceBox.Size = new System.Drawing.Size(444, 31);
            this.instanceBox.TabIndex = 5;
            this.instanceBox.SelectedIndexChanged += new System.EventHandler(this.InstanceBox_SelectedIndexChanged);
            // 
            // SelectInstanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instanceBox);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SelectInstanceDialog";
            this.Load += new System.EventHandler(this.StopPlayBackConfigurator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox instanceBox;
    }
}