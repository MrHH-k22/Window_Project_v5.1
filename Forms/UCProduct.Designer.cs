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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProduct));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.ratingProduct = new Bunifu.UI.WinForms.BunifuRating();
            this.btnDetail = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblProductName.Location = new System.Drawing.Point(4, 155);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(238, 48);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Product name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblItemPrice.Font = new System.Drawing.Font("Segoe UI", 14.2F, System.Drawing.FontStyle.Bold);
            this.lblItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblItemPrice.Location = new System.Drawing.Point(4, 234);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(238, 48);
            this.lblItemPrice.TabIndex = 11;
            this.lblItemPrice.Text = "100.000 VND";
            this.lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemPrice.Click += new System.EventHandler(this.lblItemPrice_Click);
            // 
            // ratingProduct
            // 
            this.ratingProduct.BackColor = System.Drawing.Color.Transparent;
            this.ratingProduct.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingProduct.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.ratingProduct.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingProduct.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingProduct.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingProduct.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingProduct.InnerRadius = 2F;
            this.ratingProduct.Location = new System.Drawing.Point(58, 206);
            this.ratingProduct.Margin = new System.Windows.Forms.Padding(2);
            this.ratingProduct.Name = "ratingProduct";
            this.ratingProduct.OuterRadius = 10F;
            this.ratingProduct.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingProduct.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingProduct.ReadOnly = false;
            this.ratingProduct.RightClickToClear = true;
            this.ratingProduct.Size = new System.Drawing.Size(131, 22);
            this.ratingProduct.Spacing = 6;
            this.ratingProduct.TabIndex = 12;
            this.ratingProduct.Text = "ratingProduct";
            this.ratingProduct.Value = 3;
            this.ratingProduct.ValueChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs>(this.ratingProduct_ValueChanged);
            // 
            // btnDetail
            // 
            this.btnDetail.AllowAnimations = true;
            this.btnDetail.AllowMouseEffects = true;
            this.btnDetail.AllowToggling = false;
            this.btnDetail.AnimationSpeed = 200;
            this.btnDetail.AutoGenerateColors = false;
            this.btnDetail.AutoRoundBorders = false;
            this.btnDetail.AutoSizeLeftIcon = true;
            this.btnDetail.AutoSizeRightIcon = true;
            this.btnDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnDetail.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetail.BackgroundImage")));
            this.btnDetail.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDetail.ButtonText = "Detail";
            this.btnDetail.ButtonTextMarginLeft = 0;
            this.btnDetail.ColorContrastOnClick = 45;
            this.btnDetail.ColorContrastOnHover = 45;
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDetail.CustomizableEdges = borderEdges2;
            this.btnDetail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDetail.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDetail.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDetail.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDetail.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetail.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDetail.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDetail.IconMarginLeft = 11;
            this.btnDetail.IconPadding = 10;
            this.btnDetail.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetail.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDetail.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDetail.IconSize = 25;
            this.btnDetail.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.IdleBorderRadius = 30;
            this.btnDetail.IdleBorderThickness = 1;
            this.btnDetail.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.IdleIconLeftImage = null;
            this.btnDetail.IdleIconRightImage = null;
            this.btnDetail.IndicateFocus = false;
            this.btnDetail.Location = new System.Drawing.Point(76, 278);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDetail.OnDisabledState.BorderRadius = 30;
            this.btnDetail.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDetail.OnDisabledState.BorderThickness = 1;
            this.btnDetail.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDetail.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDetail.OnDisabledState.IconLeftImage = null;
            this.btnDetail.OnDisabledState.IconRightImage = null;
            this.btnDetail.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.onHoverState.BorderRadius = 30;
            this.btnDetail.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDetail.onHoverState.BorderThickness = 1;
            this.btnDetail.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetail.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.onHoverState.IconLeftImage = null;
            this.btnDetail.onHoverState.IconRightImage = null;
            this.btnDetail.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.OnIdleState.BorderRadius = 30;
            this.btnDetail.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDetail.OnIdleState.BorderThickness = 1;
            this.btnDetail.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetail.OnIdleState.IconLeftImage = null;
            this.btnDetail.OnIdleState.IconRightImage = null;
            this.btnDetail.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.OnPressedState.BorderRadius = 30;
            this.btnDetail.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDetail.OnPressedState.BorderThickness = 1;
            this.btnDetail.OnPressedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetail.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.OnPressedState.IconLeftImage = null;
            this.btnDetail.OnPressedState.IconRightImage = null;
            this.btnDetail.Size = new System.Drawing.Size(88, 39);
            this.btnDetail.TabIndex = 34;
            this.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDetail.TextMarginLeft = 0;
            this.btnDetail.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDetail.UseDefaultRadiusAndThickness = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Window_Project_v5._1.Properties.Resources.laptop;
            this.pictureBox1.Location = new System.Drawing.Point(51, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ratingProduct);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblProductName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(245, 330);
            this.MouseEnter += new System.EventHandler(this.UCProduct_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCProduct_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.Label lblItemPrice;
        public Bunifu.UI.WinForms.BunifuRating ratingProduct;
        public System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnDetail;
    }
}
