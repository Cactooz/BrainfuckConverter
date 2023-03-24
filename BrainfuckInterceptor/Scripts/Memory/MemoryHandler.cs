using System;

namespace BrainfuckInterceptor.Scripts.Memory {
	internal class MemoryHandler {
		private readonly MemoryExtendedASCII extendedASCII = new();
		private readonly MemoryASCII ascii = new();
		private readonly MemoryLettersNumbers lettersNumbers = new();
		private readonly MemoryEmpty empty = new();

		public string Encode(string inputText) {
			return Properties.Settings.Default.memory.ToLower() switch {
				"extendedascii" => extendedASCII.Encode(inputText),
				"ascii" => ascii.Encode(inputText),
				"lettersnumbers" => lettersNumbers.Encode(inputText),
				"empty" => empty.Encode(inputText),
				_ => throw new NotSupportedException($"The set Memory type '{Properties.Settings.Default.memory}' is invalid. Choose a valid one in the settings panel.")
			};
		}

		/* TODO:
		 * Add the check from settings which memory should be used
		 * Create that object with the correct class
		 * 
		 * Add Encode class that uses the correct memory
		 * Should just have one "memory" object that is different dependent on the setting if possible,
		 * in order to make just one encode method for everything
		 * 
		 * For the future, there will be an auto memory that uses the best possible for the input
		 */
	}
}
