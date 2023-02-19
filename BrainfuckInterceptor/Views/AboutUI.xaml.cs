using System.Diagnostics;
using System.Reflection;
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
			CurrentVersionText.Text = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        }

		private void GithubButton_Click(object sender, System.Windows.RoutedEventArgs e) {
			Process.Start(new ProcessStartInfo {
				FileName = "https://github.com/Cactooz/BrainfuckConverter",
				UseShellExecute = true
			});
		}
	}
}
