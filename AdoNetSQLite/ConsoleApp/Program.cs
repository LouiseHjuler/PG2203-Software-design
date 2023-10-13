namespace ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			AdoNetDb db = new();

			// --- ONLY RUN ONCE!
			//db.CreateDbAndTable();
			// ---

			// --- Create and then read users from db.
			int firstUserId = db.InsertUser("Tomas Sandnes");
			int secondUserId = db.InsertUser("Rollo Tomasi");

			string firstNameCreated = db.ReadUserName(firstUserId);
			string secondNameCreated = db.ReadUserName(secondUserId);

			Console.WriteLine($"First name was:  '{firstNameCreated}'");
			Console.WriteLine($"Second name was: '{secondNameCreated}'");
			// ---

			// --- Only run to DELETE DB!
			//db.DropDb();
			// ---
		}
	}
}