using System;
using System.Windows;
using System.Windows.Input;

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

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) {
			Close();
        }

        private void FullscreenButton_Click(object sender, RoutedEventArgs e) {
			switch(WindowState) {
				case WindowState.Normal:
                    ResizeMode = ResizeMode.NoResize;
                    WindowState = WindowState.Maximized;
                    break;
				case WindowState.Maximized:
                    ResizeMode = ResizeMode.CanResizeWithGrip;
                    WindowState = WindowState.Normal;
					break;
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e) {
            WindowState = WindowState.Minimized;
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
