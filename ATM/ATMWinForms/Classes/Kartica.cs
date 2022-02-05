using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWinForms.Classes
{
	[Table("Kartice")]
	public class Kartica
	{
		public int Id { get; set; }
		public int PIN { get; set; }
		public string Banka { get; set; }
		public int Novac { get; set; }
		public override string ToString()
		{
			return Banka;
		}
	}
}
