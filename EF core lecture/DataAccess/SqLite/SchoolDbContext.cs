using EF_core_lecture.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_lecture.DataAccess.SqLite {
	internal class SchoolDbContext : DbContext {
		public DbSet<Student> Student => Set<Student>();
		public DbSet<Education> Education => Set<Education>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlite(@"Data Source = Resources\School.db"); //SQLite specific, @ also prevents read of special characters in string as anything but string 
		}

	}
}
