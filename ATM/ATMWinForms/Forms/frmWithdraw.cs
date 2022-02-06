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
			throw new NotImplementedException();
		}
	}
}
