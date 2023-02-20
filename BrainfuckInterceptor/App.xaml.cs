using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BrainfuckInterceptor {
	/// <summary>
	/// Available skins for the whole program.
	/// </summary>
	public enum Skin { Light, Dark }

	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App:Application {
		public static Skin Skin { get; set; }

		private ResourceDictionary darkSkin;
		private ResourceDictionary lightSkin;
		private ResourceDictionary currentSkin;

        protected override void OnStartup(StartupEventArgs e) {
			base.OnStartup(e);
            Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("pack://application:,,,/Content/Styling.xaml") });
			darkSkin = new ResourceDictionary { Source = new Uri("pack://application:,,,/Content/Skins/Dark.xaml") };
			lightSkin = new ResourceDictionary { Source = new Uri("pack://application:,,,/Content/Skins/Light.xaml") };

            currentSkin = darkSkin;
            ChangeSkin(Skin.Dark);
        }

		/// <summary>
		/// Changes Program <see cref="Skin"/> to the specified <paramref name="skin"/>.
		/// </summary>
		/// <param name="skin">The name of the <see cref="Skin"/> to apply.</param>
		public void ChangeSkin(Skin skin) {
			ResourceDictionary oldSkin = null;

			switch(skin) {
				case Skin.Light:
					oldSkin = currentSkin;
					currentSkin = lightSkin;
					break;
				case Skin.Dark:
					oldSkin = currentSkin;
					currentSkin = darkSkin;
					break;
			}

			if(currentSkin != null) {
				Current.Resources.MergedDictionaries.Remove(oldSkin);
				Current.Resources.MergedDictionaries.Add(currentSkin);
				Skin = skin;
			}
		}
	}
}
