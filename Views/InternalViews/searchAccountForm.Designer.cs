﻿namespace ANF.Views.InternalViews
{
	partial class searchAccountForm
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
			tableLayoutPanel2 = new TableLayoutPanel();
			button2 = new Button();
			button1 = new Button();
			tbl_accounts = new DataGridView();
			txtSearch = new TextBox();
			label1 = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tbl_accounts).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.5F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.5F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143F));
			tableLayoutPanel2.Controls.Add(button2, 1, 0);
			tableLayoutPanel2.Controls.Add(button1, 2, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 305);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(544, 42);
			tableLayoutPanel2.TabIndex = 14;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button2.BackColor = Color.DimGray;
			button2.FlatStyle = FlatStyle.Flat;
			button2.ForeColor = SystemColors.Control;
			button2.Location = new Point(257, 3);
			button2.Name = "button2";
			button2.Size = new Size(140, 35);
			button2.TabIndex = 2;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button1.BackColor = Color.FromArgb(31, 38, 67);
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = SystemColors.Control;
			button1.Location = new Point(403, 3);
			button1.Name = "button1";
			button1.Size = new Size(138, 35);
			button1.TabIndex = 3;
			button1.Text = "Aceptar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// tbl_accounts
			// 
			tbl_accounts.AllowUserToAddRows = false;
			tbl_accounts.AllowUserToDeleteRows = false;
			tbl_accounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbl_accounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tbl_accounts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			tbl_accounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tbl_accounts.Location = new Point(3, 87);
			tbl_accounts.Name = "tbl_accounts";
			tbl_accounts.ReadOnly = true;
			tbl_accounts.RowHeadersWidth = 51;
			tbl_accounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			tbl_accounts.Size = new Size(544, 212);
			tbl_accounts.TabIndex = 13;
			// 
			// txtSearch
			// 
			txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtSearch.Location = new Point(3, 50);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(544, 27);
			txtSearch.TabIndex = 12;
			txtSearch.Tag = "";
			txtSearch.TextChanged += txtSearch_TextChanged;
			txtSearch.KeyUp += txtSearch_KeyUp;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(31, 38, 67);
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Calibri", 14F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(544, 43);
			label1.TabIndex = 11;
			label1.Text = "Buscar cuenta";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(txtSearch, 0, 1);
			tableLayoutPanel1.Controls.Add(tbl_accounts, 0, 2);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.1904755F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.8095245F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 218F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
			tableLayoutPanel1.Size = new Size(550, 350);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// searchAccountForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(550, 350);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "searchAccountForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "searchAccountForm";
			tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)tbl_accounts).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel2;
		private Button button2;
		private Button button1;
		private DataGridView tbl_accounts;
		private TextBox txtSearch;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
	}
}