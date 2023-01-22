using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BrainfuckConverterGUI {
	public partial class ConverterGUI:Form {
		public ConverterGUI() {
			InitializeComponent();
		}

		private void encodeButton_Click(object sender, EventArgs e) {
			try {
				Converter encoder = new Converter();
				outputText.Text = encoder.Encode(inputText.Text);
				outputLabel.Text = "BRAINFUCK Code Output";
				outputLabel.Show();
				outputText.Show();
				copyButton.Show();
			} catch(Exception error) {
				MessageBox.Show(error.Message);
			}
		}

		private void decodeButton_Click(object sender, EventArgs e) {
			try {
				Converter decoder = new Converter();
				outputText.Text = decoder.Decode(inputText.Text);
				outputLabel.Text = "Extended ASCII Text Output";
				outputLabel.Show();
				outputText.Show();
				copyButton.Show();
			} catch(Exception error) {
				MessageBox.Show(error.Message);
			}
		}

		private void copyButton_Click(object sender, EventArgs e) {
			try {
				Clipboard.SetText(outputText.Text);
			} catch(Exception error) {
				MessageBox.Show(error.Message);
			}
		}

		private void inputText_TextChanged(object sender, EventArgs e) {
			try {
				if(Regex.IsMatch(inputText.Text, @"[-+.<>[\]]"))
					decodeButton.Enabled = true;
				else
					decodeButton.Enabled = false;
			} catch(Exception error) {
				MessageBox.Show(error.Message);
			}
		}
	}
}
