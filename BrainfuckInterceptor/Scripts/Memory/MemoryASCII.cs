namespace BrainfuckInterceptor.Scripts.Memory {
	internal class MemoryASCII:Memory {
		private readonly string header = "++++++++++[>+++++++++>++++++++++++>++++++>+++++>++++++++>+++++++++++>++++<<<<<<<-]>+>+++>>";

		public override string Encode(string inputText) {
			Cells = new int[] { 0, 91, 123, 60, 50, 80, 110, 40 };
			Pointer = 4;

			string output = "";

			foreach(char inputChar in inputText) {
				if(inputChar >= 65 && inputChar <= 90)
					output += GetCode(inputChar, 5);
				else if(inputChar >= 97 && inputChar <= 122)
					output += GetCode(inputChar, 6);
				else if(inputChar >= 32 && inputChar <= 48)
					output += GetCode(inputChar, 7);
				else if(inputChar >= 48 && inputChar <= 57)
					output += GetCode(inputChar, 4);
				else if(inputChar >= 58 && inputChar <= 64)
					output += GetCode(inputChar, 3);
				else if(inputChar >= 123 && inputChar <= 126)
					output += GetCode(inputChar, 2);
				else if(inputChar >= 91 && inputChar <= 96)
					output += GetCode(inputChar, 1);
				else
					output += GetCode(inputChar, 0);
			}

			return header + output;
		}
	}
}
