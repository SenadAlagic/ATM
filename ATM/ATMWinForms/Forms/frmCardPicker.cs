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
	public partial class frmCardPicker : Form
	{
		ATMContext db = ATMdb.Baza;
		private Korisnik korisnik;

		public frmCardPicker()
		{
			InitializeComponent();
		}

		public frmCardPicker(Korisnik korisnik) : this()
		{
			this.korisnik = korisnik;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void frmCardPicker_Load(object sender, EventArgs e)
		{
			LoadComboBox();
		}
		void LoadComboBox()
		{
			cbCard.DataSource = db.KorisniciKartice.Where(k => k.Korisnik.Id == korisnik.Id).ToList();
			cbCard.DisplayMember = "Banka";
			cbCard.ValueMember = "Id";
		}
	}
}
