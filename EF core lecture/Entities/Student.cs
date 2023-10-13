using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_lecture.Entities {
	public class Student {
		public int Id { get; set;}   //with ? after string  (string?)the value can be null. string is normally a non nullable value
		public string Name { get; set; } = string.Empty;    //instead of the ? we can do = string.empty to set a default state
		public int EducationID { get; set; } //FK forgein key
		public Education? Education { get; set; } // Navigation property 
		public override string ToString() {
			return $"Id {Id} | Name: {Name}";
		}

	}
}
