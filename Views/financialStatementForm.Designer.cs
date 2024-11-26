namespace ANF.Views
{
	partial class financialStatementForm
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
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tableLayoutPanel6 = new TableLayoutPanel();
			txtBalance = new Label();
			tableLayoutPanel7 = new TableLayoutPanel();
			tbl_activo = new DataGridView();
			tableLayoutPanel8 = new TableLayoutPanel();
			tbl_capital = new DataGridView();
			tbl_pasivo = new DataGridView();
			tableLayoutPanel11 = new TableLayoutPanel();
			button1 = new Button();
			tabPage2 = new TabPage();
			tableLayoutPanel9 = new TableLayoutPanel();
			label5 = new Label();
			tableLayoutPanel10 = new TableLayoutPanel();
			tbl_result = new DataGridView();
			tableLayoutPanel2 = new TableLayoutPanel();
			label1 = new Label();
			label2 = new Label();
			tableLayoutPanel3 = new TableLayoutPanel();
			label3 = new Label();
			tableLayoutPanel5 = new TableLayoutPanel();
			label6 = new Label();
			date_desde = new DateTimePicker();
			date_hasta = new DateTimePicker();
			button2 = new Button();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tableLayoutPanel6.SuspendLayout();
			tableLayoutPanel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tbl_activo).BeginInit();
			tableLayoutPanel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tbl_capital).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbl_pasivo).BeginInit();
			tableLayoutPanel11.SuspendLayout();
			tabPage2.SuspendLayout();
			tableLayoutPanel9.SuspendLayout();
			tableLayoutPanel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tbl_result).BeginInit();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel5.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.AutoSize = true;
			tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.575139F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2040815F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.22078F));
			tableLayoutPanel1.Size = new Size(900, 576);
			tableLayoutPanel1.TabIndex = 10;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Controls.Add(tabControl1, 0, 0);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(3, 121);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 1;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 82.20551F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 17.794487F));
			tableLayoutPanel4.Size = new Size(894, 452);
			tableLayoutPanel4.TabIndex = 0;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(3, 3);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(888, 446);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(tableLayoutPanel6);
			tabPage1.Location = new Point(4, 29);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(880, 413);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Balance General";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel6
			// 
			tableLayoutPanel6.ColumnCount = 1;
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel6.Controls.Add(txtBalance, 0, 2);
			tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 1);
			tableLayoutPanel6.Controls.Add(tableLayoutPanel11, 0, 0);
			tableLayoutPanel6.Dock = DockStyle.Fill;
			tableLayoutPanel6.Location = new Point(3, 3);
			tableLayoutPanel6.Name = "tableLayoutPanel6";
			tableLayoutPanel6.RowCount = 3;
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2850122F));
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 77.64128F));
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel6.Size = new Size(874, 407);
			tableLayoutPanel6.TabIndex = 0;
			// 
			// txtBalance
			// 
			txtBalance.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtBalance.AutoSize = true;
			txtBalance.Font = new Font("Calibri", 12F, FontStyle.Bold);
			txtBalance.ForeColor = Color.FromArgb(27, 67, 50);
			txtBalance.Location = new Point(3, 374);
			txtBalance.Name = "txtBalance";
			txtBalance.Size = new Size(868, 24);
			txtBalance.TabIndex = 12;
			txtBalance.Text = "(ACTIVO)$--- = (PASIVO)$--- + (CAPITAL)$---";
			txtBalance.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel7
			// 
			tableLayoutPanel7.ColumnCount = 2;
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 434F));
			tableLayoutPanel7.Controls.Add(tbl_activo, 0, 0);
			tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 1, 0);
			tableLayoutPanel7.Dock = DockStyle.Fill;
			tableLayoutPanel7.Location = new Point(3, 53);
			tableLayoutPanel7.Name = "tableLayoutPanel7";
			tableLayoutPanel7.RowCount = 1;
			tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel7.Size = new Size(868, 310);
			tableLayoutPanel7.TabIndex = 0;
			// 
			// tbl_activo
			// 
			tbl_activo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tbl_activo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			tbl_activo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tbl_activo.Dock = DockStyle.Fill;
			tbl_activo.Location = new Point(3, 3);
			tbl_activo.Name = "tbl_activo";
			tbl_activo.RowHeadersWidth = 51;
			tbl_activo.Size = new Size(428, 304);
			tbl_activo.TabIndex = 1;
			// 
			// tableLayoutPanel8
			// 
			tableLayoutPanel8.ColumnCount = 1;
			tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel8.Controls.Add(tbl_capital, 0, 1);
			tableLayoutPanel8.Controls.Add(tbl_pasivo, 0, 0);
			tableLayoutPanel8.Dock = DockStyle.Fill;
			tableLayoutPanel8.Location = new Point(437, 3);
			tableLayoutPanel8.Name = "tableLayoutPanel8";
			tableLayoutPanel8.RowCount = 2;
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel8.Size = new Size(428, 304);
			tableLayoutPanel8.TabIndex = 0;
			// 
			// tbl_capital
			// 
			tbl_capital.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tbl_capital.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			tbl_capital.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tbl_capital.Dock = DockStyle.Fill;
			tbl_capital.Location = new Point(3, 155);
			tbl_capital.Name = "tbl_capital";
			tbl_capital.RowHeadersWidth = 51;
			tbl_capital.Size = new Size(422, 146);
			tbl_capital.TabIndex = 2;
			// 
			// tbl_pasivo
			// 
			tbl_pasivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tbl_pasivo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			tbl_pasivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tbl_pasivo.Dock = DockStyle.Fill;
			tbl_pasivo.Location = new Point(3, 3);
			tbl_pasivo.Name = "tbl_pasivo";
			tbl_pasivo.RowHeadersWidth = 51;
			tbl_pasivo.Size = new Size(422, 146);
			tbl_pasivo.TabIndex = 1;
			// 
			// tableLayoutPanel11
			// 
			tableLayoutPanel11.ColumnCount = 2;
			tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8847923F));
			tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.1152077F));
			tableLayoutPanel11.Controls.Add(button2, 0, 0);
			tableLayoutPanel11.Controls.Add(button1, 1, 0);
			tableLayoutPanel11.Dock = DockStyle.Fill;
			tableLayoutPanel11.Location = new Point(3, 3);
			tableLayoutPanel11.Name = "tableLayoutPanel11";
			tableLayoutPanel11.RowCount = 1;
			tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel11.Size = new Size(868, 44);
			tableLayoutPanel11.TabIndex = 13;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(27, 67, 50);
			button1.Dock = DockStyle.Fill;
			button1.Font = new Font("Segoe UI", 10F);
			button1.ForeColor = Color.White;
			button1.Location = new Point(436, 3);
			button1.Name = "button1";
			button1.Size = new Size(429, 38);
			button1.TabIndex = 14;
			button1.Text = "Generar analisis financiero";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click_1;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(tableLayoutPanel9);
			tabPage2.Location = new Point(4, 29);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(880, 413);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Estado de Resultados";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel9
			// 
			tableLayoutPanel9.ColumnCount = 1;
			tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel9.Controls.Add(label5, 0, 1);
			tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 0);
			tableLayoutPanel9.Dock = DockStyle.Fill;
			tableLayoutPanel9.Location = new Point(3, 3);
			tableLayoutPanel9.Name = "tableLayoutPanel9";
			tableLayoutPanel9.RowCount = 2;
			tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
			tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel9.Size = new Size(874, 407);
			tableLayoutPanel9.TabIndex = 1;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			label5.AutoSize = true;
			label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
			label5.ForeColor = Color.FromArgb(31, 38, 67);
			label5.Location = new Point(3, 369);
			label5.Name = "label5";
			label5.Size = new Size(868, 24);
			label5.TabIndex = 12;
			label5.Text = "(ACTIVO NETO) = $---";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel10
			// 
			tableLayoutPanel10.ColumnCount = 1;
			tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel10.Controls.Add(tbl_result, 0, 0);
			tableLayoutPanel10.Location = new Point(3, 3);
			tableLayoutPanel10.Name = "tableLayoutPanel10";
			tableLayoutPanel10.RowCount = 1;
			tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel10.Size = new Size(868, 314);
			tableLayoutPanel10.TabIndex = 0;
			// 
			// tbl_result
			// 
			tbl_result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbl_result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tbl_result.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			tbl_result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tbl_result.Location = new Point(3, 3);
			tbl_result.Name = "tbl_result";
			tbl_result.RowHeadersWidth = 51;
			tbl_result.Size = new Size(862, 308);
			tbl_result.TabIndex = 2;
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
			tableLayoutPanel2.Location = new Point(3, 7);
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
			label1.Text = "Estados financieros";
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
			tableLayoutPanel3.Location = new Point(3, 63);
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
			label3.Text = "Periodo: Desde";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel5.ColumnCount = 3;
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.73961F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2603951F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 262F));
			tableLayoutPanel5.Controls.Add(label6, 1, 0);
			tableLayoutPanel5.Controls.Add(date_desde, 0, 0);
			tableLayoutPanel5.Controls.Add(date_hasta, 2, 0);
			tableLayoutPanel5.Location = new Point(171, 3);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 1;
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel5.Size = new Size(720, 41);
			tableLayoutPanel5.TabIndex = 12;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			label6.AutoSize = true;
			label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
			label6.ForeColor = Color.FromArgb(27, 67, 50);
			label6.Location = new Point(308, 8);
			label6.Name = "label6";
			label6.Size = new Size(146, 24);
			label6.TabIndex = 12;
			label6.Text = "Hasta";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// date_desde
			// 
			date_desde.Location = new Point(3, 3);
			date_desde.MaxDate = new DateTime(2024, 11, 6, 0, 0, 0, 0);
			date_desde.Name = "date_desde";
			date_desde.Size = new Size(250, 27);
			date_desde.TabIndex = 13;
			date_desde.Value = new DateTime(2023, 11, 5, 23, 15, 0, 0);
			date_desde.ValueChanged += date_desde_ValueChanged;
			// 
			// date_hasta
			// 
			date_hasta.Location = new Point(460, 3);
			date_hasta.MaxDate = new DateTime(2024, 11, 6, 0, 0, 0, 0);
			date_hasta.Name = "date_hasta";
			date_hasta.Size = new Size(250, 27);
			date_hasta.TabIndex = 14;
			date_hasta.Value = new DateTime(2024, 11, 6, 0, 0, 0, 0);
			date_hasta.ValueChanged += date_hasta_ValueChanged;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(27, 67, 50);
			button2.Dock = DockStyle.Fill;
			button2.Font = new Font("Segoe UI", 10F);
			button2.ForeColor = Color.White;
			button2.Location = new Point(3, 3);
			button2.Name = "button2";
			button2.Size = new Size(427, 38);
			button2.TabIndex = 15;
			button2.Text = "Imprimir reporte";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// financialStatementForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(900, 576);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "financialStatementForm";
			Text = "financialStatement";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tableLayoutPanel6.ResumeLayout(false);
			tableLayoutPanel6.PerformLayout();
			tableLayoutPanel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)tbl_activo).EndInit();
			tableLayoutPanel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)tbl_capital).EndInit();
			((System.ComponentModel.ISupportInitialize)tbl_pasivo).EndInit();
			tableLayoutPanel11.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			tableLayoutPanel9.ResumeLayout(false);
			tableLayoutPanel9.PerformLayout();
			tableLayoutPanel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)tbl_result).EndInit();
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
		private TableLayoutPanel tableLayoutPanel2;
		private Label label1;
		private Label label2;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label3;
		private TableLayoutPanel tableLayoutPanel5;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TableLayoutPanel tableLayoutPanel6;
		private TableLayoutPanel tableLayoutPanel7;
		private TableLayoutPanel tableLayoutPanel8;
		private DataGridView tbl_activo;
		private DataGridView tbl_capital;
		private DataGridView tbl_pasivo;
		private Label txtBalance;
		private TableLayoutPanel tableLayoutPanel9;
		private Label label5;
		private TableLayoutPanel tableLayoutPanel10;
		private DataGridView tbl_result;
		private Label label6;
		private DateTimePicker date_desde;
		private DateTimePicker date_hasta;
		private TableLayoutPanel tableLayoutPanel11;
		private Button button1;
		private Button button2;
	}
}