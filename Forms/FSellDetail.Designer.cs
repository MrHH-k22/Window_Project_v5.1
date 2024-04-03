namespace Window_Project_v5._1.Forms
{
    partial class FSellDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSellDetail));
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnPost = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.ddCategory = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnImage4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnImage3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnImage2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddCategories = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImage1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblSingin = new System.Windows.Forms.Label();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCondition = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBuyPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelBody.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.Controls.Add(this.txtDescription);
            this.panelBody.Controls.Add(this.txtBrand);
            this.panelBody.Controls.Add(this.txtProductTitle);
            this.panelBody.Controls.Add(this.txtSellPrice);
            this.panelBody.Controls.Add(this.txtBuyPrice);
            this.panelBody.Controls.Add(this.txtCondition);
            this.panelBody.Controls.Add(this.txtStatus);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Controls.Add(this.btnPost);
            this.panelBody.Controls.Add(this.bunifuSeparator1);
            this.panelBody.Controls.Add(this.ddCategory);
            this.panelBody.Controls.Add(this.btnImage4);
            this.panelBody.Controls.Add(this.btnImage3);
            this.panelBody.Controls.Add(this.btnImage2);
            this.panelBody.Controls.Add(this.label4);
            this.panelBody.Controls.Add(this.label3);
            this.panelBody.Controls.Add(this.label2);
            this.panelBody.Controls.Add(this.ddCategories);
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Controls.Add(this.btnImage1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1027, 546);
            this.panelBody.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnClose.BorderRadius = 26;
            this.btnClose.BorderThickness = 1;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnClose.Location = new System.Drawing.Point(774, 698);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(203, 55);
            this.btnClose.TabIndex = 76;
            this.btnClose.Text = "Go Back";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPost
            // 
            this.btnPost.AutoRoundedCorners = true;
            this.btnPost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.BorderRadius = 26;
            this.btnPost.BorderThickness = 1;
            this.btnPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnPost.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.Location = new System.Drawing.Point(399, 698);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(359, 55);
            this.btnPost.TabIndex = 75;
            this.btnPost.Text = "Post product";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(49, 766);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(928, 17);
            this.bunifuSeparator1.TabIndex = 74;
            // 
            // ddCategory
            // 
            this.ddCategory.BackColor = System.Drawing.Color.Transparent;
            this.ddCategory.BackgroundColor = System.Drawing.Color.White;
            this.ddCategory.BorderColor = System.Drawing.Color.Silver;
            this.ddCategory.BorderRadius = 1;
            this.ddCategory.Color = System.Drawing.Color.Silver;
            this.ddCategory.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddCategory.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddCategory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddCategory.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddCategory.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddCategory.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddCategory.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCategory.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddCategory.FillDropDown = true;
            this.ddCategory.FillIndicator = false;
            this.ddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddCategory.ForeColor = System.Drawing.Color.Black;
            this.ddCategory.FormattingEnabled = true;
            this.ddCategory.Icon = null;
            this.ddCategory.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddCategory.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ddCategory.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddCategory.IndicatorThickness = 2;
            this.ddCategory.IsDropdownOpened = false;
            this.ddCategory.ItemBackColor = System.Drawing.Color.White;
            this.ddCategory.ItemBorderColor = System.Drawing.Color.White;
            this.ddCategory.ItemForeColor = System.Drawing.Color.Black;
            this.ddCategory.ItemHeight = 26;
            this.ddCategory.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddCategory.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddCategory.Items.AddRange(new object[] {
            "Toy",
            "Food",
            "Electronic",
            "Beauty",
            "Health",
            "Fashion",
            "Jewelry",
            "Sport",
            "Vehicle",
            "Book"});
            this.ddCategory.ItemTopMargin = 3;
            this.ddCategory.Location = new System.Drawing.Point(398, 156);
            this.ddCategory.Name = "ddCategory";
            this.ddCategory.Size = new System.Drawing.Size(578, 32);
            this.ddCategory.TabIndex = 73;
            this.ddCategory.Text = "Category";
            this.ddCategory.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddCategory.TextLeftMargin = 5;
            this.ddCategory.SelectedIndexChanged += new System.EventHandler(this.ddCategory_SelectedIndexChanged);
            // 
            // btnImage4
            // 
            this.btnImage4.ActiveImage = null;
            this.btnImage4.AllowAnimations = true;
            this.btnImage4.AllowBuffering = false;
            this.btnImage4.AllowToggling = false;
            this.btnImage4.AllowZooming = true;
            this.btnImage4.AllowZoomingOnFocus = false;
            this.btnImage4.BackColor = System.Drawing.Color.Transparent;
            this.btnImage4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImage4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnImage4.ErrorImage")));
            this.btnImage4.FadeWhenInactive = false;
            this.btnImage4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnImage4.Image = ((System.Drawing.Image)(resources.GetObject("btnImage4.Image")));
            this.btnImage4.ImageActive = null;
            this.btnImage4.ImageLocation = null;
            this.btnImage4.ImageMargin = 20;
            this.btnImage4.ImageSize = new System.Drawing.Size(80, 80);
            this.btnImage4.ImageZoomSize = new System.Drawing.Size(100, 100);
            this.btnImage4.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnImage4.InitialImage")));
            this.btnImage4.Location = new System.Drawing.Point(243, 338);
            this.btnImage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImage4.Name = "btnImage4";
            this.btnImage4.Rotation = 0;
            this.btnImage4.ShowActiveImage = true;
            this.btnImage4.ShowCursorChanges = true;
            this.btnImage4.ShowImageBorders = true;
            this.btnImage4.ShowSizeMarkers = false;
            this.btnImage4.Size = new System.Drawing.Size(100, 100);
            this.btnImage4.TabIndex = 68;
            this.btnImage4.ToolTipText = "";
            this.btnImage4.WaitOnLoad = false;
            this.btnImage4.Zoom = 20;
            this.btnImage4.ZoomSpeed = 10;
            this.btnImage4.Click += new System.EventHandler(this.btnImage4_Click);
            // 
            // btnImage3
            // 
            this.btnImage3.ActiveImage = null;
            this.btnImage3.AllowAnimations = true;
            this.btnImage3.AllowBuffering = false;
            this.btnImage3.AllowToggling = false;
            this.btnImage3.AllowZooming = true;
            this.btnImage3.AllowZoomingOnFocus = false;
            this.btnImage3.BackColor = System.Drawing.Color.Transparent;
            this.btnImage3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImage3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnImage3.ErrorImage")));
            this.btnImage3.FadeWhenInactive = false;
            this.btnImage3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnImage3.Image = ((System.Drawing.Image)(resources.GetObject("btnImage3.Image")));
            this.btnImage3.ImageActive = null;
            this.btnImage3.ImageLocation = null;
            this.btnImage3.ImageMargin = 20;
            this.btnImage3.ImageSize = new System.Drawing.Size(80, 80);
            this.btnImage3.ImageZoomSize = new System.Drawing.Size(100, 100);
            this.btnImage3.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnImage3.InitialImage")));
            this.btnImage3.Location = new System.Drawing.Point(137, 338);
            this.btnImage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImage3.Name = "btnImage3";
            this.btnImage3.Rotation = 0;
            this.btnImage3.ShowActiveImage = true;
            this.btnImage3.ShowCursorChanges = true;
            this.btnImage3.ShowImageBorders = true;
            this.btnImage3.ShowSizeMarkers = false;
            this.btnImage3.Size = new System.Drawing.Size(100, 100);
            this.btnImage3.TabIndex = 67;
            this.btnImage3.ToolTipText = "";
            this.btnImage3.WaitOnLoad = false;
            this.btnImage3.Zoom = 20;
            this.btnImage3.ZoomSpeed = 10;
            this.btnImage3.Click += new System.EventHandler(this.btnImage3_Click);
            // 
            // btnImage2
            // 
            this.btnImage2.ActiveImage = null;
            this.btnImage2.AllowAnimations = true;
            this.btnImage2.AllowBuffering = false;
            this.btnImage2.AllowToggling = false;
            this.btnImage2.AllowZooming = true;
            this.btnImage2.AllowZoomingOnFocus = false;
            this.btnImage2.BackColor = System.Drawing.Color.Transparent;
            this.btnImage2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImage2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnImage2.ErrorImage")));
            this.btnImage2.FadeWhenInactive = false;
            this.btnImage2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnImage2.Image = ((System.Drawing.Image)(resources.GetObject("btnImage2.Image")));
            this.btnImage2.ImageActive = null;
            this.btnImage2.ImageLocation = null;
            this.btnImage2.ImageMargin = 20;
            this.btnImage2.ImageSize = new System.Drawing.Size(80, 80);
            this.btnImage2.ImageZoomSize = new System.Drawing.Size(100, 100);
            this.btnImage2.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnImage2.InitialImage")));
            this.btnImage2.Location = new System.Drawing.Point(31, 338);
            this.btnImage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImage2.Name = "btnImage2";
            this.btnImage2.Rotation = 0;
            this.btnImage2.ShowActiveImage = true;
            this.btnImage2.ShowCursorChanges = true;
            this.btnImage2.ShowImageBorders = true;
            this.btnImage2.ShowSizeMarkers = false;
            this.btnImage2.Size = new System.Drawing.Size(100, 100);
            this.btnImage2.TabIndex = 66;
            this.btnImage2.ToolTipText = "";
            this.btnImage2.WaitOnLoad = false;
            this.btnImage2.Zoom = 20;
            this.btnImage2.ZoomSpeed = 10;
            this.btnImage2.Click += new System.EventHandler(this.btnImage2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(393, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 31);
            this.label4.TabIndex = 61;
            this.label4.Text = "Product title and description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(393, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Condition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(391, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 31);
            this.label2.TabIndex = 55;
            this.label2.Text = "Detailed information";
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
            this.ddCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            "Book"});
            this.ddCategories.ItemTopMargin = 3;
            this.ddCategories.Location = new System.Drawing.Point(397, 32);
            this.ddCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddCategories.Name = "ddCategories";
            this.ddCategories.Size = new System.Drawing.Size(579, 32);
            this.ddCategories.TabIndex = 54;
            this.ddCategories.Text = "Categories";
            this.ddCategories.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddCategories.TextLeftMargin = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(91, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 53;
            this.label1.Text = "Product Image";
            // 
            // btnImage1
            // 
            this.btnImage1.ActiveImage = null;
            this.btnImage1.AllowAnimations = true;
            this.btnImage1.AllowBuffering = false;
            this.btnImage1.AllowToggling = false;
            this.btnImage1.AllowZooming = true;
            this.btnImage1.AllowZoomingOnFocus = false;
            this.btnImage1.BackColor = System.Drawing.Color.Transparent;
            this.btnImage1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImage1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnImage1.ErrorImage")));
            this.btnImage1.FadeWhenInactive = false;
            this.btnImage1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnImage1.Image = ((System.Drawing.Image)(resources.GetObject("btnImage1.Image")));
            this.btnImage1.ImageActive = null;
            this.btnImage1.ImageLocation = null;
            this.btnImage1.ImageMargin = 20;
            this.btnImage1.ImageSize = new System.Drawing.Size(220, 220);
            this.btnImage1.ImageZoomSize = new System.Drawing.Size(240, 240);
            this.btnImage1.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnImage1.InitialImage")));
            this.btnImage1.Location = new System.Drawing.Point(72, 79);
            this.btnImage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImage1.Name = "btnImage1";
            this.btnImage1.Rotation = 0;
            this.btnImage1.ShowActiveImage = true;
            this.btnImage1.ShowCursorChanges = true;
            this.btnImage1.ShowImageBorders = true;
            this.btnImage1.ShowSizeMarkers = false;
            this.btnImage1.Size = new System.Drawing.Size(240, 240);
            this.btnImage1.TabIndex = 52;
            this.btnImage1.ToolTipText = "";
            this.btnImage1.WaitOnLoad = false;
            this.btnImage1.Zoom = 20;
            this.btnImage1.ZoomSpeed = 10;
            this.btnImage1.Click += new System.EventHandler(this.btnImage1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.panelTop.Controls.Add(this.bunifuPictureBox1);
            this.panelTop.Controls.Add(this.lblSingin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1027, 69);
            this.panelTop.TabIndex = 1;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = global::Window_Project_v5._1.Properties.Resources.box;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(49, 11);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(45, 45);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 46;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // lblSingin
            // 
            this.lblSingin.AutoSize = true;
            this.lblSingin.BackColor = System.Drawing.Color.Transparent;
            this.lblSingin.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblSingin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSingin.Location = new System.Drawing.Point(100, 17);
            this.lblSingin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSingin.Name = "lblSingin";
            this.lblSingin.Size = new System.Drawing.Size(152, 32);
            this.lblSingin.TabIndex = 45;
            this.lblSingin.Text = "Post Product";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoScroll = true;
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "";
            this.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtStatus.Location = new System.Drawing.Point(397, 198);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtStatus.PlaceholderText = "Status";
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(579, 107);
            this.txtStatus.TabIndex = 78;
            // 
            // txtCondition
            // 
            this.txtCondition.AutoScroll = true;
            this.txtCondition.BackColor = System.Drawing.Color.Transparent;
            this.txtCondition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCondition.DefaultText = "";
            this.txtCondition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCondition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCondition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCondition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCondition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtCondition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCondition.ForeColor = System.Drawing.Color.Black;
            this.txtCondition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtCondition.Location = new System.Drawing.Point(491, 114);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.PasswordChar = '\0';
            this.txtCondition.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCondition.PlaceholderText = "%";
            this.txtCondition.SelectedText = "";
            this.txtCondition.Size = new System.Drawing.Size(102, 30);
            this.txtCondition.TabIndex = 79;
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.AutoScroll = true;
            this.txtBuyPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtBuyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuyPrice.DefaultText = "";
            this.txtBuyPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuyPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuyPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuyPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuyPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtBuyPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuyPrice.ForeColor = System.Drawing.Color.Black;
            this.txtBuyPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtBuyPrice.Location = new System.Drawing.Point(397, 319);
            this.txtBuyPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.PasswordChar = '\0';
            this.txtBuyPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBuyPrice.PlaceholderText = "Buy Price (VND)";
            this.txtBuyPrice.SelectedText = "";
            this.txtBuyPrice.Size = new System.Drawing.Size(577, 43);
            this.txtBuyPrice.TabIndex = 80;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.AutoScroll = true;
            this.txtSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellPrice.DefaultText = "";
            this.txtSellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtSellPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSellPrice.ForeColor = System.Drawing.Color.Black;
            this.txtSellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtSellPrice.Location = new System.Drawing.Point(398, 374);
            this.txtSellPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.PasswordChar = '\0';
            this.txtSellPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSellPrice.PlaceholderText = "Sell Price (VND)";
            this.txtSellPrice.SelectedText = "";
            this.txtSellPrice.Size = new System.Drawing.Size(577, 43);
            this.txtSellPrice.TabIndex = 81;
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.AutoScroll = true;
            this.txtProductTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtProductTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductTitle.DefaultText = "";
            this.txtProductTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtProductTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductTitle.ForeColor = System.Drawing.Color.Black;
            this.txtProductTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtProductTitle.Location = new System.Drawing.Point(401, 459);
            this.txtProductTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.PasswordChar = '\0';
            this.txtProductTitle.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtProductTitle.PlaceholderText = "Title";
            this.txtProductTitle.SelectedText = "";
            this.txtProductTitle.Size = new System.Drawing.Size(577, 43);
            this.txtProductTitle.TabIndex = 82;
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
            this.txtBrand.Location = new System.Drawing.Point(401, 517);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBrand.PlaceholderText = "Brand";
            this.txtBrand.SelectedText = "";
            this.txtBrand.Size = new System.Drawing.Size(577, 43);
            this.txtBrand.TabIndex = 83;
            // 
            // txtDescription
            // 
            this.txtDescription.AutoScroll = true;
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtDescription.Location = new System.Drawing.Point(401, 577);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(579, 107);
            this.txtDescription.TabIndex = 84;
            // 
            // FSellDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1027, 546);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBody);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FSellDetail";
            this.Text = "FSellDetail";
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown ddCategories;
        public System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton btnImage1;
        private Bunifu.UI.WinForms.BunifuImageButton btnImage4;
        private Bunifu.UI.WinForms.BunifuImageButton btnImage3;
        private Bunifu.UI.WinForms.BunifuImageButton btnImage2;
        private System.Windows.Forms.Panel panelTop;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label lblSingin;
        private Bunifu.UI.WinForms.BunifuDropdown ddCategory;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Guna.UI2.WinForms.Guna2Button btnPost;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtCondition;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtBrand;
        private Guna.UI2.WinForms.Guna2TextBox txtProductTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSellPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtBuyPrice;
    }
}