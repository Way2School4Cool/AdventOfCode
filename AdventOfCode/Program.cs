namespace AdventOfCode {
	public class Program {
		public static void Main() {
			Console.WriteLine("Choose a day: ");
			string day = Console.ReadLine();

			switch (day) {
				case "1":
					Day1 challenge1 = new Day1();
					Console.WriteLine(challenge1.Challenge());
					break;

				case "2":
					Day2 challenge2 = new Day2();
					Console.WriteLine(challenge2.Challenge());
					break;

				default:
					Console.WriteLine("No input found");
					break;
			}
		}
	}
}