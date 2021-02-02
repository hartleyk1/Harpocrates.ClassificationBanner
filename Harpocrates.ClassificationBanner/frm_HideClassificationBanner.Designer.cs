
namespace Harpocrates.ClassificationBanner
{
    partial class frm_HideClassificationBanner
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tmr_Hide = new System.Windows.Forms.Timer(this.components);
            this.tmr_Message = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harpocrates.Banner will hide for 15 minutes.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tmr_Hide
            // 
            this.tmr_Hide.Enabled = true;
            this.tmr_Hide.Interval = 900000;
            this.tmr_Hide.Tick += new System.EventHandler(this.tmr_Hide_Tick);
            // 
            // tmr_Message
            // 
            this.tmr_Message.Enabled = true;
            this.tmr_Message.Interval = 3000;
            this.tmr_Message.Tick += new System.EventHandler(this.tmr_Message_Tick);
            // 
            // frm_HideClassificationBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 37);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_HideClassificationBanner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_HideClassificationBanner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmr_Hide;
        private System.Windows.Forms.Timer tmr_Message;
    }
}