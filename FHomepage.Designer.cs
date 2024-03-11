namespace Window_Project_v5._1.Forms
{
    partial class FHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHomepage));
            this.panelLeft = new Bunifu.UI.WinForms.BunifuPanel();
            this.panelHomepage = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.BorderColor = System.Drawing.Color.Transparent;
            this.panelLeft.BorderRadius = 1;
            this.panelLeft.BorderThickness = 1;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(6, 6);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.ShowBorders = true;
            this.panelLeft.Size = new System.Drawing.Size(215, 613);
            this.panelLeft.TabIndex = 0;
            // 
            // panelHomepage
            // 
            this.panelHomepage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelHomepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHomepage.Location = new System.Drawing.Point(221, 6);
            this.panelHomepage.Name = "panelHomepage";
            this.panelHomepage.Size = new System.Drawing.Size(912, 613);
            this.panelHomepage.TabIndex = 2;
            // 
            // FHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1139, 625);
            this.Controls.Add(this.panelHomepage);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FHomepage";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHomepage";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelLeft;
        private System.Windows.Forms.FlowLayoutPanel panelHomepage;
    }
}