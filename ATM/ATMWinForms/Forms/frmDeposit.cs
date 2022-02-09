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
	public partial class frmDeposit : Form
	{
		ATMContext db = ATMdb.Baza;
		private Kartica kartica;
		private Korisnik korisnik;

		public frmDeposit()
		{
			InitializeComponent();
		}

		public frmDeposit(Kartica kartica):this()
		{
			this.kartica = kartica;
		}

		public frmDeposit(Kartica kartica, Korisnik korisnik) : this(kartica)
		{
			this.korisnik = korisnik;
		}

		private void btnDeposit_Click(object sender, EventArgs e)
		{
			if (!Validator.Validate(txtAmount, err, "Field cannot be empty"))
				return;
			kartica.Novac += int.Parse(txtAmount.Text);
			MessageBox.Show("Deposit succesfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			var transakcija = new Transakcija()
			{
				Kartica = kartica,
				Korisnik = korisnik,
				Kolicina = int.Parse(txtAmount.Text),
				Type = "Deposit",
				Datum = DateTime.Now.ToString()
			};
			db.Transakcije.Add(transakcija);
			db.SaveChanges();
			this.Close();
		}
	}
}
