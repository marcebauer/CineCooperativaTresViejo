using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineCooperativaTres
{
	class CineContext : DbContext
	{
		public DbSet<Pelicula> Pelicula { get; set; }
		
		protected override void OnConfiguring(DbContextOptionsBuilder optioinsBuilder)
		{
			optioinsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Cine;Trusted_Connection=True;");
		}
	}
}
