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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
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
            this.lblProductName.Size = new System.Drawing.Size(220, 72);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Product name";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSellPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSellPrice.Font = new System.Drawing.Font("Segoe UI", 14.2F, System.Drawing.FontStyle.Bold);
            this.lblSellPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblSellPrice.Location = new System.Drawing.Point(0, 236);
            this.lblSellPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSellPrice.Size = new System.Drawing.Size(220, 30);
            this.lblSellPrice.TabIndex = 11;
            this.lblSellPrice.Text = "100.000 VND";
            this.lblSellPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSellPrice.Click += new System.EventHandler(this.lblItemPrice_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbProductImage.Image = global::Window_Project_v5._1.Properties.Resources.laptop;
            this.pbProductImage.Location = new System.Drawing.Point(0, 0);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(220, 164);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 13;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.lblBuyPrice.Size = new System.Drawing.Size(220, 34);
            this.lblBuyPrice.TabIndex = 35;
            this.lblBuyPrice.Text = "100.000 VND";
            this.lblBuyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lblBuyPrice);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pbProductImage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(220, 306);
            this.Click += new System.EventHandler(this.UCProduct_Click);
            this.DoubleClick += new System.EventHandler(this.UCProduct_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.UCProduct_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCProduct_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.Label lblSellPrice;
        public System.Windows.Forms.PictureBox pbProductImage;
        public System.Windows.Forms.Label lblBuyPrice;
    }
}
