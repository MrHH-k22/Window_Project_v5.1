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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelBottom.SuspendLayout();
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
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnPurchase);
            this.panelBottom.Controls.Add(this.lblTotalMoney);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 499);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(931, 87);
            this.panelBottom.TabIndex = 36;
            // 
            // btnPurchase
            // 
            this.btnPurchase.AutoRoundedCorners = true;
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(149)))), ((int)(((byte)(35)))));
            this.btnPurchase.BorderRadius = 18;
            this.btnPurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(149)))), ((int)(((byte)(35)))));
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(298, 37);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(310, 39);
            this.btnPurchase.TabIndex = 7;
            this.btnPurchase.Text = "Purchase";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.Black;
            this.lblTotalMoney.Location = new System.Drawing.Point(488, 10);
            this.lblTotalMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(116, 25);
            this.lblTotalMoney.TabIndex = 6;
            this.lblTotalMoney.Text = "999000 VND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(293, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Money:";
            // 
            // FSaveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 586);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.flpSavedList);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FSaveList";
            this.Text = "FSaveList";
            this.Load += new System.EventHandler(this.FSaveList_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Bunifu.UI.WinForms.BunifuPictureBox pbLogo;
        private System.Windows.Forms.Label lblSingin;
        private System.Windows.Forms.FlowLayoutPanel flpSavedList;
        private System.Windows.Forms.Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnPurchase;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label label1;
    }
}