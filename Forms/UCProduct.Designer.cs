namespace Window_Project_v5._1.Forms
{
    partial class UCProduct
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
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblArea = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelBody.BorderThickness = 1;
            this.panelBody.Controls.Add(this.guna2Panel1);
            this.panelBody.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(5);
            this.panelBody.Size = new System.Drawing.Size(220, 349);
            this.panelBody.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblArea);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.lblBuyPrice);
            this.guna2Panel1.Controls.Add(this.lblSellPrice);
            this.guna2Panel1.Controls.Add(this.lblProductName);
            this.guna2Panel1.Controls.Add(this.pbProductImage);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(5, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(210, 339);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblArea.Location = new System.Drawing.Point(26, 304);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(185, 35);
            this.lblArea.TabIndex = 49;
            this.lblArea.Text = "location";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PictureBox1.Image = global::Window_Project_v5._1.Properties.Resources.pin;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(6, 305);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(24, 31);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 48;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBuyPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBuyPrice.Location = new System.Drawing.Point(0, 266);
            this.lblBuyPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 10);
            this.lblBuyPrice.Size = new System.Drawing.Size(210, 34);
            this.lblBuyPrice.TabIndex = 47;
            this.lblBuyPrice.Text = "100.000 VND";
            this.lblBuyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSellPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSellPrice.Font = new System.Drawing.Font("Segoe UI", 14.2F, System.Drawing.FontStyle.Bold);
            this.lblSellPrice.ForeColor = System.Drawing.Color.Red;
            this.lblSellPrice.Location = new System.Drawing.Point(0, 236);
            this.lblSellPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSellPrice.Size = new System.Drawing.Size(210, 30);
            this.lblSellPrice.TabIndex = 45;
            this.lblSellPrice.Text = "100.000 VND";
            this.lblSellPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblProductName.Location = new System.Drawing.Point(0, 164);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblProductName.Size = new System.Drawing.Size(210, 72);
            this.lblProductName.TabIndex = 44;
            this.lblProductName.Text = "Product name";
            // 
            // pbProductImage
            // 
            this.pbProductImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbProductImage.Image = global::Window_Project_v5._1.Properties.Resources.laptop;
            this.pbProductImage.Location = new System.Drawing.Point(0, 0);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pbProductImage.Size = new System.Drawing.Size(210, 164);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 46;
            this.pbProductImage.TabStop = false;
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelBody);
            this.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(220, 349);
            this.Click += new System.EventHandler(this.UCProduct_Click);
            this.DoubleClick += new System.EventHandler(this.UCProduct_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.UCProduct_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCProduct_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UCProduct_MouseHover);
            this.panelBody.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label lblArea;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public System.Windows.Forms.Label lblBuyPrice;
        public System.Windows.Forms.Label lblSellPrice;
        public System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.PictureBox pbProductImage;
    }
}
