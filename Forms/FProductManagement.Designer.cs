namespace Window_Project_v5._1.Forms
{
    partial class FProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProductManagement));
            this.gpManagement = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tpManagement = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpDisplay = new System.Windows.Forms.TabPage();
            this.tpWaitConfirm = new System.Windows.Forms.TabPage();
            this.tpWaitforPayment = new System.Windows.Forms.TabPage();
            this.tpDelivered = new System.Windows.Forms.TabPage();
            this.tpCancelled = new System.Windows.Forms.TabPage();
            this.gpManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.tpManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpManagement
            // 
            this.gpManagement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.gpManagement.BorderRadius = 20;
            this.gpManagement.BorderThickness = 1;
            this.gpManagement.Controls.Add(this.label2);
            this.gpManagement.Controls.Add(this.label1);
            this.gpManagement.Controls.Add(this.bunifuPictureBox1);
            this.gpManagement.Controls.Add(this.lblName);
            this.gpManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpManagement.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gpManagement.LabelIndent = 10;
            this.gpManagement.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.gpManagement.Location = new System.Drawing.Point(11, 7);
            this.gpManagement.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.gpManagement.Name = "gpManagement";
            this.gpManagement.Size = new System.Drawing.Size(1218, 116);
            this.gpManagement.TabIndex = 1;
            this.gpManagement.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(896, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Revenue:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(1042, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "100,000 VND";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 43;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(20, 15);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(86, 86);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 11;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblName.Location = new System.Drawing.Point(131, 41);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(143, 31);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Seller Name";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.gpManagement);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1241, 129);
            this.panelTop.TabIndex = 1;
            // 
            // tpManagement
            // 
            this.tpManagement.Controls.Add(this.tpDisplay);
            this.tpManagement.Controls.Add(this.tpWaitConfirm);
            this.tpManagement.Controls.Add(this.tpWaitforPayment);
            this.tpManagement.Controls.Add(this.tpDelivered);
            this.tpManagement.Controls.Add(this.tpCancelled);
            this.tpManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpManagement.ItemSize = new System.Drawing.Size(180, 40);
            this.tpManagement.Location = new System.Drawing.Point(0, 129);
            this.tpManagement.Name = "tpManagement";
            this.tpManagement.SelectedIndex = 0;
            this.tpManagement.Size = new System.Drawing.Size(1241, 592);
            this.tpManagement.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tpManagement.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tpManagement.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tpManagement.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tpManagement.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tpManagement.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tpManagement.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tpManagement.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tpManagement.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tpManagement.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tpManagement.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tpManagement.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tpManagement.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tpManagement.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tpManagement.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tpManagement.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tpManagement.TabIndex = 2;
            this.tpManagement.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tpManagement.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpDisplay
            // 
            this.tpDisplay.Location = new System.Drawing.Point(4, 44);
            this.tpDisplay.Name = "tpDisplay";
            this.tpDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tpDisplay.Size = new System.Drawing.Size(1233, 544);
            this.tpDisplay.TabIndex = 0;
            this.tpDisplay.Text = "Displaying";
            this.tpDisplay.UseVisualStyleBackColor = true;
            // 
            // tpWaitConfirm
            // 
            this.tpWaitConfirm.Location = new System.Drawing.Point(4, 44);
            this.tpWaitConfirm.Name = "tpWaitConfirm";
            this.tpWaitConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tpWaitConfirm.Size = new System.Drawing.Size(1233, 544);
            this.tpWaitConfirm.TabIndex = 1;
            this.tpWaitConfirm.Text = "Not Confirm";
            this.tpWaitConfirm.UseVisualStyleBackColor = true;
            // 
            // tpWaitforPayment
            // 
            this.tpWaitforPayment.Location = new System.Drawing.Point(4, 44);
            this.tpWaitforPayment.Name = "tpWaitforPayment";
            this.tpWaitforPayment.Size = new System.Drawing.Size(1233, 544);
            this.tpWaitforPayment.TabIndex = 2;
            this.tpWaitforPayment.Text = "Wair for payment";
            this.tpWaitforPayment.UseVisualStyleBackColor = true;
            // 
            // tpDelivered
            // 
            this.tpDelivered.Location = new System.Drawing.Point(4, 44);
            this.tpDelivered.Name = "tpDelivered";
            this.tpDelivered.Size = new System.Drawing.Size(1233, 544);
            this.tpDelivered.TabIndex = 3;
            this.tpDelivered.Text = "Delivered";
            this.tpDelivered.UseVisualStyleBackColor = true;
            // 
            // tpCancelled
            // 
            this.tpCancelled.Location = new System.Drawing.Point(4, 44);
            this.tpCancelled.Name = "tpCancelled";
            this.tpCancelled.Size = new System.Drawing.Size(1233, 544);
            this.tpCancelled.TabIndex = 4;
            this.tpCancelled.Text = "Cancelled";
            this.tpCancelled.UseVisualStyleBackColor = true;
            // 
            // FProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1241, 721);
            this.Controls.Add(this.tpManagement);
            this.Controls.Add(this.panelTop);
            this.Name = "FProductManagement";
            this.Text = "FProductManagement";
            this.Load += new System.EventHandler(this.FProductManagement_Load);
            this.gpManagement.ResumeLayout(false);
            this.gpManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.tpManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuGroupBox gpManagement;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TabControl tpManagement;
        private System.Windows.Forms.TabPage tpDisplay;
        private System.Windows.Forms.TabPage tpWaitConfirm;
        private System.Windows.Forms.TabPage tpWaitforPayment;
        private System.Windows.Forms.TabPage tpDelivered;
        private System.Windows.Forms.TabPage tpCancelled;
    }
}