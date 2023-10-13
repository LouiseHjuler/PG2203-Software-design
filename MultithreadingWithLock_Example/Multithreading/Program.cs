/////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Example from: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/lock-statement
//
//	(Tomas Sandnes: I've done some changes for what I feel is a more pedagogical approach.)
// 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Threading.Tasks;

public class Account
{
	private static readonly object _consoleLock = new();
	private readonly object _balanceLock = new();
	private int _balance;

	public Account(int initialBalance)
	{
		_balance = initialBalance;
	}

	public void Debit(int amountToWithdraw)
	{
		//lock (_balanceLock) 
		{
			if (_balance >= amountToWithdraw) {
				WriteLineAppendThreadId($"Balance before debit :{_balance, 5}");
				WriteLineAppendThreadId($"Amount to withdraw   :{-amountToWithdraw, 5}");
				_balance -= amountToWithdraw;
				WriteLineAppendThreadId($"Balance after debit  :{_balance, 5}");
			} 
		}
	}


	// Convenient helper to print threadId before console message.
	private static void WriteLineAppendThreadId(string lineOfText)
	{
		int threadId = Environment.CurrentManagedThreadId;
		// NOTE: Calling these Console commands is NOT threadsafe by itself, so we need to lock this.
		lock (_consoleLock) {
			// To give threads different colors in the console (with thread #1 being white).
			Console.ForegroundColor = (ConsoleColor)((threadId + 13) % 15 + 1);
			Console.WriteLine($"Thread {Environment.CurrentManagedThreadId,2} | {lineOfText}");
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}


class Program
{
	static void Main()
	{
		// Create 1 account with 1000 credits in it.
		Account account = new(1000);

		// Create and run 100 parallell tasks, each of them doing
		// 10 debits (of random amounts) on the 1 account. 
		Task[] tasks = new Task[100];
		for (int i = 0; i < tasks.Length; i++) {
			tasks[i] = Task.Run(() => ExecuteTenRandomDebits(account));
		}

		// Wait for all parallell tasks to finish before we exit main.
		Task.WaitAll(tasks);
	}

	static void ExecuteTenRandomDebits(Account account)
	{
		Random random = new();
		for (int i = 0; i < 10; i++) {
			// Generate random values, from 1 to 99, to debit account by.
			int amount = random.Next(1, 100);

			account.Debit(amount);
		}
	}
}