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
	public partial class diaryBookForm : Form
	{
		QuerySql data = new QuerySql();
		List<Departure> departures;
		List<Account> accounts;
		public diaryBookForm()
		{
			InitializeComponent();
			departures = data.getDeparturesFKTransactions();
			accounts = data.getAccounts();
			fillTable();
		}
		private void fillTable()
		{
			tbl_Departures.Rows.Clear();
			tbl_Departures.Columns.Clear();

			tbl_Departures.Columns.Add("code", "Codigo");
			tbl_Departures.Columns.Add("descripcion", "Descripcion");
			tbl_Departures.Columns.Add("debe", "Debe");
			tbl_Departures.Columns.Add("haber", "Haber");

			foreach (var departure in departures)
			{
				foreach (var item in departure.Transactions)
				{
					foreach (var item1 in accounts)
					{
						if (item1.Id == item.IdAccount)
						{
							if (item.Type)
							{
								Account ac1 = data.getAccountByCode(item1.Code.ToString().Substring(0, 1));
								Account ac2 = data.getAccountByCode(item1.Code.ToString().Substring(0, 3));
								tbl_Departures.Rows.Add(ac1.Code, ac1.Description, "", "");
								tbl_Departures.Rows.Add("     " + ac2.Code, "       " + ac2.Description, "", "");
								tbl_Departures.Rows.Add("       " + item1.Code, "         " + item1.Description, item.Amount, "");
							}
							else
							{
								Account ac1 = data.getAccountByCode(item1.Code.ToString().Substring(0, 1));
								Account ac2 = data.getAccountByCode(item1.Code.ToString().Substring(0, 3));
								tbl_Departures.Rows.Add(ac1.Code, ac1.Description, "", "");
								tbl_Departures.Rows.Add("     " + ac2.Code, "       " + ac2.Description, "", "");
								tbl_Departures.Rows.Add("       " + item1.Code, "         " + item1.Description, "", item.Amount);
							}
						}
					}
				}
				tbl_Departures.Rows.Add(departure.Date, departure.Description);
				tbl_Departures.Rows.Add("");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			departures = data.getDeparturesBetween(dateTimePicker1.Value.ToString("dd-MM-yyyy"), dateTimePicker1.Value.ToString("dd-MM-yyyy"));
			fillTable();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			departures = data.getDeparturesFKTransactions();
			fillTable();
		}
	}
}
