namespace BrainfuckInterceptor.Scripts.Memory {
	internal class MemoryLettersNumbers:Memory {
		private readonly string header = "++++++++++[>+++++>++++++++>+++++++++++<<<-]>>";

		public override string Encode(string inputText) {
			Cells = new int[] { 0, 50, 80, 110 };
			Pointer = 2;

			string output = "";

			foreach(char inputChar in inputText) {
				if(inputChar >= 65 && inputChar <= 90)
					output += GetCode(inputChar, 2);
				else if(inputChar >= 97 && inputChar <= 122)
					output += GetCode(inputChar, 3);
				else if(inputChar >= 48 && inputChar <= 57)
					output += GetCode(inputChar, 1);
				else
					output += GetCode(inputChar, 0);
			}

			return header + output;
		}
	}
}
