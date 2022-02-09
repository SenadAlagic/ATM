using ATMWinForms.Classes;
using ATMWinForms.Helpers;
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
		private Kartica kartica;
		private Korisnik korisnik;
		ATMContext db = ATMdb.Baza;
		public frmWithdraw()
		{
			InitializeComponent();
		}

		public frmWithdraw(Kartica korisnikkartica, Korisnik korisnik) : this()
		{
			this.kartica = korisnikkartica;
			this.korisnik = korisnik;
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
			int toWithdraw = int.Parse((sender as Button).Text);
			if (CanWithdraw(toWithdraw))
			{
				kartica.Novac -= toWithdraw;
				MessageBox.Show("Withdrawal succesfull","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
				var transakcija = new Transakcija()
				{
					Kartica=kartica,
					Korisnik=korisnik,
					Datum = DateTime.Now.ToString(),
					Kolicina=toWithdraw,
					Type="Withdrawal"
				};
				db.Transakcije.Add(transakcija);
				db.SaveChanges();
				this.Close();
			}
			else
				MessageBox.Show("Insufficient funds on your card","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			//if ((sender as Button).Text == "10")
			//	kartica.Novac -= 10;
			//else if ((sender as Button).Text == "20")
			//	kartica.Novac -= 20;
			//else if ((sender as Button).Text == "50")
			//	kartica.Novac -= 50;
			//else if ((sender as Button).Text == "100")
			//	kartica.Novac -= 100;
			//else if ((sender as Button).Text == "200")
			//	kartica.Novac -= 200;
		}
		bool CanWithdraw(int amount)
		{
			return (kartica.Novac >= amount);
		}
		private void btnCustom_Click(object sender, EventArgs e)
		{
			var forma = new frmAmount();
			if (forma.ShowDialog()==DialogResult.OK)
			{
				if (CanWithdraw(forma.Amount))
				{
					kartica.Novac -= forma.Amount;
					MessageBox.Show("Withdrawal succesfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					var transakcija = new Transakcija()
					{
						Kartica = kartica,
						Korisnik = korisnik,
						Datum = DateTime.Now.ToString(),
						Kolicina = forma.Amount,
						Type = "Withdrawal"
					};
					db.Transakcije.Add(transakcija);
					db.SaveChanges();
					this.Close();
				}
				else
					MessageBox.Show("Insufficient funds on your card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}
