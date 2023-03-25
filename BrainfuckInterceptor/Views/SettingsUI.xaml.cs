using System.Windows;
using System.Windows.Controls;

namespace BrainfuckInterceptor.Views {
	/// <summary>
	/// Interaction logic for SettingsUI.xaml
	/// </summary>
	public partial class SettingsUI:Page {
		public SettingsUI() {
			InitializeComponent();

			switch(Properties.Settings.Default.memory.ToLower()) {
				case "extendedascii": {
					MemoryExtendedASCIIButton.IsChecked = true;
					break;
				}
				case "ascii": {
					MemoryASCIIButton.IsChecked = true;
					break;
				}
				case "lettersnumbers": {
					MemoryLettersNumbersButton.IsChecked = true;
					break;
				}
				case "empty": {
					MemoryEmptyButton.IsChecked = true;
					break;
				}
			}

			switch(Properties.Settings.Default.theme.ToLower()) {
				case "light": {
					ThemeButton.Content = "Change to Dark Theme";
					break;
				}
				case "dark": {
					ThemeButton.Content = "Change to Light Theme";
					break;
				}
			}
		}

		private void ThemeButton_Click(object sender, RoutedEventArgs e) {
			switch(Properties.Settings.Default.theme.ToLower()) {
				case "dark": {
					Properties.Settings.Default.theme = "Light";
					ThemeButton.Content = "Change to Dark Theme";
					break;
				}
				default: {
					Properties.Settings.Default.theme = "Dark";
					ThemeButton.Content = "Change to Light Theme";
					break;
				}
			}

			((App)Application.Current).UpdateSkin();
		}
		private void MemoryASCIIButton_Click(object sender, RoutedEventArgs e) {
			Properties.Settings.Default.memory = "ASCII";
		}
		private void MemoryExtendedASCIIButton_Click(object sender, RoutedEventArgs e) {
			Properties.Settings.Default.memory = "ExtendedASCII";
		}
		private void MemoryLettersNumbersButton_Click(object sender, RoutedEventArgs e) {
			Properties.Settings.Default.memory = "LettersNumbers";
		}
		private void MemoryEmptyButton_Click(object sender, RoutedEventArgs e) {
			Properties.Settings.Default.memory = "Empty";
		}
	}
}
