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
using ClassLibrary;

namespace WpfApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var name = textbox1.Text;

			if (string.IsNullOrEmpty(name) || name.Any(char.IsDigit))
			{
				MessageBox.Show("Sorry...But I just asked to enter the name. Enter the correct name.");
			}
			else
			{
				var currentTime = Time.GetCurrentTime();
				MessageBox.Show($"{currentTime} Hello, {name}!");
			}
		}
	}
}
