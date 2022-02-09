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
	public partial class frmChangePIN : Form
	{
		ATMContext db = ATMdb.Baza;
		private Kartica kartica;

		public frmChangePIN()
		{
			InitializeComponent();
		}

		public frmChangePIN(Kartica kartica):this()
		{
			this.kartica = kartica;
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			if (!Validator.Validate(txtCurrent, err, "Field required")&&!Validator.Validate(txtNew, err, "Field required"))
				return;
			if(txtNew.Text.Length!=4)
			{
				MessageBox.Show("New PIN number must be a 4 digit combination","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			if(txtCurrent.Text!=kartica.PIN)
			{
				MessageBox.Show("Incorrect PIN number","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				Application.Exit();
			}
			kartica.PIN = txtNew.Text;
			MessageBox.Show("Succesfully changed your PIN number", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			db.SaveChanges();
			this.Close();
		}
	}
}
