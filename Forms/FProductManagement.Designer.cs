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
            this.tpManagement = new System.Windows.Forms.TabControl();
            this.tpAll = new System.Windows.Forms.TabPage();
            this.tpWaitConfirm = new System.Windows.Forms.TabPage();
            this.tpConfirmed = new System.Windows.Forms.TabPage();
            this.tpPack = new System.Windows.Forms.TabPage();
            this.tpTransport = new System.Windows.Forms.TabPage();
            this.tpCompleted = new System.Windows.Forms.TabPage();
            this.tpCancelled = new System.Windows.Forms.TabPage();
            this.gpManagement = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tpManagement.SuspendLayout();
            this.gpManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpManagement
            // 
            this.tpManagement.Controls.Add(this.tpAll);
            this.tpManagement.Controls.Add(this.tpWaitConfirm);
            this.tpManagement.Controls.Add(this.tpConfirmed);
            this.tpManagement.Controls.Add(this.tpPack);
            this.tpManagement.Controls.Add(this.tpTransport);
            this.tpManagement.Controls.Add(this.tpCompleted);
            this.tpManagement.Controls.Add(this.tpCancelled);
            this.tpManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpManagement.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tpManagement.Location = new System.Drawing.Point(0, 129);
            this.tpManagement.Name = "tpManagement";
            this.tpManagement.SelectedIndex = 0;
            this.tpManagement.Size = new System.Drawing.Size(945, 431);
            this.tpManagement.TabIndex = 0;
            // 
            // tpAll
            // 
            this.tpAll.AutoScroll = true;
            this.tpAll.Location = new System.Drawing.Point(4, 34);
            this.tpAll.Name = "tpAll";
            this.tpAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpAll.Size = new System.Drawing.Size(934, 393);
            this.tpAll.TabIndex = 0;
            this.tpAll.Text = "All";
            this.tpAll.UseVisualStyleBackColor = true;
            // 
            // tpWaitConfirm
            // 
            this.tpWaitConfirm.AutoScroll = true;
            this.tpWaitConfirm.Location = new System.Drawing.Point(4, 34);
            this.tpWaitConfirm.Name = "tpWaitConfirm";
            this.tpWaitConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tpWaitConfirm.Size = new System.Drawing.Size(937, 393);
            this.tpWaitConfirm.TabIndex = 1;
            this.tpWaitConfirm.Text = "Wait for confirmation";
            this.tpWaitConfirm.UseVisualStyleBackColor = true;
            // 
            // tpConfirmed
            // 
            this.tpConfirmed.AutoScroll = true;
            this.tpConfirmed.Location = new System.Drawing.Point(4, 40);
            this.tpConfirmed.Name = "tpConfirmed";
            this.tpConfirmed.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfirmed.Size = new System.Drawing.Size(934, 387);
            this.tpConfirmed.TabIndex = 2;
            this.tpConfirmed.Text = "Confirmed";
            this.tpConfirmed.UseVisualStyleBackColor = true;
            // 
            // tpPack
            // 
            this.tpPack.AutoScroll = true;
            this.tpPack.Location = new System.Drawing.Point(4, 40);
            this.tpPack.Name = "tpPack";
            this.tpPack.Padding = new System.Windows.Forms.Padding(3);
            this.tpPack.Size = new System.Drawing.Size(934, 387);
            this.tpPack.TabIndex = 3;
            this.tpPack.Text = "Pack";
            this.tpPack.UseVisualStyleBackColor = true;
            // 
            // tpTransport
            // 
            this.tpTransport.AutoScroll = true;
            this.tpTransport.Location = new System.Drawing.Point(4, 25);
            this.tpTransport.Name = "tpTransport";
            this.tpTransport.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransport.Size = new System.Drawing.Size(934, 402);
            this.tpTransport.TabIndex = 4;
            this.tpTransport.Text = "Transport";
            this.tpTransport.UseVisualStyleBackColor = true;
            // 
            // tpCompleted
            // 
            this.tpCompleted.AutoScroll = true;
            this.tpCompleted.Location = new System.Drawing.Point(4, 25);
            this.tpCompleted.Name = "tpCompleted";
            this.tpCompleted.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompleted.Size = new System.Drawing.Size(934, 402);
            this.tpCompleted.TabIndex = 5;
            this.tpCompleted.Text = "Completed";
            this.tpCompleted.UseVisualStyleBackColor = true;
            // 
            // tpCancelled
            // 
            this.tpCancelled.AutoScroll = true;
            this.tpCancelled.Location = new System.Drawing.Point(4, 25);
            this.tpCancelled.Name = "tpCancelled";
            this.tpCancelled.Padding = new System.Windows.Forms.Padding(3);
            this.tpCancelled.Size = new System.Drawing.Size(934, 402);
            this.tpCancelled.TabIndex = 6;
            this.tpCancelled.Text = "Cancelled";
            this.tpCancelled.UseVisualStyleBackColor = true;
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
            this.gpManagement.Size = new System.Drawing.Size(921, 116);
            this.gpManagement.TabIndex = 1;
            this.gpManagement.TabStop = false;
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
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 43;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(27, 14);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(86, 86);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 11;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(747, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "100,000 VND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(601, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Revenue:";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.gpManagement);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(945, 129);
            this.panelTop.TabIndex = 1;
            // 
            // FProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(945, 566);
            this.Controls.Add(this.tpManagement);
            this.Controls.Add(this.panelTop);
            this.Name = "FProductManagement";
            this.Text = "FProductManagement";
            this.tpManagement.ResumeLayout(false);
            this.gpManagement.ResumeLayout(false);
            this.gpManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpManagement;
        private System.Windows.Forms.TabPage tpAll;
        private System.Windows.Forms.TabPage tpWaitConfirm;
        private System.Windows.Forms.TabPage tpConfirmed;
        private System.Windows.Forms.TabPage tpPack;
        private System.Windows.Forms.TabPage tpTransport;
        private System.Windows.Forms.TabPage tpCompleted;
        private System.Windows.Forms.TabPage tpCancelled;
        private Bunifu.UI.WinForms.BunifuGroupBox gpManagement;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
    }
}