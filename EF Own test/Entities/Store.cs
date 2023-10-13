using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Own_test.Entities {
	public class Store {
		public int Id {
			get; set;
		}

		public string Name {
			get; set;
		} = string.Empty;

		public ICollection<Branch>? Stores {
			get; set;
		}

		//public override string toString() {
		//	return $"ID{Id}  | Name: {Name}";
		//}
	}
}
