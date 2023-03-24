using System.Windows;
using System.Windows.Controls;

namespace BrainfuckInterceptor.Views {
	/// <summary>
	/// Interaction logic for SettingsUI.xaml
	/// </summary>
	public partial class SettingsUI:Page {
		public SettingsUI() {
			InitializeComponent();
		}

		private void ThemeButton_Click(object sender, RoutedEventArgs e) {
			Skin currentSkin = App.Skin;

			switch(currentSkin) {
				case Skin.Light:
				((App)Application.Current).ChangeSkin(Skin.Dark);
				ThemeButton.Content = "Change to Light Theme";
				break;
				case Skin.Dark:
				((App)Application.Current).ChangeSkin(Skin.Light);
				ThemeButton.Content = "Change to Dark Theme";
				break;
			}
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
