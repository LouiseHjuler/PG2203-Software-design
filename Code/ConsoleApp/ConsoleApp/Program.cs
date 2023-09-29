using System.Runtime.CompilerServices;

internal class Program
{
	private static void Main(string[] args) {
		person person = new();
		ABetterPerson aBetterPerson = new();

		//person.setFirstname("Louise");
		aBetterPerson.Firstname = "Louise";

		//Console.WriteLine($"hello, {person.getFirstname()}");
		Console.WriteLine($"hello, {aBetterPerson.Firstname}");
	}

    public class ABetterPerson {

		// _ naming conventions Private classes should have an underscore
		//in front of the name. can be used instead of "this."

		public string Firstname { get; set; }
		private string _lastname;
		public string Lastname {
			get {
				return _lastname.Trim();
			}
			set {
				if (value.Length>=5) {
					_lastname = value;
				} else {
					_lastname = string.Empty; 
				}
			}
		}
	}
	public class person {
		private string firstname;
		private string lastname;

		public string getFirstname() {
			return firstname;
		}

		public void Setname(string name) {
			this.firstname = name;
		}

		
		public string getName() {
			return lastname.TrimEnd;
		}

		public void setname(string name) {
			if (name.Length >= 5) {
				this.lastname = name;
			}

		}
	}
}