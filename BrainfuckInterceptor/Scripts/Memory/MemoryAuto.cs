using System.Text.RegularExpressions;

namespace BrainfuckInterceptor.Scripts.Memory {
	internal class MemoryAuto:Memory {
		private readonly MemoryExtendedASCII extendedASCII = new();
		private readonly MemoryASCII ascii = new();
		private readonly MemoryLettersNumbers lettersNumbers = new();

		public override string Encode(string inputText) {
			if(Regex.IsMatch(inputText, @"^[a-zA-Z0-9.,]+$"))
				return lettersNumbers.Encode(inputText);
			
			if(Regex.IsMatch(inputText, @"^[\x00-\x7F]+$"))
				return ascii.Encode(inputText);

			return extendedASCII.Encode(inputText);
		}
	}
}
