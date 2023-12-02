using System.IO;

namespace AdventOfCode {
	public class Day2 {
		private string input = "..\\..\\..\\Day2\\input.txt";
		private Dictionary<int, string> colorLimits = new Dictionary<int, string>() {
			{12, "red"},
			{13, "green"},
			{14, "blue"},
		};

		private bool calculateValues(string line) {
			string[] numbersAndColors;
			string temp;
			int number = 100;

			numbersAndColors = line.Split(":");
			temp = string.Join(",", numbersAndColors);
			numbersAndColors = temp.Split(',');
			temp = string.Join(";", numbersAndColors);
			numbersAndColors = temp.Split(';');

			for (int i = 0; i < numbersAndColors.Length; i++){
				if (numbersAndColors[i].Contains("red")) {
					if (numbersAndColors[i][3].Equals(' ')) {
						number = Int32.Parse(numbersAndColors[i].Substring(1, 2));
						if (number > 12) {
							return false;
						}
					}
				}
				else if (numbersAndColors[i].Contains("green")) {
					if (numbersAndColors[i][3].Equals(' ')) {
						number = Int32.Parse(numbersAndColors[i].Substring(1, 2));
						if (number > 13) {
							return false;
						}
					}
				}
				else if (numbersAndColors[i].Contains("blue")) {
					if (numbersAndColors[i][3].Equals(' ')) {
						number = Int32.Parse(numbersAndColors[i].Substring(1, 2));
						if (number > 14) {
							return false;
						}
					}
				}
			}

			return true;

		}
		
		public int Challenge() {
			int response = 0;
			int gameNumber = 1;

			var lines = File.ReadLines(input);
			foreach (var line in lines) {
				if (calculateValues(line)) {
					response += gameNumber;
				}
				gameNumber++;
			}

			return response;
		}
	}
}