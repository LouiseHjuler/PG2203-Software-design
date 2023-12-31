﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_lecture.Entities {
	public class Education {
		public int Id { get; set; } // Primary Key (PK)
		public string Name { get; set; } = string.Empty;
		public ICollection<Student>? Students { get; set; } //Navigation property 

		public ICollection<Course>? Courses { get; set; }
		public override string ToString() {
			return $"Id {Id} | Name: {Name}";
		}
	}
}
