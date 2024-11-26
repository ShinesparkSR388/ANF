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
	public partial class analysisForm : Form
	{
		QuerySql data = new QuerySql();
		List<Account> accounts = new List<Account>();
		List<Transaction> transactions = new List<Transaction>();
		__Endeudamiento endeudamiento = new __Endeudamiento();
		__Rotacion rotacion = new __Rotacion();

		public int Result { get; set; }
		public analysisForm(__Endeudamiento endeudamiento, __Rotacion rotacion)
		{
			InitializeComponent();
			accounts.Clear();
			accounts = data.getUsableAccounts();
			fillTable();
			this.endeudamiento = endeudamiento;
			this.rotacion = rotacion;

			lbl1.Text = Math.Round(rotacion.RotacionActivosTotales(),2).ToString();
			lbl2.Text = Math.Round(rotacion.RotacionActivosFijos(), 2).ToString();
			lbl3.Text = Math.Round(rotacion.RotacionInventarios(), 2).ToString();

			lbl5.Text = Math.Round(endeudamiento.RatioDeEndeudamiento(), 2).ToString();
			lbl6.Text = Math.Round(endeudamiento.EndeudamientoCortoPlazo(), 2).ToString();
			lbl7.Text = Math.Round(endeudamiento.EndeudamientoLargoPlazo(), 2).ToString();
			lbl8.Text = Math.Round(endeudamiento.RatioDePasivoSobreActivo(), 2).ToString();
		}
		private void fillTable()
		{


		}

		private void button1_Click(object sender, EventArgs e)
		{
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

		private void label9_Click(object sender, EventArgs e)
		{

		}
	}
}
