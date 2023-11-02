using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDatabase.Entities {
	internal class Trip {
		public string? Id { get; set; }
		public User? User {	get; set; }
		public int UserId { get; set; }
		public int DepartureId { get; set; }
		public int ArricalId { get; set; }
		public ICollection<User>? Users { get; set; }
		public override string ToString() {
			return $"Id: {Id} | User: {User}";
		}
	}
}
