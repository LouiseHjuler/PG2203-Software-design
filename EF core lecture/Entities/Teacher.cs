using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_lecture.Entities {
	public class Teacher {
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public ICollection<Course>? Courses { get; set; }

		public override string ToString() {
			return $"Id:{Id} | Name:{Name}";
		}
	}
}
