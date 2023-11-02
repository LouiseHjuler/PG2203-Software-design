using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDatabase.Entities {
	internal class User {
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? City { get; set; }
		public int Admin { get; set; }
		public override string ToString() {
			return $"Id:{Id} | Name: {Name}";
		}
	}
}
