using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Own_test.Entities {
	public class Branch {
		public int Id {
			get; set;
		} //PK

		public string Name {
			get; set;
		} = string.Empty;

		public int StoreId {
			get; set;
		}

		public Store? Store {
			get; set;
		}
		//public override string ToString() {
		//	return $"ID {Id} | Name: {Name}";
		//}
	}
}
