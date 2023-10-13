using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_lecture.Entities {
	public class Education {
		public int Id { // Primary Key (PK)
			get; set;
		}
		public string Name { get; set; } = string.Empty;
		public ICollection<Student>? Students { get; set; } //Navigation property 

		public override string ToString() {
			return $"Id {Id} | Name: {Name}";
		}
	}
}
