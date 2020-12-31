using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Harpocrates.ClassificationBanner
{
    partial class frm_ClassificationBanner
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
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Classification = new System.Windows.Forms.Label();
            this.lbl_Computer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.lbl_User.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_User.Location = new System.Drawing.Point(0, 0);
            this.lbl_User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(37, 13);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "USER";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Classification
            // 
            this.lbl_Classification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Classification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Classification.ForeColor = System.Drawing.Color.White;
            this.lbl_Classification.Location = new System.Drawing.Point(0, 0);
            this.lbl_Classification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Classification.Name = "lbl_Classification";
            this.lbl_Classification.Size = new System.Drawing.Size(1290, 15);
            this.lbl_Classification.TabIndex = 2;
            this.lbl_Classification.Text = "CLASSIFICATION";
            this.lbl_Classification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Computer
            // 
            this.lbl_Computer.AutoSize = true;
            this.lbl_Computer.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.lbl_Computer.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_Computer.Location = new System.Drawing.Point(1222, 0);
            this.lbl_Computer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Computer.Name = "lbl_Computer";
            this.lbl_Computer.Size = new System.Drawing.Size(68, 13);
            this.lbl_Computer.TabIndex = 1;
            this.lbl_Computer.Text = "COMPUTER";
            this.lbl_Computer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ClassificationBanner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1290, 15);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Computer);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Classification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 10);
            this.Name = "frm_ClassificationBanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Classification;
        private System.Windows.Forms.Label lbl_Computer;

       

       
    }
}

