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
	public partial class frmWithdraw : Form
	{
		private KorisnikKartica korisnikkartica;

		public frmWithdraw()
		{
			InitializeComponent();
		}

		public frmWithdraw(KorisnikKartica korisnikkartica) : this()
		{
			this.korisnikkartica = korisnikkartica;
		}

		private void btn10_Click(object sender, EventArgs e)
		{
			Withdraw(sender, e);
		}

		private void btn20_Click(object sender, EventArgs e)
		{
			Withdraw(sender, e);
		}

		private void btn50_Click(object sender, EventArgs e)
		{
			Withdraw(sender, e);
		}

		private void btn200_Click(object sender, EventArgs e)
		{
			Withdraw(sender, e);
		}

		private void btn100_Click(object sender, EventArgs e)
		{
			Withdraw(sender, e);
		}
		private void Withdraw(object sender, EventArgs e)
		{
			if ((sender as Button).Text == "10")
				korisnikkartica.Kartica.Novac -= 10;
			else if ((sender as Button).Text == "20")
				korisnikkartica.Kartica.Novac -= 20;
			else if ((sender as Button).Text == "50")
				korisnikkartica.Kartica.Novac -= 50;
			else if ((sender as Button).Text == "100")
				korisnikkartica.Kartica.Novac -= 100;
			else if ((sender as Button).Text == "200")
				korisnikkartica.Kartica.Novac -= 200;
		}

		private void btnCustom_Click(object sender, EventArgs e)
		{
			new frmAmount().Show();
		}
	}
}
