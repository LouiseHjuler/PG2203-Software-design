using EF_Own_test.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Own_test.DataAccess.SqLite {
	public class SaleDbContext : DbContext {
		public DbSet<Store> Store => Set<Store>();
		public DbSet<Branch> Branch => Set<Branch>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlite(@"Data Source = Resources\Sale.db");
		}
	}
}
