namespace Window_Project_v5._1.Forms
{
    partial class FBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBuy));
            this.panelTop = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.ddCategories = new Bunifu.UI.WinForms.BunifuDropdown();
            this.flpProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMinPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtMinPrice);
            this.panelTop.Controls.Add(this.txtMaxPrice);
            this.panelTop.Controls.Add(this.txtBrand);
            this.panelTop.Controls.Add(this.txtProductName);
            this.panelTop.Controls.Add(this.bunifuSeparator1);
            this.panelTop.Controls.Add(this.guna2Separator1);
            this.panelTop.Controls.Add(this.btnFilter);
            this.panelTop.Controls.Add(this.btnLoad);
            this.panelTop.Controls.Add(this.ddCategories);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1241, 68);
            this.panelTop.TabIndex = 2;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(10, 57);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1196, 11);
            this.bunifuSeparator1.TabIndex = 53;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.Location = new System.Drawing.Point(597, 19);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(10, 31);
            this.guna2Separator1.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.AutoRoundedCorners = true;
            this.btnFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnFilter.BorderRadius = 20;
            this.btnFilter.BorderThickness = 1;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnFilter.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilter.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnFilter.Location = new System.Drawing.Point(1103, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(126, 43);
            this.btnFilter.TabIndex = 52;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.AutoRoundedCorners = true;
            this.btnLoad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnLoad.BorderRadius = 20;
            this.btnLoad.BorderThickness = 1;
            this.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnLoad.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoad.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnLoad.Location = new System.Drawing.Point(961, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(126, 43);
            this.btnLoad.TabIndex = 51;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ddCategories
            // 
            this.ddCategories.BackColor = System.Drawing.Color.Transparent;
            this.ddCategories.BackgroundColor = System.Drawing.Color.White;
            this.ddCategories.BorderColor = System.Drawing.Color.Silver;
            this.ddCategories.BorderRadius = 1;
            this.ddCategories.Color = System.Drawing.Color.Silver;
            this.ddCategories.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddCategories.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddCategories.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddCategories.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddCategories.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddCategories.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddCategories.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCategories.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddCategories.FillDropDown = true;
            this.ddCategories.FillIndicator = false;
            this.ddCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddCategories.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ddCategories.ForeColor = System.Drawing.Color.Black;
            this.ddCategories.FormattingEnabled = true;
            this.ddCategories.Icon = null;
            this.ddCategories.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddCategories.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ddCategories.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddCategories.IndicatorThickness = 2;
            this.ddCategories.IsDropdownOpened = false;
            this.ddCategories.ItemBackColor = System.Drawing.Color.White;
            this.ddCategories.ItemBorderColor = System.Drawing.Color.White;
            this.ddCategories.ItemForeColor = System.Drawing.Color.Black;
            this.ddCategories.ItemHeight = 26;
            this.ddCategories.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.ddCategories.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddCategories.Items.AddRange(new object[] {
            "Toy",
            "Food",
            "Electronic",
            "Beauty",
            "Health",
            "Fashion",
            "Jewelry",
            "Sport",
            "Vehicle",
            "Book",
            "(ALL)"});
            this.ddCategories.ItemTopMargin = 3;
            this.ddCategories.Location = new System.Drawing.Point(760, 12);
            this.ddCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddCategories.Name = "ddCategories";
            this.ddCategories.Size = new System.Drawing.Size(189, 32);
            this.ddCategories.TabIndex = 6;
            this.ddCategories.Text = "Categories";
            this.ddCategories.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddCategories.TextLeftMargin = 5;
            this.ddCategories.SelectedIndexChanged += new System.EventHandler(this.ddCategories_SelectedIndexChanged);
            // 
            // flpProduct
            // 
            this.flpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProduct.Location = new System.Drawing.Point(0, 68);
            this.flpProduct.Name = "flpProduct";
            this.flpProduct.Size = new System.Drawing.Size(1241, 653);
            this.flpProduct.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.AutoScroll = true;
            this.txtProductName.BackColor = System.Drawing.Color.Transparent;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtProductName.Location = new System.Drawing.Point(12, 12);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtProductName.PlaceholderText = "Product Name";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(259, 43);
            this.txtProductName.TabIndex = 84;
            // 
            // txtBrand
            // 
            this.txtBrand.AutoScroll = true;
            this.txtBrand.BackColor = System.Drawing.Color.Transparent;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.DefaultText = "";
            this.txtBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBrand.ForeColor = System.Drawing.Color.Black;
            this.txtBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtBrand.Location = new System.Drawing.Point(284, 12);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBrand.PlaceholderText = "Brand";
            this.txtBrand.SelectedText = "";
            this.txtBrand.Size = new System.Drawing.Size(157, 43);
            this.txtBrand.TabIndex = 85;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.AutoScroll = true;
            this.txtMaxPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtMaxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxPrice.DefaultText = "";
            this.txtMaxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtMaxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaxPrice.ForeColor = System.Drawing.Color.Black;
            this.txtMaxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtMaxPrice.Location = new System.Drawing.Point(455, 12);
            this.txtMaxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.PasswordChar = '\0';
            this.txtMaxPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaxPrice.PlaceholderText = "Max";
            this.txtMaxPrice.SelectedText = "";
            this.txtMaxPrice.Size = new System.Drawing.Size(131, 43);
            this.txtMaxPrice.TabIndex = 86;
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.AutoScroll = true;
            this.txtMinPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtMinPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinPrice.DefaultText = "";
            this.txtMinPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMinPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMinPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtMinPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMinPrice.ForeColor = System.Drawing.Color.Black;
            this.txtMinPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtMinPrice.Location = new System.Drawing.Point(619, 12);
            this.txtMinPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.PasswordChar = '\0';
            this.txtMinPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMinPrice.PlaceholderText = "Min";
            this.txtMinPrice.SelectedText = "";
            this.txtMinPrice.Size = new System.Drawing.Size(131, 43);
            this.txtMinPrice.TabIndex = 87;
            // 
            // FBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1241, 721);
            this.Controls.Add(this.flpProduct);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FBuy";
            this.Text = "FBuy";
            this.Load += new System.EventHandler(this.FBuy_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private Bunifu.UI.WinForms.BunifuDropdown ddCategories;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.FlowLayoutPanel flpProduct;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Guna.UI2.WinForms.Guna2TextBox txtMinPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtMaxPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtBrand;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
    }
}