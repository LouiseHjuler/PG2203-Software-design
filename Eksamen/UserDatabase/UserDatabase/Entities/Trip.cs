﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDatabase.Entities {
	public class Trip {
		public int Id { get; set; } //PK
		public User? User {	get; set; } //Navigation Property
		public int UserId { get; set; }
		public Capital? Departure { get; set; }
		public int DepartureId { get; set; } //FK
		public Capital? Arrival { get; set; }
		public int ArrivalId { get; set; } //FK
	}
}
