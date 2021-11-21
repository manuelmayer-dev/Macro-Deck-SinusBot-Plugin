
using SuchByte.MacroDeck.GUI.CustomControls;

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
            this.lblInstance = new System.Windows.Forms.Label();
            this.instanceBox = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.SuspendLayout();
            // 
            // lblInstance
            // 
            this.lblInstance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstance.Location = new System.Drawing.Point(111, 120);
            this.lblInstance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstance.Name = "lblInstance";
            this.lblInstance.Size = new System.Drawing.Size(122, 30);
            this.lblInstance.TabIndex = 6;
            this.lblInstance.Text = "Instance:";
            this.lblInstance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // instanceBox
            // 
            this.instanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.instanceBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instanceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instanceBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instanceBox.ForeColor = System.Drawing.Color.White;
            this.instanceBox.Icon = null;
            this.instanceBox.Location = new System.Drawing.Point(241, 120);
            this.instanceBox.Margin = new System.Windows.Forms.Padding(4);
            this.instanceBox.Name = "instanceBox";
            this.instanceBox.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.instanceBox.SelectedIndex = -1;
            this.instanceBox.SelectedItem = null;
            this.instanceBox.Size = new System.Drawing.Size(363, 30);
            this.instanceBox.TabIndex = 5;
            // 
            // SelectInstanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInstance);
            this.Controls.Add(this.instanceBox);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SelectInstanceDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInstance;
        private RoundedComboBox instanceBox;
    }
}