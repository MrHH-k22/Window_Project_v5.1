namespace Window_Project_v5._1.Forms
{
    partial class UCReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReview));
            this.gbContent = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.rsStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.panelRating = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblNameSeller = new System.Windows.Forms.Label();
            this.pbAvtSeller = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ucProductConditionReduce = new Window_Project_v5._1.Forms.UCProductCondition();
            this.gbContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvtSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContent
            // 
            this.gbContent.AutoSize = true;
            this.gbContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.gbContent.BorderRadius = 0;
            this.gbContent.BorderThickness = 3;
            this.gbContent.Controls.Add(this.ucProductConditionReduce);
            this.gbContent.Controls.Add(this.rsStar);
            this.gbContent.Controls.Add(this.panelRating);
            this.gbContent.Controls.Add(this.lblStar);
            this.gbContent.Controls.Add(this.lblNameSeller);
            this.gbContent.Controls.Add(this.pbAvtSeller);
            this.gbContent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContent.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbContent.LabelIndent = 10;
            this.gbContent.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.gbContent.Location = new System.Drawing.Point(0, 3);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(941, 270);
            this.gbContent.TabIndex = 3;
            this.gbContent.TabStop = false;
            this.gbContent.Enter += new System.EventHandler(this.gbContent_Enter);
            // 
            // rsStar
            // 
            this.rsStar.FillColor = System.Drawing.Color.Transparent;
            this.rsStar.Location = new System.Drawing.Point(164, 103);
            this.rsStar.Name = "rsStar";
            this.rsStar.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.rsStar.Size = new System.Drawing.Size(193, 38);
            this.rsStar.TabIndex = 6;
            // 
            // panelRating
            // 
            this.panelRating.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelRating.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRating.BackgroundImage")));
            this.panelRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRating.BorderColor = System.Drawing.Color.Transparent;
            this.panelRating.BorderRadius = 3;
            this.panelRating.BorderThickness = 1;
            this.panelRating.Location = new System.Drawing.Point(98, 49);
            this.panelRating.Name = "panelRating";
            this.panelRating.ShowBorders = true;
            this.panelRating.Size = new System.Drawing.Size(836, 45);
            this.panelRating.TabIndex = 5;
            // 
            // lblStar
            // 
            this.lblStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblStar.Location = new System.Drawing.Point(101, 113);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(77, 33);
            this.lblStar.TabIndex = 4;
            this.lblStar.Text = "5";
            // 
            // lblNameSeller
            // 
            this.lblNameSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblNameSeller.Location = new System.Drawing.Point(98, 12);
            this.lblNameSeller.Name = "lblNameSeller";
            this.lblNameSeller.Size = new System.Drawing.Size(200, 33);
            this.lblNameSeller.TabIndex = 4;
            this.lblNameSeller.Text = "Andrew NG";
            // 
            // pbAvtSeller
            // 
            this.pbAvtSeller.AllowFocused = false;
            this.pbAvtSeller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAvtSeller.AutoSizeHeight = true;
            this.pbAvtSeller.BorderRadius = 35;
            this.pbAvtSeller.Image = ((System.Drawing.Image)(resources.GetObject("pbAvtSeller.Image")));
            this.pbAvtSeller.IsCircle = true;
            this.pbAvtSeller.Location = new System.Drawing.Point(22, 10);
            this.pbAvtSeller.Name = "pbAvtSeller";
            this.pbAvtSeller.Size = new System.Drawing.Size(70, 70);
            this.pbAvtSeller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvtSeller.TabIndex = 3;
            this.pbAvtSeller.TabStop = false;
            this.pbAvtSeller.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // ucProductConditionReduce
            // 
            this.ucProductConditionReduce.BackColor = System.Drawing.Color.Gainsboro;
            this.ucProductConditionReduce.Location = new System.Drawing.Point(5, 146);
            this.ucProductConditionReduce.Margin = new System.Windows.Forms.Padding(2);
            this.ucProductConditionReduce.Name = "ucProductConditionReduce";
            this.ucProductConditionReduce.Size = new System.Drawing.Size(929, 96);
            this.ucProductConditionReduce.TabIndex = 7;
            // 
            // UCReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbContent);
            this.Name = "UCReview";
            this.Size = new System.Drawing.Size(941, 274);
            this.Load += new System.EventHandler(this.UCReview_Load);
            this.gbContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvtSeller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox gbContent;
        private Bunifu.UI.WinForms.BunifuPanel panelRating;
        private System.Windows.Forms.Label lblNameSeller;
        private Bunifu.UI.WinForms.BunifuPictureBox pbAvtSeller;
        private Guna.UI2.WinForms.Guna2RatingStar rsStar;
        private System.Windows.Forms.Label lblStar;
        private UCProductCondition ucProductConditionReduce;
    }
}
