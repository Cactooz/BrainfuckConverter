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
        /// The optional <see cref="setup"/> code for BRAINFUCK working <see cref="memory">memory</see>.
        /// </summary>
        public string Setup { get => setup; }

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
        /// Encode a <see cref="string"/> of Extended ASCII characters into BRAINFUCK code.
        /// </summary>
        /// <param name="input">The <see cref="char"/> get movements to and print.</param>
        /// <param name="cell">The cell in the memory where the <paramref name="input"/> character exists.</param>
        /// <returns>A <see cref="string"/> of movements for the BRAINFUCK code.</returns>
        public string Encode(char input, int cell) {
            string output = "";

            while(pointer < cell) {
                output += ">";
                pointer++;
            }
            while(pointer > cell) {
                output += "<";
                pointer--;
            }
            while(memory[pointer] < input) {
                output += "+";
                memory[pointer]++;
            }
            while(memory[pointer] > input) {
                output += "-";
                memory[pointer]--;
            }
            output += ".";

            return output;
        }
    }
}
