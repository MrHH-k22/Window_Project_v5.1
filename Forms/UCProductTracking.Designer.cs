namespace Window_Project_v5._1.Forms
{
    partial class UCProductTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductTracking));
            this.lblPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProductCondition = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProductName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSellerName = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbProduct = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AllowParentOverrides = false;
            this.lblPrice.AutoEllipsis = false;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrice.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPrice.Location = new System.Drawing.Point(1049, 15);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(169, 30);
            this.lblPrice.TabIndex = 2;
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
            this.lblProductCondition.Location = new System.Drawing.Point(905, 60);
            this.lblProductCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblProductCondition.Name = "lblProductCondition";
            this.lblProductCondition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductCondition.Size = new System.Drawing.Size(108, 30);
            this.lblProductCondition.TabIndex = 26;
            this.lblProductCondition.Text = "Completed";
            this.lblProductCondition.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProductCondition.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.lblProductName.Location = new System.Drawing.Point(155, 17);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductName.Size = new System.Drawing.Size(150, 31);
            this.lblProductName.TabIndex = 27;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProductName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.lblSellerName.Location = new System.Drawing.Point(155, 63);
            this.lblSellerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSellerName.Size = new System.Drawing.Size(126, 31);
            this.lblSellerName.TabIndex = 28;
            this.lblSellerName.Text = "Seller Name";
            this.lblSellerName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSellerName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.pbProduct.Location = new System.Drawing.Point(17, 9);
            this.pbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(105, 105);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 29;
            this.pbProduct.TabStop = false;
            this.pbProduct.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDetail.Location = new System.Drawing.Point(1129, 57);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(89, 37);
            this.btnDetail.TabIndex = 30;
            this.btnDetail.Text = "Detail";
            this.btnDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            this.btnDetail.MouseEnter += new System.EventHandler(this.btnDetail_MouseEnter);
            this.btnDetail.MouseLeave += new System.EventHandler(this.btnDetail_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.Location = new System.Drawing.Point(1027, 57);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 37);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UCProductTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.lblSellerName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductCondition);
            this.Controls.Add(this.lblPrice);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCProductTracking";
            this.Size = new System.Drawing.Size(1230, 114);
            this.Load += new System.EventHandler(this.UCProductTracking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.UI.WinForms.BunifuLabel lblPrice;
        public Bunifu.UI.WinForms.BunifuLabel lblProductCondition;
        public Bunifu.UI.WinForms.BunifuLabel lblProductName;
        public Bunifu.UI.WinForms.BunifuLabel lblSellerName;
        public Bunifu.UI.WinForms.BunifuPictureBox pbProduct;
        public System.Windows.Forms.Button btnDetail;
        public System.Windows.Forms.Button btnCancel;
    }
}
