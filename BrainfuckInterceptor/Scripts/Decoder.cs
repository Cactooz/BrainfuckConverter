using System.Collections.Generic;

namespace BrainfuckInterceptor.Scripts {
	internal class Decoder {
		/// <summary>
		/// Decode any inputted BRAINFUCK code into a <see cref="string"/> of Extended ASCII characters.
		/// </summary>
		/// <param name="inputCode">The BRAINFUCK code to decode.</param>
		/// <returns>A <see cref="string"/> with the Extended ASCII message from the <paramref name="inputCode"/>.</returns>
		public string Decode(string inputCode) {
			//Create temporary working memory
			List<int> workingMemory = new() { 0 };
			int memoryPointer = 0;

			string output = "";

			int i = 0;
			while(i < inputCode.Length) {
				switch(inputCode[i]) {
					case '+': {
						if(workingMemory[memoryPointer] >= 255)
							workingMemory[memoryPointer] = 0;
						else
							workingMemory[memoryPointer]++;
						break;
					}
					case '-': {
						if(workingMemory[memoryPointer] <= 0)
							workingMemory[memoryPointer] = 255;
						else
							workingMemory[memoryPointer]--;
						break;
					}
					case '>': {
						memoryPointer++;
						if(memoryPointer == workingMemory.Count)
							workingMemory.Add(0);
						break;
					}
					case '<': {
						memoryPointer--;
						if(memoryPointer < 0) {
							workingMemory.Insert(0, 0);
							memoryPointer = 0;
						}
						break;
					}
					case '[': {
						if(workingMemory[memoryPointer] == 0) {
							int loopCounter = 1;
							while(loopCounter > 0) {
								i++;
								if(inputCode[i] == '[') {
									loopCounter++;
								} else if(inputCode[i] == ']') {
									loopCounter--;
								}
							}
						}
						break;
					}
					case ']': {
						if(workingMemory[memoryPointer] != 0) {
							int loopCounter = 1;
							while(loopCounter > 0) {
								i--;
								if(inputCode[i] == '[') {
									loopCounter--;
								} else if(inputCode[i] == ']') {
									loopCounter++;
								}
							}
						}
						break;
					}
					case '.': {
						output += (char)workingMemory[memoryPointer];
						break;
					}
				}
				i++;
			}

			return output;
		}
	}
}
