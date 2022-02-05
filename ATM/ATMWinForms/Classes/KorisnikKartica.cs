using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWinForms.Classes
{
	[Table("KorisniciKartice")]
	public class KorisnikKartica
	{
		public Korisnik Korisnik { get; set; }
		public Kartica Kartica { get; set; }
	}
}
