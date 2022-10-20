using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineCooperativaTres
{
	class CineContext : DbContext
	{
		public DbSet<Pelicula> Pelicula { get; set; }
		
		protected override void OnConfiguring(DbContextOptioinsBuilder optioinsBuilder)
		{
			optioinsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDBCF
;Trusted_Connection=True;"));
		}
	}
}
