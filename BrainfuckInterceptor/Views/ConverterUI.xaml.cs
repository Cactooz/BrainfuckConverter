using BrainfuckInterceptor.Scripts;
using BrainfuckInterceptor.Scripts.Memory;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace BrainfuckInterceptor.Views {
	/// <summary>
	/// Interaction logic for ConverterUI.xaml
	/// </summary>
	public partial class ConverterUI:Page {
		private readonly MemoryHandler memoryHandler = new();
		private readonly Decoder decoder = new();
		private static readonly string tmpFilePath = Path.GetFullPath(Path.Combine(Path.GetTempPath(), "BFI.tmp"));

		internal static string TmpFilePath { get => tmpFilePath; }

		public ConverterUI() {
			InitializeComponent();
			OutputLabel.Visibility = Visibility.Collapsed;
			OutputText.Visibility = Visibility.Collapsed;
			CopyButton.Visibility = Visibility.Collapsed;

			if(File.Exists(tmpFilePath)) {
				InputText.Text = File.ReadAllText(tmpFilePath);
			}
		}

		private void EncodeButton_Click(object sender, RoutedEventArgs e) {
			try {
				OutputText.Text = memoryHandler.Encode(InputText.Text);
				OutputLabel.Content = "BRAINFUCK Code Output";
				OutputLabel.Visibility = Visibility.Visible;
				OutputText.Visibility = Visibility.Visible;
				CopyButton.Visibility = Visibility.Visible;
			} catch(Exception error) {
				MessageBox.Show(error.Message);
			}
		}
		private void DecodeButton_Click(object sender, RoutedEventArgs e) {
			try {
				OutputText.Text = decoder.Decode(InputText.Text);
				OutputLabel.Content = "Extended ASCII Text Output";
				OutputLabel.Visibility = Visibility.Visible;
				OutputText.Visibility = Visibility.Visible;
				CopyButton.Visibility = Visibility.Visible;
			} catch(Exception error) {
				MessageBox.Show(error.Message);
			}
		}

		private void CopyButton_Click(object sender, RoutedEventArgs e) {
			try {
				Clipboard.SetText(OutputText.Text);
			} catch(Exception error) {
				MessageBox.Show(error.Message);
			}
		}

		private void InputText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) {
			try {
				if(InputText.Text.Length <= 0) {
					EncodeButton.IsEnabled = false;
					DecodeButton.IsEnabled = false;
				} else {
					EncodeButton.IsEnabled = true;
					DecodeButton.IsEnabled = true;
				}

				if(Regex.IsMatch(InputText.Text, @"^[-+.<>[\]]+$"))
					DecodeButton.IsEnabled = true;
				else
					DecodeButton.IsEnabled = false;
			} catch(Exception error) {
				MessageBox.Show(error.Message);
			}

			File.WriteAllText(tmpFilePath, InputText.Text);
		}
	}
}
