using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace BrainfuckInterceptor.Views
{
    /// <summary>
    /// Interaction logic for ConverterUI.xaml
    /// </summary>
    public partial class ConverterUI : Page
    {
        public ConverterUI()
        {
            InitializeComponent();
            OutputLabel.Visibility = Visibility.Collapsed;
            OutputText.Visibility = Visibility.Collapsed;
            CopyButton.Visibility = Visibility.Collapsed;
        }

        private void EncodeButton_Click(object sender, RoutedEventArgs e) {
            try {
                Converter encoder = new Converter();
                OutputText.Text = encoder.Encode(InputText.Text);
                OutputLabel.Content = "BRAINFUCK Code Output";
                OutputLabel.Visibility = Visibility.Visible;
                OutputText.Visibility = Visibility.Visible;
                CopyButton.Visibility = Visibility.Visible;
            }
            catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }
        private void DecodeButton_Click(object sender, RoutedEventArgs e) {
            try {
                Converter decoder = new Converter();
                OutputText.Text = decoder.Decode(InputText.Text);
                OutputLabel.Content = "Extended ASCII Text Output";
                OutputLabel.Visibility = Visibility.Visible;
                OutputText.Visibility = Visibility.Visible;
                CopyButton.Visibility = Visibility.Visible;
            }
            catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e) {
            try {
                Clipboard.SetText(OutputText.Text);
            }
            catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void InputText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) {
            try {
                if(InputText.Text.Length <= 0) {
                    EncodeButton.IsEnabled = false;
                    DecodeButton.IsEnabled = false;
                }
                else {
                    EncodeButton.IsEnabled = true;
                    DecodeButton.IsEnabled = true;
                }

                if(Regex.IsMatch(InputText.Text, @"[-+.<>[\]]"))
                    DecodeButton.IsEnabled = true;
                else
                    DecodeButton.IsEnabled = false;
            }
            catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }
    }
}
