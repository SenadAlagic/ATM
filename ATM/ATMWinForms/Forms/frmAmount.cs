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
	public partial class frmAmount : Form
	{
		private int amount;
		public frmAmount()
		{
			InitializeComponent();
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			if (!Validator.Validate(txtAmount, err, "Must enter a value")) ;
		}
	}
}
