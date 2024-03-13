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
            this.panelBody = new Bunifu.UI.WinForms.BunifuPanel();
            this.panelLeft = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.panelBuyerSubmenu = new System.Windows.Forms.Panel();
            this.btnTrackOrder = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnBuyer = new System.Windows.Forms.Button();
            this.panelSellerSubmenu = new System.Windows.Forms.Panel();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnOrderAnalysis = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnSeller = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelBuyerSubmenu.SuspendLayout();
            this.panelSellerSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.panelBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBody.BackgroundImage")));
            this.panelBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBody.BorderColor = System.Drawing.Color.Transparent;
            this.panelBody.BorderRadius = 3;
            this.panelBody.BorderThickness = 1;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(226, 6);
            this.panelBody.Name = "panelBody";
            this.panelBody.ShowBorders = true;
            this.panelBody.Size = new System.Drawing.Size(963, 613);
            this.panelBody.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.BorderColor = System.Drawing.Color.Transparent;
            this.panelLeft.BorderRadius = 1;
            this.panelLeft.BorderThickness = 1;
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnInformation);
            this.panelLeft.Controls.Add(this.panelBuyerSubmenu);
            this.panelLeft.Controls.Add(this.btnBuyer);
            this.panelLeft.Controls.Add(this.panelSellerSubmenu);
            this.panelLeft.Controls.Add(this.btnSeller);
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(6, 6);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.ShowBorders = true;
            this.panelLeft.Size = new System.Drawing.Size(220, 613);
            this.panelLeft.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnLogout.Image = global::Window_Project_v5._1.Properties.Resources.exit_30px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 562);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 51);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "  log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnInformation.Image = global::Window_Project_v5._1.Properties.Resources.info_30px;
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.Location = new System.Drawing.Point(0, 449);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInformation.Size = new System.Drawing.Size(220, 51);
            this.btnInformation.TabIndex = 12;
            this.btnInformation.Text = "  Information";
            this.btnInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // panelBuyerSubmenu
            // 
            this.panelBuyerSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(110)))));
            this.panelBuyerSubmenu.Controls.Add(this.btnTrackOrder);
            this.panelBuyerSubmenu.Controls.Add(this.btnBuy);
            this.panelBuyerSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuyerSubmenu.Location = new System.Drawing.Point(0, 350);
            this.panelBuyerSubmenu.Name = "panelBuyerSubmenu";
            this.panelBuyerSubmenu.Size = new System.Drawing.Size(220, 99);
            this.panelBuyerSubmenu.TabIndex = 11;
            // 
            // btnTrackOrder
            // 
            this.btnTrackOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnTrackOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrackOrder.FlatAppearance.BorderSize = 0;
            this.btnTrackOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTrackOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnTrackOrder.Image = global::Window_Project_v5._1.Properties.Resources.tracking_30px;
            this.btnTrackOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrackOrder.Location = new System.Drawing.Point(0, 45);
            this.btnTrackOrder.Name = "btnTrackOrder";
            this.btnTrackOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTrackOrder.Size = new System.Drawing.Size(220, 45);
            this.btnTrackOrder.TabIndex = 1;
            this.btnTrackOrder.Text = "  Track Order";
            this.btnTrackOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrackOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrackOrder.UseVisualStyleBackColor = false;
            this.btnTrackOrder.Click += new System.EventHandler(this.btnTrackOrder_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnBuy.Image = global::Window_Project_v5._1.Properties.Resources.shopping_bag_30px;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.Location = new System.Drawing.Point(0, 0);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuy.Size = new System.Drawing.Size(220, 45);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "  Buy";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnBuyer
            // 
            this.btnBuyer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuyer.FlatAppearance.BorderSize = 0;
            this.btnBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnBuyer.Image = global::Window_Project_v5._1.Properties.Resources.cart_30px;
            this.btnBuyer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyer.Location = new System.Drawing.Point(0, 299);
            this.btnBuyer.Name = "btnBuyer";
            this.btnBuyer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuyer.Size = new System.Drawing.Size(220, 51);
            this.btnBuyer.TabIndex = 11;
            this.btnBuyer.Text = "  Buyer";
            this.btnBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuyer.UseVisualStyleBackColor = true;
            this.btnBuyer.Click += new System.EventHandler(this.btnBuyer_Click);
            // 
            // panelSellerSubmenu
            // 
            this.panelSellerSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(110)))));
            this.panelSellerSubmenu.Controls.Add(this.btnManagement);
            this.panelSellerSubmenu.Controls.Add(this.btnOrderAnalysis);
            this.panelSellerSubmenu.Controls.Add(this.btnSell);
            this.panelSellerSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSellerSubmenu.Location = new System.Drawing.Point(0, 151);
            this.panelSellerSubmenu.Name = "panelSellerSubmenu";
            this.panelSellerSubmenu.Size = new System.Drawing.Size(220, 148);
            this.panelSellerSubmenu.TabIndex = 10;
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnManagement.Image = global::Window_Project_v5._1.Properties.Resources.real_time_30px1;
            this.btnManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagement.Location = new System.Drawing.Point(0, 90);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManagement.Size = new System.Drawing.Size(220, 45);
            this.btnManagement.TabIndex = 3;
            this.btnManagement.Text = "  Manage";
            this.btnManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // btnOrderAnalysis
            // 
            this.btnOrderAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderAnalysis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderAnalysis.FlatAppearance.BorderSize = 0;
            this.btnOrderAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderAnalysis.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnOrderAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnOrderAnalysis.Image = global::Window_Project_v5._1.Properties.Resources.web_analytics_30px;
            this.btnOrderAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderAnalysis.Location = new System.Drawing.Point(0, 45);
            this.btnOrderAnalysis.Name = "btnOrderAnalysis";
            this.btnOrderAnalysis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrderAnalysis.Size = new System.Drawing.Size(220, 45);
            this.btnOrderAnalysis.TabIndex = 2;
            this.btnOrderAnalysis.Text = "  Order analysis";
            this.btnOrderAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderAnalysis.UseVisualStyleBackColor = false;
            this.btnOrderAnalysis.Click += new System.EventHandler(this.btnOrderAnalysis_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Transparent;
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnSell.Image = global::Window_Project_v5._1.Properties.Resources.write_v2_30px;
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Location = new System.Drawing.Point(0, 0);
            this.btnSell.Name = "btnSell";
            this.btnSell.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSell.Size = new System.Drawing.Size(220, 45);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "  Post product";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnSeller
            // 
            this.btnSeller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeller.FlatAppearance.BorderSize = 0;
            this.btnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeller.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnSeller.Image = global::Window_Project_v5._1.Properties.Resources.writing_30px;
            this.btnSeller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeller.Location = new System.Drawing.Point(0, 100);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSeller.Size = new System.Drawing.Size(220, 51);
            this.btnSeller.TabIndex = 9;
            this.btnSeller.Text = "  Seller";
            this.btnSeller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeller.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeller.UseVisualStyleBackColor = true;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 8;
            // 
            // FHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1195, 625);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FHomepage";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHomepage";
            this.panelLeft.ResumeLayout(false);
            this.panelBuyerSubmenu.ResumeLayout(false);
            this.panelSellerSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelLeft;
        private Bunifu.UI.WinForms.BunifuPanel panelBody;
        private System.Windows.Forms.Panel panelSellerSubmenu;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Panel panelBuyerSubmenu;
        private System.Windows.Forms.Button btnTrackOrder;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnBuyer;
        private System.Windows.Forms.Button btnOrderAnalysis;
        private System.Windows.Forms.Button btnManagement;
    }
}