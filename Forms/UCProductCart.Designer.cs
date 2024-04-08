﻿namespace Window_Project_v5._1.Forms
{
    partial class UCProductCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductCart));
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbProduct = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblSellerName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProductName = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelBody.BorderRadius = 10;
            this.panelBody.BorderThickness = 1;
            this.panelBody.Controls.Add(this.guna2CustomCheckBox1);
            this.panelBody.Controls.Add(this.btnDetail);
            this.panelBody.Controls.Add(this.btnDelete);
            this.panelBody.Controls.Add(this.lblPrice);
            this.panelBody.Controls.Add(this.pbProduct);
            this.panelBody.Controls.Add(this.lblSellerName);
            this.panelBody.Controls.Add(this.lblProductName);
            this.panelBody.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1040, 118);
            this.panelBody.TabIndex = 0;
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
            this.btnDetail.Location = new System.Drawing.Point(912, 62);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(114, 37);
            this.btnDetail.TabIndex = 67;
            this.btnDetail.Text = "Detail";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(772, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 37);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete";
            // 
            // lblPrice
            // 
            this.lblPrice.AllowParentOverrides = false;
            this.lblPrice.AutoEllipsis = false;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrice.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPrice.Location = new System.Drawing.Point(854, 20);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(169, 30);
            this.lblPrice.TabIndex = 65;
            this.lblPrice.Text = "100.000.000 VND";
            this.lblPrice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.pbProduct.Location = new System.Drawing.Point(92, 9);
            this.pbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(105, 105);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 64;
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
            this.lblSellerName.Location = new System.Drawing.Point(232, 62);
            this.lblSellerName.Margin = new System.Windows.Forms.Padding(4);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSellerName.Size = new System.Drawing.Size(126, 31);
            this.lblSellerName.TabIndex = 63;
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
            this.lblProductName.Location = new System.Drawing.Point(229, 17);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductName.Size = new System.Drawing.Size(150, 31);
            this.lblProductName.TabIndex = 62;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProductName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 6;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(24, 37);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(51, 37);
            this.guna2CustomCheckBox1.TabIndex = 70;
            this.guna2CustomCheckBox1.Text = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 6;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 1;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // UCProductCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.Name = "UCProductCart";
            this.Size = new System.Drawing.Size(1040, 118);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        public Bunifu.UI.WinForms.BunifuLabel lblPrice;
        public Bunifu.UI.WinForms.BunifuPictureBox pbProduct;
        public Bunifu.UI.WinForms.BunifuLabel lblSellerName;
        public Bunifu.UI.WinForms.BunifuLabel lblProductName;
        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
    }
}