namespace AdventOfCode {
	public class Program {
		public static void Main() {
			Console.WriteLine("Choose a day: ");
			string day = Console.ReadLine();

			switch (day) {
				case "1":
					Day1 challenge = new Day1();
					Console.WriteLine(challenge.Challenge());
					break;

				default:
					Console.WriteLine("No input found");
					break;
			}
		}
	}
}