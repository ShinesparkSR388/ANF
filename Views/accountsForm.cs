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

namespace ANF.Views
{
	public partial class accountsForm : Form
	{
		QuerySql data = new QuerySql();
		List<Account> accounts = new List<Account>();
		public accountsForm()
		{
			InitializeComponent();
			accounts.Clear();
			accounts = data.getAccounts();
			fillTable();
		}

		private void fillTable()
		{
			tbl_Accounts.Rows.Clear();
			tbl_Accounts.Columns.Clear();

			tbl_Accounts.Columns.Add("code", "Codigo");
			tbl_Accounts.Columns.Add("description", "Descripcion");
			foreach (Account account in accounts)
			{
				if (account.Code.ToString().Contains(txtAccount.Text) || account.Description.ToString().ToLower().Contains(txtAccount.Text.ToLower()))
				{
					if (account.Code.ToString().Length == 1)
					{
						tbl_Accounts.Rows.Add(account.Code, account.Description);
					}
					else if (account.Code.ToString().Length == 3)
					{
						tbl_Accounts.Rows.Add("     " + account.Code, "     " + account.Description);
					}
					else
					{
						tbl_Accounts.Rows.Add("          " + account.Code, "          " + account.Description);
					}
				}
			}

		}

		private void txtAccount_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtAccount_KeyUp(object sender, KeyEventArgs e)
		{
			fillTable();
		}
	}
}
