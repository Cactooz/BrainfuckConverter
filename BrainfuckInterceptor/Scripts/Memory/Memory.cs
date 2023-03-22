namespace BrainfuckInterceptor.Scripts.Memory {
	internal abstract class Memory {
		/// <summary>
		/// The BRAINFUCK working memory cells with their current values.
		/// </summary>
		protected int[] Cells { get; set; }
		/// <summary>
		/// Where BRAINFUCK currently points at in the working memory.
		/// </summary>
		protected int Pointer { get; set; }

		/// <summary>
		/// Encode the <paramref name="inputText"/> <see cref="string"/> of normal characters into BRAINFUCK code.
		/// </summary>
		/// <param name="inputText">The text <see cref="string"/> to encode.</param>
		/// <returns>A <see cref="string"/> with the BRAINFUCK code used to write the <paramref name="inputText"/>.</returns>
		public abstract string Encode(string inputText);

		/// <summary>
		/// Gets a <see cref="string"/> of BRAINFUCK code to print the <paramref name="input"/> character.
		/// </summary>
		/// <param name="input">The <see cref="char"/> to get movements for and print.</param>
		/// <param name="cell">The cell in the memory where the <paramref name="input"/> character exists.</param>
		/// <returns>A <see cref="string"/> of movements for the BRAINFUCK code.</returns>
		protected virtual string GetCode(char input, int cell) {
			if(input < 0 || input > 255)
				return "";

			string output = "";

			//Move to the correct memory cell
			while(Pointer != cell) {
				if(Pointer < cell) {
					output += ">";
					Pointer++;
				} else {
					output += "<";
					Pointer--;
				}
			}

			//Increment/Decrement the value of the memory cell to correct Extended ASCII value
			while(Cells[Pointer] != input) {
				if(Cells[Pointer] < input) {
					output += "+";
					Cells[Pointer]++;
				} else {
					output += "-";
					Cells[Pointer]--;
				}
			}

			//Print the character
			output += ".";

			return output;
		}
	}
}
