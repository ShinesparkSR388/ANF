using ANF.Logic;
using ANF.Models;
using ANF.Views.InternalViews;

namespace ANF.Views
{
	public partial class itemEntryForm : Form
	{
		QuerySql data = new QuerySql();
		List<Transaction> transactions = new List<Transaction>();
		Transaction current = new Transaction();
		Account account;

		public itemEntryForm()
		{
			InitializeComponent();
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Eliminar");

			contextMenuStrip.Items.Add(deleteMenuItem);

			tbl_transactions.ContextMenuStrip = contextMenuStrip;
			deleteMenuItem.Click += (sender, e) =>
			{
				if (tbl_transactions.SelectedRows.Count > 0)
				{
					int selectedIndex = tbl_transactions.SelectedRows[0].Index;
					int id_ = Convert.ToInt32(tbl_transactions.SelectedRows[0].Cells["id"].Value);
					if (id_ != null)
					{
						transactions.RemoveAt(id_);
						tbl_transactions.Rows.RemoveAt(id_);
						fillTable();
					}
				}
				else
				{
					MessageBox.Show("Seleccione una fila para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			};

		}

		private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Departure departure = new Departure();
			if (txtDescription.Text.Equals(""))
			{
				MessageBox.Show("Ingrese una descripcion");
				return;
			}
			departure.Description = txtDescription.Text;
			departure.Transactions = transactions;
			departure.Date = txtDate.Value.ToString("dd-MM-yyyy");
			departure.Time = "00:00:00";
			data.insertDeparture(departure);
			clean();

			MessageBox.Show("Partida agregada correctamente");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			using (searchAccountForm searchForm = new searchAccountForm())
			{
				if (searchForm.ShowDialog() == DialogResult.OK)
				{
					int selectedValue = searchForm.Result;
					// Utiliza el valor seleccionado
					Account acount = data.getAccount(selectedValue);
					current.IdAccount = acount.Id;
					current.Account_ = acount;
					txtAccount.Text = acount.Description;
					account = acount;

				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (current.Account_ != null)
			{
                foreach (Transaction item in transactions)
                {
                    if(item.Account_.Code == current.Account_.Code)
					{
						MessageBox.Show("La cuenta ya ha sido ingresada");
						cleanTransaction();
						return;
					}
                }
                if (current.Account_.Id != 0)
				{
					if (cbType.Text != "")
					{
						if (cbType.Text == "Haber")
						{
							current.Type = false;
						}
						else
						{
							current.Type = true;
						}
						double am = data.getAccountAmount(current.Account_.Code);
						if(current.Account_.Code.ToString().Substring(0, 1).Equals("1")  || current.Account_.Code.ToString().Substring(0, 1).Equals("5"))
						{
							if ((am - Convert.ToDouble(txtAmount.Value)) < 0 && !current.Type)
							{
								MessageBox.Show("El monto ingresado sobrepasa el monto restante en la cuenta");
								MessageBox.Show("Monto: " + am);
								return;
							}
						}
						else if(current.Account_.Code.ToString().Substring(0, 1).Equals("2"))
						{
							if ((am - Convert.ToDouble(txtAmount.Value)) < 0 && current.Type)
							{
								MessageBox.Show("El monto ingresado sobrepasa el monto restante en la cuenta");
								MessageBox.Show("Monto: " + am);
								return;
							}
						}

						current.Amount = Convert.ToDouble(txtAmount.Value);
						current.Account_ = this.account;
						transactions.Add(current);
						cleanTransaction();
						fillTable();
					}
					else
					{
						MessageBox.Show("Por favor seleccione un tipo de transaccion");
					}
				}
				else
				{
					MessageBox.Show("Por favor seleccione una cuenta");
				}
			}
		}
		private void cleanTransaction()
		{
			current = new Transaction();
			txtAccount.Text = "";
			txtAmount.Value = 0;
			cbType.SelectedIndex = 0;
			
		}
		private void clean()
		{
			cleanTransaction();
			txtDescription.Text = "";
			lblDebe.Text = "";
			lblHaber.Text = "";
			btnSave.Enabled = false;
			tbl_transactions.Columns.Clear();
			tbl_transactions.Rows.Clear();
			transactions = new List<Transaction>();
		}
		private void fillTable()
		{
			tbl_transactions.Rows.Clear();
			tbl_transactions.Columns.Clear(); 
			DataGridViewTextBoxColumn hiddenColumn = new DataGridViewTextBoxColumn();
			hiddenColumn.Name = "id";  // Nombre de la columna
			hiddenColumn.HeaderText = "Id";  // Título de la columna (opcional)
			hiddenColumn.Visible = false;
			tbl_transactions.Columns.Add(hiddenColumn);
			tbl_transactions.Columns.Add("code", "Code");
			tbl_transactions.Columns.Add("description", "Description");
			tbl_transactions.Columns["description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			tbl_transactions.Columns.Add("debe", "Debe");
			tbl_transactions.Columns.Add("haber", "Haber");
			double haber = 0;
			double debe = 0;
			int cc = 0;
			foreach (Transaction t in transactions) {
				if (t.Type)
				{
					Account ac1 = data.getAccountByCode(t.Account_.Code.ToString().Substring(0, 1));
					Account ac2 = data.getAccountByCode(t.Account_.Code.ToString().Substring(0, 3));
					tbl_transactions.Rows.Add(cc,ac1.Code, ac1.Description, "", "");
					tbl_transactions.Rows.Add(cc,ac2.Code, "   " + ac2.Description, "", "");
					tbl_transactions.Rows.Add(cc,t.Account_.Code, "     " + t.Account_.Description, t.Amount, "");
					debe = debe + t.Amount;
				}
				else
				{
					Account ac1 = data.getAccountByCode(t.Account_.Code.ToString().Substring(0, 1));
					Account ac2 = data.getAccountByCode(t.Account_.Code.ToString().Substring(0, 3));
					tbl_transactions.Rows.Add(cc, ac1.Code, ac1.Description, "", "");
					tbl_transactions.Rows.Add(cc, ac2.Code, "   " + ac2.Description, "", "");
					tbl_transactions.Rows.Add(cc, t.Account_.Code, "     " + t.Account_.Description, "", t.Amount);

					haber = haber + t.Amount;
				}
				cc = cc + 1;

			}

			lblDebe.Text = debe.ToString();
			lblHaber.Text = haber.ToString();
			if(haber == debe)
			{
				btnSave.Enabled = true;
			}
			else
			{
				btnSave.Enabled = false;	
			}
		}
	}
}
