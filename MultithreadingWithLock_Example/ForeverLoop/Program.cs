
using System.Security.Principal;

internal class Program {
	private static void Main(string[] args) {
		//create x tasks
		Task[] tasks = new Task[20];
		for (int i = 0 ; i < tasks.Length ; i++) {
			Console.WriteLine($"Prep start Thread #{i}");
			tasks[i] = Task.Run(() => LoopForever(i)); ;
		}

		

		Task.WaitAll(tasks);
	}

	static void LoopForever(int i) {
		Console.WriteLine($"Started thread #{i}"); //ikke helt riktig, starter flere loops med samme i 
		while (true) {
			//very empty wow lets see how much CPU this uses (abt 30%)
			//Console.WriteLine(); //CPU 50% med 100% uten writeline
		}
	}
}