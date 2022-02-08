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
	public partial class frmStarting : Form
	{
		ATMContext db = ATMdb.Baza;
		public frmStarting()
		{
			InitializeComponent();
		}

		private void frmStarting_Load(object sender, EventArgs e)
		{

		}

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			if (!Validator.Validate(txtPassword, err, "Password mandatory"))
				return;
			if (!Validator.Validate(txtUsername, err, "Password mandatory"))
				return;
			var korisnici = db.Korisnici.ToList();
			foreach (var item in korisnici)
			{
				if(item.Password==txtPassword.Text &&item.Username==txtUsername.Text)
				{
					MessageBox.Show("Uspjesno ste se logirali", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
					new frmCardPicker(item as Korisnik).ShowDialog();
					this.Close();
				}
			}
		}
	}
}
