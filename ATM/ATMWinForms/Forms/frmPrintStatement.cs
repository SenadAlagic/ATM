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
	public partial class frmPrintStatement : Form
	{
		private Kartica kartica;
		ATMContext db = ATMdb.Baza;

		public frmPrintStatement()
		{
			InitializeComponent();
			dgvTransakcije.AutoGenerateColumns = false;
		}

		public frmPrintStatement(Kartica kartica) : this()
		{
			this.kartica = kartica;
		}

		private void frmPrintStatement_Load(object sender, EventArgs e)
		{
			lblDate.Text = "Date: " + DateTime.Now.ToString();
			UcitajInfo();
		}

		private void UcitajInfo()
		{
			dgvTransakcije.DataSource = null;
			dgvTransakcije.DataSource = db.Transakcije.Where(i => i.Kartica.Id == kartica.Id).ToList();
		}
	}
}
