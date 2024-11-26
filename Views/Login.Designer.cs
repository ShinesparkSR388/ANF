namespace ANF.Views
{
	partial class Login
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
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			txtCode = new TextBox();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(label1, 0, 1);
			tableLayoutPanel1.Controls.Add(txtCode, 0, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.48649F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.51351F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 203F));
			tableLayoutPanel1.Size = new Size(800, 450);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 22F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(3, 89);
			label1.Name = "label1";
			label1.Size = new Size(794, 45);
			label1.TabIndex = 7;
			label1.Text = "Ingreso";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtCode
			// 
			txtCode.Anchor = AnchorStyles.None;
			txtCode.Location = new Point(241, 176);
			txtCode.Name = "txtCode";
			txtCode.Size = new Size(317, 27);
			txtCode.TabIndex = 8;
			txtCode.UseSystemPasswordChar = true;
			txtCode.TextChanged += txtAccount_TextChanged;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(8, 28, 21);
			ClientSize = new Size(800, 450);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private TextBox txtCode;
	}
}