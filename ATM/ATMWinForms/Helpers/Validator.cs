using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMWinForms.Helpers
{
	public static class Validator
	{
		public static bool Validate(Control control, ErrorProvider err, string errText)
		{
            bool valid = true;
            if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                valid = false;
            else if (control is ComboBox && (control as ComboBox).SelectedIndex < 0)
                valid = false;
            else if (control is PictureBox && (control as PictureBox).Image == null)
                valid = false;

            if (valid == false)
            {
                err.SetError(control, errText);
                return false;
            }
            err.Clear();
            return true;
        }
	}
}
