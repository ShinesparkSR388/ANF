using ANF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANF.Models;

namespace ANF.Views.InternalViews
{
	public partial class searchAccountForm : Form
	{
		QuerySql data = new QuerySql();
		List<Account> accounts = new List<Account>();
		List<Transaction> transactions = new List<Transaction>();

		public int Result { get; set; }
		public searchAccountForm()
		{
			InitializeComponent();
			accounts.Clear();
			accounts = data.getUsableAccounts();
			fillTable();
		}
		private void fillTable()
		{
			tbl_accounts.Columns.Clear();
			tbl_accounts.Rows.Clear();
			tbl_accounts.Columns.Add("code", "Code");
			tbl_accounts.Columns.Add("description", "Description");
			foreach (Account account in accounts)
			{
				if (account.Code.ToString().Contains(txtSearch.Text) || account.Description.ToLower().Contains(txtSearch.Text.ToLower()))
				{
					tbl_accounts.Rows.Add(account.Code, account.Description);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tbl_accounts.Rows.Count > 0)
			{
				DataGridViewRow selectedRow = tbl_accounts.SelectedRows[0];
				string columnValue = selectedRow.Cells["Code"].Value?.ToString();
				foreach (Account account in accounts)
				{
					if (account.Code.ToString().Equals(columnValue))
					{
						Result = account.Id;
						DialogResult = DialogResult.OK;
						Close();
					}
				}
			}
			else
			{
				MessageBox.Show("Seleccione una cuenta");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			fillTable();
		}

		private void tbl_accounts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
