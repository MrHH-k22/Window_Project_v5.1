namespace Window_Project_v5._1.Forms
{
    partial class UCProductBuy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductBuy));
            this.pbProduct = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblSellerName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProductName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProductCondition = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnRate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProduct
            // 
            this.pbProduct.AllowFocused = false;
            this.pbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbProduct.AutoSizeHeight = true;
            this.pbProduct.BorderRadius = 0;
            this.pbProduct.Image = ((System.Drawing.Image)(resources.GetObject("pbProduct.Image")));
            this.pbProduct.IsCircle = true;
            this.pbProduct.Location = new System.Drawing.Point(12, 9);
            this.pbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(105, 105);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 36;
            this.pbProduct.TabStop = false;
            this.pbProduct.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // lblSellerName
            // 
            this.lblSellerName.AllowParentOverrides = false;
            this.lblSellerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSellerName.AutoEllipsis = false;
            this.lblSellerName.CursorType = null;
            this.lblSellerName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSellerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblSellerName.Location = new System.Drawing.Point(149, 63);
            this.lblSellerName.Margin = new System.Windows.Forms.Padding(4);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSellerName.Size = new System.Drawing.Size(126, 31);
            this.lblSellerName.TabIndex = 35;
            this.lblSellerName.Text = "Seller Name";
            this.lblSellerName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSellerName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblProductName
            // 
            this.lblProductName.AllowParentOverrides = false;
            this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProductName.AutoEllipsis = false;
            this.lblProductName.CursorType = null;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblProductName.Location = new System.Drawing.Point(149, 17);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductName.Size = new System.Drawing.Size(150, 31);
            this.lblProductName.TabIndex = 34;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProductName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPrice
            // 
            this.lblPrice.AllowParentOverrides = false;
            this.lblPrice.AutoEllipsis = false;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrice.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPrice.Location = new System.Drawing.Point(1044, 15);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(169, 30);
            this.lblPrice.TabIndex = 32;
            this.lblPrice.Text = "100.000.000 VND";
            this.lblPrice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblProductCondition
            // 
            this.lblProductCondition.AllowParentOverrides = false;
            this.lblProductCondition.AutoEllipsis = false;
            this.lblProductCondition.BackColor = System.Drawing.Color.DarkGray;
            this.lblProductCondition.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblProductCondition.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblProductCondition.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblProductCondition.Location = new System.Drawing.Point(536, 64);
            this.lblProductCondition.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductCondition.Name = "lblProductCondition";
            this.lblProductCondition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductCondition.Size = new System.Drawing.Size(108, 30);
            this.lblProductCondition.TabIndex = 33;
            this.lblProductCondition.Text = "Completed";
            this.lblProductCondition.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProductCondition.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnFunction
            // 
            
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnCancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(945, 57);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 37);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.BorderThickness = 1;
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetail.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.Location = new System.Drawing.Point(1085, 57);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(114, 37);
            this.btnDetail.TabIndex = 58;
            this.btnDetail.Text = "Detail";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnRate
            // 
            this.btnRate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnRate.BorderThickness = 1;
            this.btnRate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnRate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnRate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnRate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRate.Location = new System.Drawing.Point(945, 57);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(121, 37);
            this.btnRate.TabIndex = 57;
            this.btnRate.Text = "Rate";
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // UCProductBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.lblSellerName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductCondition);
            this.Controls.Add(this.lblPrice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCProductBuy";
            this.Size = new System.Drawing.Size(1229, 114);
            this.Load += new System.EventHandler(this.UCProductBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.UI.WinForms.BunifuPictureBox pbProduct;
        public Bunifu.UI.WinForms.BunifuLabel lblSellerName;
        public Bunifu.UI.WinForms.BunifuLabel lblProductName;
        public Bunifu.UI.WinForms.BunifuLabel lblPrice;
        public Bunifu.UI.WinForms.BunifuLabel lblProductCondition;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private Guna.UI2.WinForms.Guna2Button btnRate;
    }
}
