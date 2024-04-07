namespace Window_Project_v5._1.Forms
{
    partial class FSaveList
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.pbLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblSingin = new System.Windows.Forms.Label();
            this.flpSavedList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.pbLogo);
            this.panelTop.Controls.Add(this.lblSingin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(931, 50);
            this.panelTop.TabIndex = 34;
            // 
            // pbLogo
            // 
            this.pbLogo.AllowFocused = false;
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.AutoSizeHeight = true;
            this.pbLogo.BorderRadius = 0;
            this.pbLogo.Image = global::Window_Project_v5._1.Properties.Resources.box;
            this.pbLogo.IsCircle = true;
            this.pbLogo.Location = new System.Drawing.Point(-64, 6);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(30, 30);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 44;
            this.pbLogo.TabStop = false;
            this.pbLogo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // lblSingin
            // 
            this.lblSingin.AutoSize = true;
            this.lblSingin.BackColor = System.Drawing.Color.Transparent;
            this.lblSingin.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblSingin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblSingin.Location = new System.Drawing.Point(26, 9);
            this.lblSingin.Name = "lblSingin";
            this.lblSingin.Size = new System.Drawing.Size(86, 25);
            this.lblSingin.TabIndex = 43;
            this.lblSingin.Text = "Save List";
            // 
            // flpSavedList
            // 
            this.flpSavedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSavedList.Location = new System.Drawing.Point(0, 50);
            this.flpSavedList.Margin = new System.Windows.Forms.Padding(2);
            this.flpSavedList.Name = "flpSavedList";
            this.flpSavedList.Size = new System.Drawing.Size(931, 536);
            this.flpSavedList.TabIndex = 35;
            // 
            // FSaveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 586);
            this.Controls.Add(this.flpSavedList);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FSaveList";
            this.Text = "FSaveList";
            this.Load += new System.EventHandler(this.FSaveList_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Bunifu.UI.WinForms.BunifuPictureBox pbLogo;
        private System.Windows.Forms.Label lblSingin;
        private System.Windows.Forms.FlowLayoutPanel flpSavedList;
    }
}