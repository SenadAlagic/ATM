using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWinForms.Classes
{
	[Table("Korisnici")]
	public class Korisnik
	{
		public int Id { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string JMBG { get; set; }
		public string DatumRodjenja { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public virtual List<KorisnikKartica> KorisnikoveKartice { get; set; }
		public override string ToString()
		{
			return $"{Ime} {Prezime}";
		}
	}
}
