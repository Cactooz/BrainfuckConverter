using System;
using System.Windows.Forms;

namespace BrainfuckConverterGUI {
	public partial class ConverterGUI:Form {
		public ConverterGUI() {
			InitializeComponent();
		}

		private void encodeButton_Click(object sender, EventArgs e) {
			try {
                Converter converter = new Converter();

				outputText.Text = converter.Encode(inputText.Text);
				outputLabel.Show();
                outputText.Show();
            } catch(Exception error) {
				MessageBox.Show(error.Message);
			}
		}
	}
}
