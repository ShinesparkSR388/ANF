namespace ANF.Views
{
	partial class accountsForm
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
			tableLayoutPanel4 = new TableLayoutPanel();
			tbl_Accounts = new DataGridView();
			tableLayoutPanel2 = new TableLayoutPanel();
			label1 = new Label();
			label2 = new Label();
			tableLayoutPanel3 = new TableLayoutPanel();
			label3 = new Label();
			tableLayoutPanel5 = new TableLayoutPanel();
			txtAccount = new TextBox();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tbl_Accounts).BeginInit();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel5.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.AutoSize = true;
			tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
			tableLayoutPanel1.Location = new Point(0, 5);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.575139F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.2541752F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.1706848F));
			tableLayoutPanel1.Size = new Size(900, 539);
			tableLayoutPanel1.TabIndex = 9;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Controls.Add(tbl_Accounts, 0, 0);
			tableLayoutPanel4.Dock = DockStyle.Top;
			tableLayoutPanel4.Location = new Point(3, 153);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 1;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 82.20551F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 17.794487F));
			tableLayoutPanel4.Size = new Size(894, 365);
			tableLayoutPanel4.TabIndex = 0;
			// 
			// tbl_Accounts
			// 
			tbl_Accounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbl_Accounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tbl_Accounts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			tbl_Accounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tbl_Accounts.Location = new Point(3, 3);
			tbl_Accounts.Name = "tbl_Accounts";
			tbl_Accounts.RowHeadersWidth = 51;
			tbl_Accounts.Size = new Size(888, 359);
			tbl_Accounts.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.2313156F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.7686844F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 331F));
			tableLayoutPanel2.Controls.Add(label1, 0, 0);
			tableLayoutPanel2.Controls.Add(label2, 0, 0);
			tableLayoutPanel2.Location = new Point(3, 5);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(894, 46);
			tableLayoutPanel2.TabIndex = 8;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 22F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(27, 67, 50);
			label1.Location = new Point(201, 0);
			label1.Name = "label1";
			label1.Size = new Size(358, 45);
			label1.TabIndex = 10;
			label1.Text = "Catalogo de cuentas";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 22F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(31, 38, 67);
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(192, 45);
			label2.TabIndex = 9;
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7919464F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.20805F));
			tableLayoutPanel3.Controls.Add(label3, 0, 0);
			tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
			tableLayoutPanel3.Dock = DockStyle.Top;
			tableLayoutPanel3.Location = new Point(3, 60);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(894, 47);
			tableLayoutPanel3.TabIndex = 9;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(27, 67, 50);
			label3.Location = new Point(3, 11);
			label3.Name = "label3";
			label3.Size = new Size(162, 24);
			label3.TabIndex = 11;
			label3.Text = "Buscar por...:";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel5.ColumnCount = 2;
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.4444427F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.5555573F));
			tableLayoutPanel5.Controls.Add(txtAccount, 0, 0);
			tableLayoutPanel5.Location = new Point(171, 3);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 1;
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel5.Size = new Size(720, 41);
			tableLayoutPanel5.TabIndex = 12;
			// 
			// txtAccount
			// 
			txtAccount.Dock = DockStyle.Fill;
			txtAccount.Location = new Point(3, 3);
			txtAccount.Name = "txtAccount";
			txtAccount.Size = new Size(386, 27);
			txtAccount.TabIndex = 2;
			txtAccount.TextChanged += txtAccount_TextChanged;
			txtAccount.KeyUp += txtAccount_KeyUp;
			// 
			// accountsForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(900, 550);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "accountsForm";
			Text = "accountsForm";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)tbl_Accounts).EndInit();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			tableLayoutPanel5.ResumeLayout(false);
			tableLayoutPanel5.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel4;
		private DataGridView tbl_Accounts;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label1;
		private Label label2;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label3;
		private TableLayoutPanel tableLayoutPanel5;
		private TextBox txtAccount;
	}
}