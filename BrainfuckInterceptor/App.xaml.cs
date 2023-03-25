using System;
using System.Windows;

namespace BrainfuckInterceptor {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App:Application {
		private ResourceDictionary darkSkin;
		private ResourceDictionary lightSkin;
		private ResourceDictionary currentSkin;

		protected override void OnStartup(StartupEventArgs e) {
			base.OnStartup(e);
			Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("pack://application:,,,/Content/Styling.xaml") });
			darkSkin = new ResourceDictionary { Source = new Uri("pack://application:,,,/Content/Skins/Dark.xaml") };
			lightSkin = new ResourceDictionary { Source = new Uri("pack://application:,,,/Content/Skins/Light.xaml") };

			switch(BrainfuckInterceptor.Properties.Settings.Default.theme.ToLower()) {
				case "light": {
					currentSkin = lightSkin;
					break;
				}
				default: {
					currentSkin = darkSkin;
					break;
				}
			}

			UpdateSkin();
		}

		/// <summary>
		/// Changes Program <see cref="Skin"/> to the specified <paramref name="skin"/>.
		/// </summary>
		public void UpdateSkin() {
			ResourceDictionary oldSkin = null;

			switch(BrainfuckInterceptor.Properties.Settings.Default.theme.ToLower()) {
				case "light": {
					oldSkin = currentSkin;
					currentSkin = lightSkin;
					break;
				}
				case "dark": {
					oldSkin = currentSkin;
					currentSkin = darkSkin;
					break;
				}
			}

			if(currentSkin != null) {
				Current.Resources.MergedDictionaries.Remove(oldSkin);
				Current.Resources.MergedDictionaries.Add(currentSkin);
			}
		}
	}
}
