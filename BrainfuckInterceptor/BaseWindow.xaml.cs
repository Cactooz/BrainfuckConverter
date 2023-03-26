using BrainfuckInterceptor.Views;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace BrainfuckInterceptor {
	/// <summary>
	/// Interaction logic for BaseWindow.xaml
	/// </summary>
	public partial class BaseWindow:Window {
		private readonly Uri converterUI = new("Views/ConverterUI.xaml", UriKind.Relative);
		private readonly Uri settingsUI = new("Views/SettingsUI.xaml", UriKind.Relative);
		private readonly Uri aboutUI = new("Views/AboutUI.xaml", UriKind.Relative);

		public BaseWindow() {
			InitializeComponent();
		}

		protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) {
			base.OnMouseLeftButtonDown(e);
			DragMove();
		}

		private void CloseButton_Click(object sender, RoutedEventArgs e) {
			File.Delete(ConverterUI.TmpFilePath);
			Properties.Settings.Default.Save();
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
