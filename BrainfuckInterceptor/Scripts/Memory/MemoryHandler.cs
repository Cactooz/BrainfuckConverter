using System;

namespace BrainfuckInterceptor.Scripts.Memory {
	internal class MemoryHandler {
		private readonly MemoryExtendedASCII extendedASCII = new();
		private readonly MemoryASCII ascii = new();
		private readonly MemoryLettersNumbers lettersNumbers = new();
		private readonly MemoryEmpty empty = new();
		private readonly MemoryAuto auto = new();

		public string Encode(string inputText) {
			return Properties.Settings.Default.memory.ToLower() switch {
				"extendedascii" => extendedASCII.Encode(inputText),
				"ascii" => ascii.Encode(inputText),
				"lettersnumbers" => lettersNumbers.Encode(inputText),
				"empty" => empty.Encode(inputText),
				"auto" => auto.Encode(inputText),
				_ => throw new NotSupportedException($"The set Memory type '{Properties.Settings.Default.memory}' is invalid. Choose a valid one in the settings panel.")
			};
		}
	}
}
