namespace BrainfuckInterceptor.Scripts.Memory {
	internal class MemoryEmpty:Memory {

		public override string Encode(string inputText) {
			Cells = new int[] { 0 };

			string output = "";

			foreach(char inputChar in inputText) {
				if(inputChar < 0 || inputChar > 255)
					continue;

				output += GetCode(inputChar, 0);
			}

			return output;
		}

		protected override string GetCode(char input, int cell) {
			string output = "";

			//Increment/Decrement the value of the memory cell to correct Extended ASCII value
			while(Cells[0] != input) {
				if(Cells[0] < input) {
					output += "+";
					Cells[0]++;
				} else {
					output += "-";
					Cells[0]--;
				}
			}

			//Print the character
			output += ".";

			return output;
		}
	}
}
