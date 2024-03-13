namespace Window_Project_v5._1.Forms
{
    partial class UCProductCondition
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
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNextState = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblProductName.Location = new System.Drawing.Point(108, 16);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(136, 25);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Product Name";
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyerName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblBuyerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblBuyerName.Location = new System.Drawing.Point(108, 47);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(118, 25);
            this.lblBuyerName.TabIndex = 12;
            this.lblBuyerName.Text = "Buyer Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(570, 16);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(118, 25);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "100.000 VND";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.DarkGray;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(434, 47);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 25);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Completed";
            // 
            // btnNextState
            // 
            this.btnNextState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnNextState.FlatAppearance.BorderSize = 0;
            this.btnNextState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNextState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnNextState.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNextState.Location = new System.Drawing.Point(574, 43);
            this.btnNextState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextState.Name = "btnNextState";
            this.btnNextState.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnNextState.Size = new System.Drawing.Size(94, 30);
            this.btnNextState.TabIndex = 15;
            this.btnNextState.Text = "Next state";
            this.btnNextState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextState.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNextState.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Window_Project_v5._1.Properties.Resources.laptop;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // UCProductCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNextState);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblBuyerName);
            this.Controls.Add(this.lblProductName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCProductCondition";
            this.Size = new System.Drawing.Size(708, 91);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNextState;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
