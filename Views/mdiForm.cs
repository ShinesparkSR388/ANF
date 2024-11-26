using ANF.Views;

namespace ANF
{
	public partial class mdiForm : Form
	{
		public mdiForm()
		{
			InitializeComponent();
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		}

		private void button1_MouseHover(object sender, EventArgs e)
		{
			btnClose.BackColor = Color.Red;
		}

		private void btnClose_MouseLeave(object sender, EventArgs e)
		{
			btnClose.BackColor = Color.FromArgb(31, 38, 67);
		}

		private void btnClose_MouseClick(object sender, MouseEventArgs e)
		{
			Application.Exit();
		}

		private void mdi_show(Form data)
		{
			if (this.MDI.Controls.Count > 0)
				this.MDI.Controls.RemoveAt(0);

			// Configura el formulario hijo
			data.TopLevel = false;
			data.Dock = DockStyle.Fill;

			// Agrega el formulario hijo al panel y lo muestra
			this.MDI.Controls.Add(data);
			this.MDI.Tag = data;
			data.Show();
		}

		private void menu1_Click(object sender, EventArgs e)
		{
			mdi_show(new diaryBookForm());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			mdi_show(new itemEntryForm());
		}

		private void button4_Click(object sender, EventArgs e)
		{
			mdi_show(new accountsForm());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			mdi_show(new financialStatementForm());
		}

		private void panel7_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
