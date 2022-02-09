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
		public Kartica kartica;

		public frmMain()
		{
			InitializeComponent();
		}

		public frmMain(Korisnik korisnik, Kartica item) : this()
		{
			this.korisnik = korisnik;
			this.kartica = item;
		}

		private void btnWithdraw_Click(object sender, EventArgs e)
		{
			this.Hide();
			new frmWithdraw(kartica, korisnik).ShowDialog();
			this.Show();
		}

		private void btnBalance_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Current balance: {kartica.Novac}");
		}

		private void btnPrintStatement_Click(object sender, EventArgs e)
		{
			//dgv with transactions 
			this.Hide();
			new frmPrintStatement(kartica).ShowDialog();
			this.Show();
		}

		private void btnChangePIN_Click(object sender, EventArgs e)
		{
			this.Hide();
			new frmChangePIN(kartica).ShowDialog();
			this.Show();
		}

		private void btnDeposit_Click(object sender, EventArgs e)
		{
			this.Hide();
			new frmDeposit(kartica,korisnik).ShowDialog();
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
