using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWinForms.Classes
{
	[Table("Transakcije")]
	public class Transakcija
	{
		public int Id { get; set; }
		public Korisnik Korisnik { get; set; }
		public Kartica Kartica { get; set; }
		public string Datum{ get; set; }
		public string Type { get; set; }
		public int Kolicina { get; set; }
	}
}
