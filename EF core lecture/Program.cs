using EF_core_lecture.DataAccess.SqLite;
using EF_core_lecture.Entities;

namespace EF_core_lecture {
	internal class Program {
		static void Main() {
			int educationId = AddEducation();
			WriteEducation();
			AddStudents(educationId);
			WriteStudenNamedDoffen();
		}

		static int AddEducation() {
			Education education = new(); {

				education.Name = "Data Science";
			}

			using SchoolDbContext db = new();
			db.Education.Add(education);
			db.SaveChanges();

			return education.Id;
		}

		static void AddStudents(int educationId) {
			using SchoolDbContext db = new();
			List<Student> students = new() {
				new Student () {
					Name = "Ole",
					EducationID = educationId,
				},
				new Student () {
					Name = "Dole",
					EducationID = educationId,
				},
				new Student () {
					Name = "Doffen",
					EducationID = educationId,
				},
			};
			db.AddRange(students);
			db.SaveChanges();
		}

		static void WriteEducation() {
			using SchoolDbContext db = new();
			IList<Education> educations = db.Education.ToList();
			foreach (var education in educations) {
				Console.WriteLine(education.Name);
			}
		}

		static void WriteStudenNamedDoffen() {
			using SchoolDbContext db = new();
			Student? student = db.Student.Where(s => s.Name == "Doffen").FirstOrDefault();
			// possible to use var Student to get LINQ to fill out variable type, but not reccommended 
			Console.WriteLine(student?.Name);
		}
	}
}