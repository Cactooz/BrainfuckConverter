using System.Diagnostics;
using System.Windows.Controls;

namespace BrainfuckInterceptor.Views
{
	/// <summary>
	/// Interaction logic for AboutUI.xaml
	/// </summary>
	public partial class AboutUI : Page
	{
		public AboutUI()
		{
			InitializeComponent();
		}

		private void GithubButton_Click(object sender, System.Windows.RoutedEventArgs e) {
			Process.Start(new ProcessStartInfo {
				FileName = "https://github.com/Cactooz/BrainfuckConverter",
				UseShellExecute = true
			});
		}
	}
}
