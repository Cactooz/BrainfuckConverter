using System;
using System.Windows;

namespace BrainfuckInterceptor {
	/// <summary>
	/// Interaction logic for ConverterGUI.xaml
	/// </summary>
	public partial class ConverterGUI:Window {

		Uri converterUI = new Uri("Views/ConverterUI.xaml", UriKind.Relative);
        Uri settingsUI = new Uri("Views/SettingsUI.xaml", UriKind.Relative);
        Uri aboutUI = new Uri("Views/AboutUI.xaml", UriKind.Relative);

		public ConverterGUI() {
			InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) {
			Close();
        }

        private void FullscreenButton_Click(object sender, RoutedEventArgs e) {
			switch(WindowState) {
				case WindowState.Normal:
					WindowState = WindowState.Maximized;
					break;
				case WindowState.Maximized:
					WindowState = WindowState.Normal;
					break;
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e) {
            WindowState = WindowState.Minimized;
        }

        private void ThemeButton_Click(object sender, RoutedEventArgs e) {
            Skin currentSkin = App.Skin;

            switch(currentSkin) {
                case Skin.Light:
                ((App)Application.Current).ChangeSkin(Skin.Dark);
                break;
                case Skin.Dark:
                ((App)Application.Current).ChangeSkin(Skin.Light);
                break;
            }
        }

        private void ConverterButton_Click(object sender, RoutedEventArgs e) {
            ViewFrame.Source = converterUI;
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e) {
            ViewFrame.Source = settingsUI;
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e) {
            ViewFrame.Source = aboutUI;
        }
    }
}
