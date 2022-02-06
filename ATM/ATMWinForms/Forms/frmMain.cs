using ATMWinForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMWinForms.Forms
{
	public partial class frmMain : Form
	{
		private Korisnik korisnik;
		private KorisnikKartica korisnikkartica;
		public Kartica kartica;

		public frmMain()
		{
			InitializeComponent();
		}

		public frmMain(Korisnik korisnik, KorisnikKartica item) : this()
		{
			this.korisnik = korisnik;
			this.korisnikkartica = item;
			this.kartica = item.Kartica;
		}

		private void btnWithdraw_Click(object sender, EventArgs e)
		{
			this.Hide();
			new frmWithdraw(korisnikkartica).ShowDialog();
			this.Show();
		}

		private void btnBalance_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Current balance: {kartica.Novac}");
		}

		private void btnPrintStatement_Click(object sender, EventArgs e)
		{
			this.Hide();
			new frmPrintStatement().ShowDialog();
			this.Show();
		}

		private void btnChangePIN_Click(object sender, EventArgs e)
		{
			this.Hide();
			new frmChangePIN().ShowDialog();
			this.Show();
		}

		private void btnPrintBalance_Click(object sender, EventArgs e)
		{
			this.Hide();
			new frmPrintBalance().ShowDialog();
			this.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit", "Exiting?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Application.Exit();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			lblUser.Text = $"Welcome, {korisnik}";
		}
	}
}
