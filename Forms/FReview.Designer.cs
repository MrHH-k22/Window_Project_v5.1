﻿namespace Window_Project_v5._1.Forms
{
    partial class FReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FReview));
            this.flpRating = new System.Windows.Forms.FlowLayoutPanel();
            this.containerTop = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnPost = new Guna.UI2.WinForms.Guna2Button();
            this.btnCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnPostProduct = new Guna.UI2.WinForms.Guna2Button();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAvatarSeller = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblNameSeller = new System.Windows.Forms.Label();
            this.rsStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblNumberRatings = new System.Windows.Forms.Label();
            this.containerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // flpRating
            // 
            this.flpRating.AutoScroll = true;
            this.flpRating.Location = new System.Drawing.Point(939, 529);
            this.flpRating.Name = "flpRating";
            this.flpRating.Size = new System.Drawing.Size(133, 217);
            this.flpRating.TabIndex = 0;
            // 
            // containerTop
            // 
            this.containerTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.containerTop.Controls.Add(this.btnPost);
            this.containerTop.Controls.Add(this.btnCart);
            this.containerTop.Controls.Add(this.btnMenu);
            this.containerTop.Controls.Add(this.btnPostProduct);
            this.containerTop.Controls.Add(this.pbLogo);
            this.containerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.containerTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.containerTop.Location = new System.Drawing.Point(0, 0);
            this.containerTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containerTop.Name = "containerTop";
            this.containerTop.Size = new System.Drawing.Size(1500, 70);
            this.containerTop.TabIndex = 64;
            this.containerTop.Text = "guna2ContainerControl1";
            // 
            // btnPost
            // 
            this.btnPost.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnPost.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.Image = global::Window_Project_v5._1.Properties.Resources.edit;
            this.btnPost.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPost.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnPost.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPost.Location = new System.Drawing.Point(939, 10);
            this.btnPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.Size = new System.Drawing.Size(203, 46);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "POST NEWS";
            this.btnPost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPost.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // btnCart
            // 
            this.btnCart.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnCart.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnCart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnCart.Image = global::Window_Project_v5._1.Properties.Resources.shopping_Cart_White;
            this.btnCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCart.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnCart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCart.Location = new System.Drawing.Point(771, 10);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnCart.Size = new System.Drawing.Size(163, 46);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "CART";
            this.btnCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCart.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // btnMenu
            // 
            this.btnMenu.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnMenu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnMenu.Image = global::Window_Project_v5._1.Properties.Resources.down_arrow;
            this.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMenu.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnMenu.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMenu.Location = new System.Drawing.Point(1159, 11);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnMenu.Size = new System.Drawing.Size(292, 46);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // btnPostProduct
            // 
            this.btnPostProduct.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPostProduct.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnPostProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPostProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPostProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPostProduct.ForeColor = System.Drawing.Color.White;
            this.btnPostProduct.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnPostProduct.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPostProduct.Image = global::Window_Project_v5._1.Properties.Resources.edit;
            this.btnPostProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPostProduct.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnPostProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPostProduct.Location = new System.Drawing.Point(1169, 10);
            this.btnPostProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPostProduct.Name = "btnPostProduct";
            this.btnPostProduct.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPostProduct.Size = new System.Drawing.Size(203, 46);
            this.btnPostProduct.TabIndex = 1;
            this.btnPostProduct.Text = "POST NEWS";
            this.btnPostProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPostProduct.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.pbLogo.Image = global::Window_Project_v5._1.Properties.Resources.beach_14953675_v22;
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(188, 70);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rsStar);
            this.panel1.Controls.Add(this.lblStar);
            this.panel1.Controls.Add(this.lblNumberRatings);
            this.panel1.Controls.Add(this.lblNameSeller);
            this.panel1.Controls.Add(this.pbAvatarSeller);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 119);
            this.panel1.TabIndex = 65;
            // 
            // pbAvatarSeller
            // 
            this.pbAvatarSeller.AllowFocused = false;
            this.pbAvatarSeller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAvatarSeller.AutoSizeHeight = true;
            this.pbAvatarSeller.BorderRadius = 51;
            this.pbAvatarSeller.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatarSeller.Image")));
            this.pbAvatarSeller.IsCircle = true;
            this.pbAvatarSeller.Location = new System.Drawing.Point(33, 7);
            this.pbAvatarSeller.Name = "pbAvatarSeller";
            this.pbAvatarSeller.Size = new System.Drawing.Size(103, 103);
            this.pbAvatarSeller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatarSeller.TabIndex = 0;
            this.pbAvatarSeller.TabStop = false;
            this.pbAvatarSeller.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblNameSeller
            // 
            this.lblNameSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblNameSeller.Location = new System.Drawing.Point(159, 16);
            this.lblNameSeller.Name = "lblNameSeller";
            this.lblNameSeller.Size = new System.Drawing.Size(268, 34);
            this.lblNameSeller.TabIndex = 1;
            this.lblNameSeller.Text = "Andrew Dalton";
            // 
            // rsStar
            // 
            this.rsStar.FillColor = System.Drawing.Color.Transparent;
            this.rsStar.Location = new System.Drawing.Point(202, 56);
            this.rsStar.Name = "rsStar";
            this.rsStar.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.rsStar.Size = new System.Drawing.Size(193, 38);
            this.rsStar.TabIndex = 8;
            // 
            // lblStar
            // 
            this.lblStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblStar.Location = new System.Drawing.Point(160, 64);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(77, 33);
            this.lblStar.TabIndex = 7;
            this.lblStar.Text = "5";
            // 
            // lblNumberRatings
            // 
            this.lblNumberRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberRatings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblNumberRatings.Location = new System.Drawing.Point(412, 65);
            this.lblNumberRatings.Name = "lblNumberRatings";
            this.lblNumberRatings.Size = new System.Drawing.Size(152, 34);
            this.lblNumberRatings.TabIndex = 1;
            this.lblNumberRatings.Text = "5 ratings";
            // 
            // FReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 780);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.containerTop);
            this.Controls.Add(this.flpRating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FReview";
            this.Text = "FReview";
            this.Load += new System.EventHandler(this.FReview_Load);
            this.containerTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarSeller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRating;
        private Guna.UI2.WinForms.Guna2ContainerControl containerTop;
        private Guna.UI2.WinForms.Guna2Button btnPost;
        private Guna.UI2.WinForms.Guna2Button btnCart;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnPostProduct;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNameSeller;
        private Bunifu.UI.WinForms.BunifuPictureBox pbAvatarSeller;
        private Guna.UI2.WinForms.Guna2RatingStar rsStar;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblNumberRatings;
    }
}