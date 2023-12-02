using System.IO;

namespace AdventOfCode {
	public class Day1 {

		private string input = "..\\..\\..\\Day1\\Day1Input.txt";
		private Dictionary<string, int> numbers = new Dictionary<string, int>() {
			{"zero", 0},  {"0", 0},
			{"one", 1},   {"1", 1},
			{"two", 2},   {"2", 2},
			{"three", 3}, {"3", 3},
			{"four", 4},  {"4", 4},
			{"five", 5},  {"5", 5},
			{"six", 6},   {"6", 6},
			{"seven", 7}, {"7", 7},
			{"eight", 8}, {"8", 8},
			{"nine", 9},  {"9", 9}
		};
		private Dictionary<string, int> numbersReversed = new Dictionary<string, int>() {
			{"orez", 0},  {"0", 0},
			{"eno", 1},   {"1", 1},
			{"owt", 2},   {"2", 2},
			{"eerht", 3}, {"3", 3},
			{"ruof", 4},  {"4", 4},
			{"evif", 5},  {"5", 5},
			{"xis", 6},   {"6", 6},
			{"neves", 7}, {"7", 7},
			{"thgie", 8}, {"8", 8},
			{"enin", 9},  {"9", 9}
		};

		//private Dictionary<string, int> numbers = new Dictionary<string, int>() {
		//	{"0", 0},
		//	{"1", 1},
		//	{"2", 2},
		//	{"3", 3},
		//	{"4", 4},
		//	{"5", 5},
		//	{"6", 6},
		//	{"7", 7},
		//	{"8", 8},
		//	{"9", 9}
		//};
		//private Dictionary<string, int> numbersReversed = new Dictionary<string, int>() {
		//	{"0", 0},
		//	{"1", 1},
		//	{"2", 2},
		//	{"3", 3},
		//	{"4", 4},
		//	{"5", 5},
		//	{"6", 6},
		//	{"7", 7},
		//	{"8", 8},
		//	{"9", 9}
		//};

		private int firstNumber;
		private int lastNumber;

		private int calculateValues(string line) {
			int calculation;
			int firstNumberPosition = line.Length + 1;
			
			int lastNumberPosition = line.Length + 1;

			// reverse line and search for last number
			char[] charArray = line.ToCharArray();
			Array.Reverse(charArray);
			string lineReversed = new string(charArray);

			// search line front to back
			foreach (string k in numbers.Keys) {
				if (line.Contains(k)) {
					if (line.IndexOf(k) < firstNumberPosition) {
						firstNumber = numbers[k];
						firstNumberPosition = line.IndexOf(k);
					}
				}
			}

			foreach (string k in numbersReversed.Keys) {
				if (lineReversed.Contains(k)) {
					if (lineReversed.IndexOf(k) < lastNumberPosition) {
						lastNumber = numbersReversed[k];
						lastNumberPosition = lineReversed.IndexOf(k);
					}
				}
			}

			calculation = (firstNumber*10)+lastNumber;

			return calculation;
		}

		public int Challenge() {
			int response = 0;

			var lines = File.ReadLines(input);
			foreach (var line in lines) {
				response += calculateValues(line);
			}

			return response;
		}
	}
}