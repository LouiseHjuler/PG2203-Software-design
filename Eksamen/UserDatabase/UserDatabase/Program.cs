using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Diagnostics;
using UserDatabase.DataAccess.SqLite;
using UserDatabase.Entities;

namespace UserDatabase {
	internal class Program {
		static void Main() {
		}
		static int AddUser(string username, string city) {
			User user = new(); {
				user.Name = $"{username}";
				user.City = $"{city}" ;
				user.Admin = 0;
			}

			using UserDbContext db = new();
			db.User.Add(user);
			db.SaveChanges();

			return user.Id;
		
		}
		static void AddTrip(int tripId , int userId , int departlocation , int arrivalLocation) {
			using UserDbContext db = new();
			Trip trip = new() {
				Id = tripId ,
				UserId = userId ,
				DepartureId = departlocation ,
				ArrivalId = arrivalLocation ,
			};
			db.Add(trip);
			db.SaveChanges();
		}
	}
}
