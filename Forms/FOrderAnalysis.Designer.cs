namespace Window_Project_v5._1.Forms
{
    partial class FOrderAnalysis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOrderAnalysis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAmountOrder = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cpProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panelDetailProgress = new System.Windows.Forms.Panel();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.pbCompleted = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lblTransport = new System.Windows.Forms.Label();
            this.pbTransport = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lblPacking = new System.Windows.Forms.Label();
            this.pbPacking = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.pbConfirmed = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.pbWaiting = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelProgress.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.panelDetailProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblAmountOrder);
            this.panel1.Controls.Add(this.lblOrder);
            this.panel1.Location = new System.Drawing.Point(24, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 116);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Window_Project_v5._1.Properties.Resources.box;
            this.pictureBox1.Location = new System.Drawing.Point(109, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblAmountOrder
            // 
            this.lblAmountOrder.AutoSize = true;
            this.lblAmountOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAmountOrder.ForeColor = System.Drawing.Color.White;
            this.lblAmountOrder.Location = new System.Drawing.Point(19, 53);
            this.lblAmountOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountOrder.Name = "lblAmountOrder";
            this.lblAmountOrder.Size = new System.Drawing.Size(79, 37);
            this.lblAmountOrder.TabIndex = 2;
            this.lblAmountOrder.Text = "1,576";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOrder.ForeColor = System.Drawing.Color.White;
            this.lblOrder.Location = new System.Drawing.Point(11, 15);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(51, 19);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(255, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 116);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Window_Project_v5._1.Properties.Resources.cart1;
            this.pictureBox2.Location = new System.Drawing.Point(109, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "713";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customers";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(484, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 116);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Window_Project_v5._1.Properties.Resources.real_time;
            this.pictureBox3.Location = new System.Drawing.Point(109, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "1,576";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Incompleted";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(715, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 116);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Window_Project_v5._1.Properties.Resources.hand;
            this.pictureBox4.Location = new System.Drawing.Point(109, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "1,576";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Completed";
            // 
            // cpProgress
            // 
            this.cpProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpProgress.Animated = true;
            this.cpProgress.AnimationInterval = 1;
            this.cpProgress.AnimationSpeed = 1;
            this.cpProgress.BackColor = System.Drawing.Color.Transparent;
            this.cpProgress.CircleMargin = 10;
            this.cpProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.cpProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpProgress.IsPercentage = false;
            this.cpProgress.LineProgressThickness = 10;
            this.cpProgress.LineThickness = 10;
            this.cpProgress.Location = new System.Drawing.Point(81, 43);
            this.cpProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cpProgress.Name = "cpProgress";
            this.cpProgress.ProgressAnimationSpeed = 200;
            this.cpProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpProgress.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.cpProgress.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.cpProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.cpProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.cpProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.cpProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cpProgress.Size = new System.Drawing.Size(133, 133);
            this.cpProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.cpProgress.SubScriptText = "%";
            this.cpProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.cpProgress.SuperScriptText = "";
            this.cpProgress.TabIndex = 16;
            this.cpProgress.Text = "30";
            this.cpProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cpProgress.Value = 30;
            this.cpProgress.ValueByTransition = 30;
            this.cpProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.Color.White;
            this.panelProgress.Controls.Add(this.lblProgress);
            this.panelProgress.Controls.Add(this.cpProgress);
            this.panelProgress.Location = new System.Drawing.Point(772, 369);
            this.panelProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(237, 182);
            this.panelProgress.TabIndex = 17;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblProgress.Location = new System.Drawing.Point(21, 11);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(123, 37);
            this.lblProgress.TabIndex = 17;
            this.lblProgress.Text = "Progress";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.bunifuDataGridView1);
            this.panel7.Location = new System.Drawing.Point(24, 138);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(985, 224);
            this.panel7.TabIndex = 19;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(9, 10);
            this.bunifuDataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(953, 206);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // panelDetailProgress
            // 
            this.panelDetailProgress.BackColor = System.Drawing.Color.White;
            this.panelDetailProgress.Controls.Add(this.lblCompleted);
            this.panelDetailProgress.Controls.Add(this.pbCompleted);
            this.panelDetailProgress.Controls.Add(this.lblTransport);
            this.panelDetailProgress.Controls.Add(this.pbTransport);
            this.panelDetailProgress.Controls.Add(this.lblPacking);
            this.panelDetailProgress.Controls.Add(this.pbPacking);
            this.panelDetailProgress.Controls.Add(this.lblConfirmed);
            this.panelDetailProgress.Controls.Add(this.pbConfirmed);
            this.panelDetailProgress.Controls.Add(this.lblWaiting);
            this.panelDetailProgress.Controls.Add(this.pbWaiting);
            this.panelDetailProgress.Location = new System.Drawing.Point(24, 369);
            this.panelDetailProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDetailProgress.Name = "panelDetailProgress";
            this.panelDetailProgress.Size = new System.Drawing.Size(740, 182);
            this.panelDetailProgress.TabIndex = 20;
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblCompleted.Location = new System.Drawing.Point(565, 131);
            this.lblCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(83, 20);
            this.lblCompleted.TabIndex = 9;
            this.lblCompleted.Text = "Completed";
            // 
            // pbCompleted
            // 
            this.pbCompleted.AllowAnimations = false;
            this.pbCompleted.Animation = 0;
            this.pbCompleted.AnimationSpeed = 220;
            this.pbCompleted.AnimationStep = 10;
            this.pbCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbCompleted.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCompleted.BackgroundImage")));
            this.pbCompleted.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbCompleted.BorderRadius = 9;
            this.pbCompleted.BorderThickness = 1;
            this.pbCompleted.Location = new System.Drawing.Point(19, 134);
            this.pbCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCompleted.Maximum = 100;
            this.pbCompleted.MaximumValue = 100;
            this.pbCompleted.Minimum = 0;
            this.pbCompleted.MinimumValue = 0;
            this.pbCompleted.Name = "pbCompleted";
            this.pbCompleted.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.pbCompleted.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbCompleted.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pbCompleted.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pbCompleted.Size = new System.Drawing.Size(521, 16);
            this.pbCompleted.TabIndex = 8;
            this.pbCompleted.Value = 15;
            this.pbCompleted.ValueByTransition = 15;
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblTransport.Location = new System.Drawing.Point(565, 105);
            this.lblTransport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(74, 20);
            this.lblTransport.TabIndex = 7;
            this.lblTransport.Text = "Transport";
            // 
            // pbTransport
            // 
            this.pbTransport.AllowAnimations = false;
            this.pbTransport.Animation = 0;
            this.pbTransport.AnimationSpeed = 220;
            this.pbTransport.AnimationStep = 10;
            this.pbTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbTransport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTransport.BackgroundImage")));
            this.pbTransport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbTransport.BorderRadius = 9;
            this.pbTransport.BorderThickness = 1;
            this.pbTransport.Location = new System.Drawing.Point(19, 108);
            this.pbTransport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbTransport.Maximum = 100;
            this.pbTransport.MaximumValue = 100;
            this.pbTransport.Minimum = 0;
            this.pbTransport.MinimumValue = 0;
            this.pbTransport.Name = "pbTransport";
            this.pbTransport.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.pbTransport.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbTransport.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pbTransport.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pbTransport.Size = new System.Drawing.Size(521, 16);
            this.pbTransport.TabIndex = 6;
            this.pbTransport.Value = 82;
            this.pbTransport.ValueByTransition = 82;
            // 
            // lblPacking
            // 
            this.lblPacking.AutoSize = true;
            this.lblPacking.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPacking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblPacking.Location = new System.Drawing.Point(565, 79);
            this.lblPacking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPacking.Name = "lblPacking";
            this.lblPacking.Size = new System.Drawing.Size(63, 20);
            this.lblPacking.TabIndex = 5;
            this.lblPacking.Text = "Packing";
            // 
            // pbPacking
            // 
            this.pbPacking.AllowAnimations = false;
            this.pbPacking.Animation = 0;
            this.pbPacking.AnimationSpeed = 220;
            this.pbPacking.AnimationStep = 10;
            this.pbPacking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbPacking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPacking.BackgroundImage")));
            this.pbPacking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbPacking.BorderRadius = 9;
            this.pbPacking.BorderThickness = 1;
            this.pbPacking.Location = new System.Drawing.Point(19, 82);
            this.pbPacking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPacking.Maximum = 100;
            this.pbPacking.MaximumValue = 100;
            this.pbPacking.Minimum = 0;
            this.pbPacking.MinimumValue = 0;
            this.pbPacking.Name = "pbPacking";
            this.pbPacking.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.pbPacking.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbPacking.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pbPacking.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pbPacking.Size = new System.Drawing.Size(521, 16);
            this.pbPacking.TabIndex = 4;
            this.pbPacking.Value = 67;
            this.pbPacking.ValueByTransition = 67;
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.AutoSize = true;
            this.lblConfirmed.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblConfirmed.Location = new System.Drawing.Point(565, 53);
            this.lblConfirmed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(81, 20);
            this.lblConfirmed.TabIndex = 3;
            this.lblConfirmed.Text = "Confirmed";
            // 
            // pbConfirmed
            // 
            this.pbConfirmed.AllowAnimations = false;
            this.pbConfirmed.Animation = 0;
            this.pbConfirmed.AnimationSpeed = 220;
            this.pbConfirmed.AnimationStep = 10;
            this.pbConfirmed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbConfirmed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConfirmed.BackgroundImage")));
            this.pbConfirmed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbConfirmed.BorderRadius = 9;
            this.pbConfirmed.BorderThickness = 1;
            this.pbConfirmed.Location = new System.Drawing.Point(19, 57);
            this.pbConfirmed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbConfirmed.Maximum = 100;
            this.pbConfirmed.MaximumValue = 100;
            this.pbConfirmed.Minimum = 0;
            this.pbConfirmed.MinimumValue = 0;
            this.pbConfirmed.Name = "pbConfirmed";
            this.pbConfirmed.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.pbConfirmed.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbConfirmed.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pbConfirmed.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pbConfirmed.Size = new System.Drawing.Size(521, 16);
            this.pbConfirmed.TabIndex = 2;
            this.pbConfirmed.Value = 26;
            this.pbConfirmed.ValueByTransition = 26;
            // 
            // lblWaiting
            // 
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblWaiting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.lblWaiting.Location = new System.Drawing.Point(565, 26);
            this.lblWaiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(155, 20);
            this.lblWaiting.TabIndex = 1;
            this.lblWaiting.Text = "Wait for confirmation";
            // 
            // pbWaiting
            // 
            this.pbWaiting.AllowAnimations = false;
            this.pbWaiting.Animation = 0;
            this.pbWaiting.AnimationSpeed = 220;
            this.pbWaiting.AnimationStep = 10;
            this.pbWaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbWaiting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWaiting.BackgroundImage")));
            this.pbWaiting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbWaiting.BorderRadius = 9;
            this.pbWaiting.BorderThickness = 1;
            this.pbWaiting.Location = new System.Drawing.Point(19, 30);
            this.pbWaiting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbWaiting.Maximum = 100;
            this.pbWaiting.MaximumValue = 100;
            this.pbWaiting.Minimum = 0;
            this.pbWaiting.MinimumValue = 0;
            this.pbWaiting.Name = "pbWaiting";
            this.pbWaiting.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.pbWaiting.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.pbWaiting.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.pbWaiting.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.pbWaiting.Size = new System.Drawing.Size(521, 16);
            this.pbWaiting.TabIndex = 0;
            this.pbWaiting.Value = 50;
            this.pbWaiting.ValueByTransition = 50;
            // 
            // FOrderAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 566);
            this.Controls.Add(this.panelDetailProgress);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FOrderAnalysis";
            this.Text = "FOrderAnalysis";
            this.Load += new System.EventHandler(this.FOrderAnalysis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.panelDetailProgress.ResumeLayout(false);
            this.panelDetailProgress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAmountOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuCircleProgress cpProgress;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.Panel panelDetailProgress;
        private Bunifu.UI.WinForms.BunifuProgressBar pbWaiting;
        private System.Windows.Forms.Label lblConfirmed;
        private Bunifu.UI.WinForms.BunifuProgressBar pbConfirmed;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.Label lblCompleted;
        private Bunifu.UI.WinForms.BunifuProgressBar pbCompleted;
        private System.Windows.Forms.Label lblTransport;
        private Bunifu.UI.WinForms.BunifuProgressBar pbTransport;
        private System.Windows.Forms.Label lblPacking;
        private Bunifu.UI.WinForms.BunifuProgressBar pbPacking;
    }
}