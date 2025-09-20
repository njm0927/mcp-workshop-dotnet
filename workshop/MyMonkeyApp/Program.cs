
using MyMonkeyApp;

class Program
{
	static readonly List<string> funnyAsciiArts = new List<string>
	{
		"( ͡° ͜ʖ ͡°)",
		"(☉_☉)",
		"(¬‿¬)",
		"(ᵔᴥᵔ)",
		"(◕‿◕)",
		"ʕ•ᴥ•ʔ",
		"(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧",
		"(づ｡◕‿‿◕｡)づ"
	};

	static void Main()
	{
		var rand = new Random();
		while (true)
		{
			Console.Clear();
			// 랜덤 ASCII 아트 출력
			Console.WriteLine(funnyAsciiArts[rand.Next(funnyAsciiArts.Count)]);
			Console.WriteLine("============================");
			Console.WriteLine("🐒 Monkey Console App 🐒");
			Console.WriteLine("============================");
			Console.WriteLine("1. List all monkeys");
			Console.WriteLine("2. Get details for a specific monkey by name");
			Console.WriteLine("3. Get a random monkey");
			Console.WriteLine("4. Exit app");
			Console.Write("Select an option: ");

			var input = Console.ReadLine();
			Console.WriteLine();
			switch (input)
			{
				case "1":
					ListAllMonkeys();
					break;
				case "2":
					GetMonkeyDetails();
					break;
				case "3":
					GetRandomMonkey();
					break;
				case "4":
					Console.WriteLine("Goodbye!");
					return;
				default:
					Console.WriteLine("Invalid option. Try again.");
					break;
			}
			Console.WriteLine("\nPress Enter to continue...");
			Console.ReadLine();
		}
	}

	static void ListAllMonkeys()
	{
		var monkeys = MonkeyHelper.GetAllMonkeys();
		Console.WriteLine("\nAvailable Monkeys:");
		Console.WriteLine("------------------");
		foreach (var m in monkeys)
		{
			Console.WriteLine($"- {m.Name}: {m.Description}");
		}
	}

	static void GetMonkeyDetails()
	{
		Console.Write("Enter monkey name: ");
		var name = Console.ReadLine();
		var monkey = MonkeyHelper.FindMonkeyByName(name);
		if (monkey != null)
		{
			Console.WriteLine($"\nName: {monkey.Name}");
			Console.WriteLine($"Description: {monkey.Description}");
			Console.WriteLine($"ASCII Art: {monkey.AsciiArt}");
		}
		else
		{
			Console.WriteLine("Monkey not found.");
		}
	}

	static void GetRandomMonkey()
	{
		var monkey = MonkeyHelper.GetRandomMonkey();
		Console.WriteLine($"\nRandom Monkey Picked!");
		Console.WriteLine($"Name: {monkey.Name}");
		Console.WriteLine($"Description: {monkey.Description}");
		Console.WriteLine($"ASCII Art: {monkey.AsciiArt}");
		Console.WriteLine($"(Random pick count: {MonkeyHelper.GetRandomPickCount()})");
	}
}
