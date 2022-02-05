using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWinForms.Helpers
{
	public class ATMContext : DbContext
	{
		public ATMContext():base("ATMPutanja")
		{

		}
	}
}
