using System;
using System.Windows.Forms;

namespace BrainfuckConverterGUI {
	public partial class ConverterGUI:Form {
		public ConverterGUI() {
			InitializeComponent();
		}

		private void encodeButton_Click(object sender, EventArgs e) {
			try {
				string inputData = inputText.Text;

                string inputCode = "";
                Converter converter = new Converter();

                foreach(char inputChar in inputData) {
					if(inputChar >= 65 && inputChar <= 90)
						inputCode += converter.Encode(inputChar, 6);
					else if(inputChar >= 97 && inputChar <= 122)
						inputCode += converter.Encode(inputChar, 7);
					else if(inputChar >= 32 && inputChar <= 48)
						inputCode += converter.Encode(inputChar, 8);
					else if(inputChar >= 48 && inputChar <= 57)
						inputCode += converter.Encode(inputChar, 5);
					else if(inputChar >= 58 && inputChar <= 64)
						inputCode += converter.Encode(inputChar, 4);
					else if(inputChar >= 192 && inputChar <= 255)
						inputCode += converter.Encode(inputChar, 9);
					else if(inputChar >= 128 && inputChar <= 191)
						inputCode += converter.Encode(inputChar, 3);
					else if(inputChar >= 123 && inputChar <= 126)
						inputCode += converter.Encode(inputChar, 2);
					else if(inputChar >= 91 && inputChar <= 96)
						inputCode += converter.Encode(inputChar, 1);
					else if(inputChar < 0 || inputChar > 255)
						continue;
					else
						inputCode += converter.Encode(inputChar, 0);
				}

				outputText.Show();
				outputText.Text = converter.Setup + inputCode;

			} catch(Exception error) {
				MessageBox.Show(error.Message);
			}
		}
	}
}
