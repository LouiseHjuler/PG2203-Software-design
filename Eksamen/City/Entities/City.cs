using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Entities {
	internal class City {
		public int Id {
		 get; set; } //Primary Key
		public string Name {
		 get; set; } = string.Empty;
		public string Country {
			get; set;
		} = string.Empty;
		public int CoordinatesX {
		 get; set; }
		public int CoordinatesY {
			get; set;}
		public override string ToString() {
			return $"Id {Id} | Name: {Name} | Country: {Country}";
		}
	}
}
