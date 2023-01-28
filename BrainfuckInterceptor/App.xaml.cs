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

		protected override void OnStartup(StartupEventArgs e) {
			base.OnStartup(e);
			ChangeSkin(Skin.Dark);
		}

		/// <summary>
		/// Changes Program <see cref="Skin"/> to the specified <paramref name="skin"/>.
		/// </summary>
		/// <param name="skin">The name of the <see cref="Skin"/> to apply.</param>
		public void ChangeSkin(Skin skin) {
			ResourceDictionary newSkin = null;

			switch(skin) {
				case Skin.Light:
					newSkin = new ResourceDictionary{ Source = new Uri("pack://application:,,,/Content/Skins/Light.xaml") };
					break;
				case Skin.Dark:
					newSkin = new ResourceDictionary{ Source = new Uri("pack://application:,,,/Content/Skins/Dark.xaml") };
					break;
			}

			if(newSkin != null) {
				Current.Resources.MergedDictionaries.Clear();
				Current.Resources.MergedDictionaries.Add(newSkin);
				Skin = skin;
			}
		}
	}
}
