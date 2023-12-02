using System.IO;

namespace AdventOfCode {
	public class Day1 {

		private string input = "..\\..\\..\\Day1\\Day1Input.txt";

		private int calculateValues(string line) {
			int calculation = 0;


			
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