using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANF.Views
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{

		}

		private void txtAccount_TextChanged(object sender, EventArgs e)
		{
			if (txtCode.Text.Equals("12345"))
			{
				MessageBox.Show("Acceso correcto");
				mdiForm form = new mdiForm();
				form.Show();
				this.Hide(); 
			}
		}
	}
}
