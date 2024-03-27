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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(63)))), ((int)(((byte)(150)))));
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pbLogo);
            this.panelTop.Controls.Add(this.lblSingin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1241, 62);
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
            this.pbLogo.Location = new System.Drawing.Point(-86, 8);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(40, 40);
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
            this.lblSingin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSingin.Location = new System.Drawing.Point(77, 18);
            this.lblSingin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSingin.Name = "lblSingin";
            this.lblSingin.Size = new System.Drawing.Size(201, 32);
            this.lblSingin.TabIndex = 43;
            this.lblSingin.Text = "Saved Prouct List";
            // 
            // flpSavedList
            // 
            this.flpSavedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSavedList.Location = new System.Drawing.Point(0, 62);
            this.flpSavedList.Name = "flpSavedList";
            this.flpSavedList.Size = new System.Drawing.Size(1241, 659);
            this.flpSavedList.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(1268, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Saved Prouct List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(1027, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Saved Prouct List";
            // 
            // FSaveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 721);
            this.Controls.Add(this.flpSavedList);
            this.Controls.Add(this.panelTop);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}