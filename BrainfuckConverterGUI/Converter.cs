namespace BrainfuckConverterGUI {
	internal class Converter {
		/// <summary>
		/// The BRAINFUCK working memory cells with their current values.
		/// </summary>
		private readonly int[] memory;
		/// <summary>
		/// Where BRAINFUCK currently points at in the working memory.
		/// </summary>
		private int pointer;
		/// <summary>
		/// BRAINFUCK code executed first to set up the memory cells.
		/// </summary>
		private readonly string setup = "";

		/// <summary>
		/// Initializes a new instance of the <see cref="Converter"/> class with custom <see cref="memory"/> setup.
		/// </summary>
		/// <param name="memory">The BRAINFUCK working memory cells and their current values</param>
		/// <param name="pointer">Where BRAINFUCK currently points at in the working memory.</param>
		public Converter(int[] memory, int pointer) {
			this.memory = memory;
			this.pointer = pointer;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Converter"/> class with default <see cref="memory"/> setup.
		/// </summary>
		public Converter() {
			setup = "++++++++++[>+++++++++>++++++++++++>+++++++++++++>++++++>+++++>++++++++>+++++++++++>++++>++++++++++++++++++++++<<<<<<<<<-]>+>+++>>>>";
			memory = new int[] { 0, 91, 123, 130, 60, 50, 80, 110, 40, 220 };
			pointer = 6;
		}

		/// <summary>
		/// Encode the <paramref name="inputText"/> <see cref="string"/> of Extended ASCII characters into BRAINFUCK code.
		/// </summary>
		/// <param name="inputText">The text <see cref="string"/> of Extended ASCII to encode.</param>
		/// <returns></returns>
		public string Encode(string inputText) {
			string output = "";

			foreach(char inputChar in inputText) {
				if(inputChar >= 65 && inputChar <= 90)
					output += GetCode(inputChar, 6);
				else if(inputChar >= 97 && inputChar <= 122)
					output += GetCode(inputChar, 7);
				else if(inputChar >= 32 && inputChar <= 48)
					output += GetCode(inputChar, 8);
				else if(inputChar >= 48 && inputChar <= 57)
					output += GetCode(inputChar, 5);
				else if(inputChar >= 58 && inputChar <= 64)
					output += GetCode(inputChar, 4);
				else if(inputChar >= 192 && inputChar <= 255)
					output += GetCode(inputChar, 9);
				else if(inputChar >= 128 && inputChar <= 191)
					output += GetCode(inputChar, 3);
				else if(inputChar >= 123 && inputChar <= 126)
					output += GetCode(inputChar, 2);
				else if(inputChar >= 91 && inputChar <= 96)
					output += GetCode(inputChar, 1);
				else if(inputChar < 0 || inputChar > 255)
					continue;
				else
					output += GetCode(inputChar, 0);
			}

			return setup + output;
		}

        /// <summary>
        /// Gets a <see cref="string"/> of BRAINFUCK code to print the <paramref name="input"/> character.
        /// </summary>
        /// <param name="input">The <see cref="char"/> to get movements for and print.</param>
        /// <param name="cell">The cell in the memory where the <paramref name="input"/> character exists.</param>
        /// <returns>A <see cref="string"/> of movements for the BRAINFUCK code.</returns>
        public string GetCode(char input, int cell) {
			string output = "";

			//Move to the correct memory cell
			while(pointer != cell) {
				if(pointer < cell) {
                    output += ">";
                    pointer++;
                } else {
                    output += "<";
                    pointer--;
                }
            }

			//Increment/Decrement the value of the memory cell to correct Extended ASCII value
			while(memory[pointer] != input) {
                if(memory[pointer] < input) {
                    output += "+";
                    memory[pointer]++;
                } else {
                    output += "-";
                    memory[pointer]--;
                }
            }

			//Print the character
			output += ".";

			return output;
		}
	}
}
