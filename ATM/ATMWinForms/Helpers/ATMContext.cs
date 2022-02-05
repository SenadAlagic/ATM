using ATMWinForms.Classes;
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
		public DbSet<Korisnik> Korisnici { get; set; }
		public DbSet<Kartica> Kartice{ get; set; }
		public DbSet<KorisnikKartica> KorisniciKartice{ get; set; }
		public DbSet<Transakcija> Transakcije { get; set; }
	}
}
