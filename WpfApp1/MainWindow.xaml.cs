using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();

            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String hex = HEX.Text;
			String ans = hexStringToRGB(hex);
			RGB.Text = ans;
        }

		public static string hexStringToRGB(String hex)
		{
			string array = hex.ToLower();
			string rs = array.Substring(1, 1);
			string rss = array.Substring(2, 1);
			string gs = array.Substring(3, 1);
			string gss = array.Substring(4, 1);
			string bs = array.Substring(5, 1);
			string bss = array.Substring(6, 1);
			string[] arr = new string[6];
			arr[0] = rs;
			arr[1] = rss;
			arr[2] = gs;
			arr[3] = gss;
			arr[4] = bs;
			arr[5] = bss;
			Console.WriteLine(array);
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
				switch (arr[i])
				{
					case "a":
						arr[i] = "10";
						break;
					case "b":
						arr[i] = "11";
						break;
					case "c":
						arr[i] = "12";
						break;
					case "d":
						arr[i] = "13";
						break;
					case "e":
						arr[i] = "14";
						break;
					case "f":
						arr[i] = "15";
						break;
				}
			}
			Console.WriteLine("===========");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
			int ri = Int32.Parse(arr[0]);
			int rii = Int32.Parse(arr[1]);
			int gi = Int32.Parse(arr[2]);
			int gii = Int32.Parse(arr[3]);
			int bi = Int32.Parse(arr[4]);
			int bii = Int32.Parse(arr[5]);
			Console.WriteLine("===========");
			int r = ri * 16 + rii;
			int g = gi * 16 + gii;
			int b = bi * 16 + bii;
			Console.WriteLine(r);
			Console.WriteLine(g);
			Console.WriteLine(b);
			return "(" + r + ", " + g + ", " + b + ")";
		}
	}
}
