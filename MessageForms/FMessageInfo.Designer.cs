namespace Window_Project_v5._1.MessageForms
{
    partial class FMessageInfo
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ucMessageBox1 = new Window_Project_v5._1.MessageForms.UCMessageBox();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ucMessageBox1
            // 
            this.ucMessageBox1.Location = new System.Drawing.Point(0, 0);
            this.ucMessageBox1.Margin = new System.Windows.Forms.Padding(0);
            this.ucMessageBox1.Name = "ucMessageBox1";
            this.ucMessageBox1.Size = new System.Drawing.Size(450, 300);
            this.ucMessageBox1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBorderColorChanges = true;
            this.btnClose.AllowMouseEffects = true;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 1;
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnClose.BorderThickness = 1;
            this.btnClose.ColorContrastOnClick = 30;
            this.btnClose.ColorContrastOnHover = 30;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Image = global::Window_Project_v5._1.Properties.Resources.close;
            this.btnClose.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnClose.Location = new System.Drawing.Point(403, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.RoundBorders = false;
            this.btnClose.ShowBorders = true;
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnClose.TabIndex = 14;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FMessageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucMessageBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMessageInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMessageInfo";
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public UCMessageBox ucMessageBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnClose;
    }
}