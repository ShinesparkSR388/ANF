namespace ANF
{
	partial class mdiForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiForm));
			panel1 = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			pictureBox1 = new PictureBox();
			panel8 = new Panel();
			button4 = new Button();
			button2 = new Button();
			button1 = new Button();
			panel7 = new Panel();
			menu1 = new Button();
			panel4 = new Panel();
			btnClose = new Button();
			MDI = new Panel();
			tableLayoutPanel3 = new TableLayoutPanel();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel4.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			panel1.BackColor = Color.FromArgb(45, 106, 79);
			panel1.Controls.Add(tableLayoutPanel3);
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Controls.Add(panel8);
			panel1.Controls.Add(panel7);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(271, 750);
			panel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Location = new Point(0, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
			tableLayoutPanel1.Size = new Size(268, 180);
			tableLayoutPanel1.TabIndex = 13;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.727272F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5454559F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.727272F));
			tableLayoutPanel2.Controls.Add(pictureBox1, 1, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(262, 165);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(62, 3);
			pictureBox1.MaximumSize = new Size(140, 150);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(136, 150);
			pictureBox1.TabIndex = 12;
			pictureBox1.TabStop = false;
			// 
			// panel8
			// 
			panel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel8.BackColor = Color.FromArgb(82, 183, 126);
			panel8.Location = new Point(-10, 618);
			panel8.Name = "panel8";
			panel8.Size = new Size(279, 3);
			panel8.TabIndex = 3;
			// 
			// button4
			// 
			button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			button4.BackgroundImageLayout = ImageLayout.None;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			button4.ForeColor = Color.White;
			button4.Image = (Image)resources.GetObject("button4.Image");
			button4.ImageAlign = ContentAlignment.MiddleRight;
			button4.Location = new Point(3, 258);
			button4.Name = "button4";
			button4.Size = new Size(259, 47);
			button4.TabIndex = 10;
			button4.Text = "Catalogo de cuentas";
			button4.TextAlign = ContentAlignment.MiddleLeft;
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			button2.BackgroundImageLayout = ImageLayout.None;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.White;
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.ImageAlign = ContentAlignment.MiddleRight;
			button2.Location = new Point(3, 173);
			button2.Name = "button2";
			button2.Size = new Size(259, 47);
			button2.TabIndex = 8;
			button2.Text = "Estados financieros";
			button2.TextAlign = ContentAlignment.MiddleLeft;
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			button1.BackgroundImageLayout = ImageLayout.None;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Image = (Image)resources.GetObject("button1.Image");
			button1.ImageAlign = ContentAlignment.MiddleRight;
			button1.Location = new Point(3, 88);
			button1.Name = "button1";
			button1.Size = new Size(259, 66);
			button1.TabIndex = 7;
			button1.Text = "Ingreso de partidas";
			button1.TextAlign = ContentAlignment.MiddleLeft;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panel7
			// 
			panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panel7.BackColor = Color.FromArgb(82, 183, 126);
			panel7.Location = new Point(-8, 183);
			panel7.Name = "panel7";
			panel7.Size = new Size(279, 3);
			panel7.TabIndex = 2;
			panel7.Paint += panel7_Paint;
			// 
			// menu1
			// 
			menu1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			menu1.BackgroundImageLayout = ImageLayout.None;
			menu1.FlatAppearance.BorderSize = 0;
			menu1.FlatStyle = FlatStyle.Flat;
			menu1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			menu1.ForeColor = Color.White;
			menu1.Image = (Image)resources.GetObject("menu1.Image");
			menu1.ImageAlign = ContentAlignment.MiddleRight;
			menu1.Location = new Point(3, 3);
			menu1.Name = "menu1";
			menu1.Size = new Size(259, 65);
			menu1.TabIndex = 5;
			menu1.Text = "Libro diario";
			menu1.TextAlign = ContentAlignment.MiddleLeft;
			menu1.UseVisualStyleBackColor = true;
			menu1.Click += menu1_Click;
			// 
			// panel4
			// 
			panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panel4.BackColor = Color.FromArgb(8, 28, 21);
			panel4.Controls.Add(btnClose);
			panel4.Location = new Point(4, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(1296, 47);
			panel4.TabIndex = 3;
			// 
			// btnClose
			// 
			btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			btnClose.FlatStyle = FlatStyle.Popup;
			btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnClose.ForeColor = Color.White;
			btnClose.Location = new Point(1232, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(58, 43);
			btnClose.TabIndex = 4;
			btnClose.Text = "X";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.MouseClick += btnClose_MouseClick;
			btnClose.MouseLeave += btnClose_MouseLeave;
			btnClose.MouseHover += button1_MouseHover;
			// 
			// MDI
			// 
			MDI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			MDI.BackColor = Color.FromArgb(216, 246, 220);
			MDI.Location = new Point(270, 43);
			MDI.Name = "MDI";
			MDI.Size = new Size(1029, 703);
			MDI.TabIndex = 4;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Controls.Add(button4, 0, 3);
			tableLayoutPanel3.Controls.Add(button2, 0, 2);
			tableLayoutPanel3.Controls.Add(button1, 0, 1);
			tableLayoutPanel3.Controls.Add(menu1, 0, 0);
			tableLayoutPanel3.Location = new Point(3, 189);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 4;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel3.Size = new Size(265, 341);
			tableLayoutPanel3.TabIndex = 14;
			// 
			// mdiForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoValidate = AutoValidate.EnableAllowFocusChange;
			BackColor = Color.White;
			ClientSize = new Size(1300, 750);
			Controls.Add(MDI);
			Controls.Add(panel1);
			Controls.Add(panel4);
			FormBorderStyle = FormBorderStyle.None;
			MaximumSize = new Size(1400, 750);
			MinimumSize = new Size(1300, 750);
			Name = "mdiForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			panel1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel4.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel4;
		private Button btnClose;
		private Panel panel7;
		private Button button2;
		private Button button1;
		private Button menu1;
		private Button button4;
		private Panel panel8;
		private Panel MDI;
		private PictureBox pictureBox1;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
	}
}
