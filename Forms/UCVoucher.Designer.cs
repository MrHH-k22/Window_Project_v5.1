namespace Window_Project_v5._1.Forms
{
    partial class UCVoucher
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCollect = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblEndDay = new System.Windows.Forms.Label();
            this.lblBeginDay = new System.Windows.Forms.Label();
            this.lblVoucherName = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.panelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panelBorder);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(6);
            this.guna2Panel1.Size = new System.Drawing.Size(472, 198);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panelBorder
            // 
            this.panelBorder.BorderColor = System.Drawing.Color.Gray;
            this.panelBorder.BorderRadius = 8;
            this.panelBorder.BorderThickness = 1;
            this.panelBorder.Controls.Add(this.btnCollect);
            this.panelBorder.Controls.Add(this.label1);
            this.panelBorder.Controls.Add(this.lblValue);
            this.panelBorder.Controls.Add(this.lblEndDay);
            this.panelBorder.Controls.Add(this.lblBeginDay);
            this.panelBorder.Controls.Add(this.lblVoucherName);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(6, 6);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(460, 186);
            this.panelBorder.TabIndex = 0;
            // 
            // btnCollect
            // 
            this.btnCollect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCollect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCollect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCollect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCollect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnCollect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCollect.ForeColor = System.Drawing.Color.White;
            this.btnCollect.Image = global::Window_Project_v5._1.Properties.Resources.plus_white;
            this.btnCollect.Location = new System.Drawing.Point(378, 121);
            this.btnCollect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCollect.Size = new System.Drawing.Size(40, 39);
            this.btnCollect.TabIndex = 121;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(161, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 33);
            this.label1.TabIndex = 120;
            this.label1.Text = "- ";
            // 
            // lblValue
            // 
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.Red;
            this.lblValue.Location = new System.Drawing.Point(23, 125);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(327, 33);
            this.lblValue.TabIndex = 118;
            this.lblValue.Text = "- 100,000 VND";
            // 
            // lblEndDay
            // 
            this.lblEndDay.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDay.ForeColor = System.Drawing.Color.DimGray;
            this.lblEndDay.Location = new System.Drawing.Point(185, 64);
            this.lblEndDay.Name = "lblEndDay";
            this.lblEndDay.Size = new System.Drawing.Size(135, 33);
            this.lblEndDay.TabIndex = 117;
            this.lblEndDay.Text = "19/1/2004";
            this.lblEndDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBeginDay
            // 
            this.lblBeginDay.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeginDay.ForeColor = System.Drawing.Color.DimGray;
            this.lblBeginDay.Location = new System.Drawing.Point(22, 64);
            this.lblBeginDay.Name = "lblBeginDay";
            this.lblBeginDay.Size = new System.Drawing.Size(137, 33);
            this.lblBeginDay.TabIndex = 116;
            this.lblBeginDay.Text = "19/1/2004";
            // 
            // lblVoucherName
            // 
            this.lblVoucherName.AutoSize = true;
            this.lblVoucherName.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucherName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblVoucherName.Location = new System.Drawing.Point(22, 14);
            this.lblVoucherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoucherName.Name = "lblVoucherName";
            this.lblVoucherName.Size = new System.Drawing.Size(167, 31);
            this.lblVoucherName.TabIndex = 115;
            this.lblVoucherName.Text = "Voucher name";
            // 
            // UCVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCVoucher";
            this.Size = new System.Drawing.Size(472, 198);
            this.guna2Panel1.ResumeLayout(false);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelBorder;
        public System.Windows.Forms.Label lblVoucherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblEndDay;
        private System.Windows.Forms.Label lblBeginDay;
        private Guna.UI2.WinForms.Guna2CircleButton btnCollect;
    }
}
