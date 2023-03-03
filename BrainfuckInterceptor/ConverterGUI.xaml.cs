using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;

namespace BrainfuckInterceptor {
	/// <summary>
	/// Interaction logic for ConverterGUI.xaml
	/// </summary>
	public partial class ConverterGUI:Window {

		private Uri converterUI = new Uri("Views/ConverterUI.xaml", UriKind.Relative);
		private Uri settingsUI = new Uri("Views/SettingsUI.xaml", UriKind.Relative);
		private Uri aboutUI = new Uri("Views/AboutUI.xaml", UriKind.Relative);

		public ConverterGUI() {
			InitializeComponent();
		}

		/*protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) {
			base.OnMouseLeftButtonDown(e);
			DragMove();
		}*/

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

		private void ResizeMove(object sender, MouseEventArgs e) {
			bool resizing = e.LeftButton == MouseButtonState.Pressed;
			Rectangle senderRectangle = sender as Rectangle;

			if(resizing) {
				Window window = senderRectangle.Tag as Window;

				if(senderRectangle != null) {
					Point pos = e.GetPosition(window);
					senderRectangle.CaptureMouse();

					if(senderRectangle.Name.ToLower().Contains("right")) {
						pos.X += 3;
						if(pos.X > 0)
							window.Width = pos.X;
					} else if(senderRectangle.Name.ToLower().Contains("left")) {
						pos.X -= 3;
						if(pos.X < 0 || window.Width > window.MinWidth) {
							window.Left += pos.X;
							pos.X = window.Width - pos.X;
							if(pos.X > 0)
								window.Width = pos.X;
						}
					}

					if(senderRectangle.Name.ToLower().Contains("bottom")) {
						pos.Y += 3;
						if(pos.Y > 0)
							window.Height = pos.Y;
					} else if(senderRectangle.Name.ToLower().Contains("top")) {
						pos.Y -= 3;
						if(pos.Y < 0 || window.Height > window.MinHeight) {
							window.Top += pos.Y;
							pos.Y = window.Height - pos.Y;
							if(pos.Y > 0)
								window.Height = pos.Y;
						}
					}
				}
			} else
				senderRectangle.ReleaseMouseCapture();
		}
	}
}
