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

		private void frmCardPicker_Load(object sender, EventArgs e)
		{
			LoadComboBox();
		}
		void LoadComboBox()
		{
			cbCard.DataSource = db.KorisniciKartice.Where(k => k.Korisnik.Id == korisnik.Id).Select(k=>k.Kartica).ToList();
			//cbCard.DisplayMember = "Banka";
			//cbCard.ValueMember = "Id";
		}

		private void btnChoose_Click(object sender, EventArgs e)
		{
			if (!Validator.Validate(txtPIN, err, "Obavezan PIN"))
				return;
			var kartica = cbCard.SelectedItem as Kartica;
			if(kartica.PIN==txtPIN.Text)
			{
				this.Hide();
				new frmMain(korisnik, kartica).ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Ukucali ste pogresan PIN, odjavljivanje", "Odjava", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}
	}
}
