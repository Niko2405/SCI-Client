using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SCI_Client
{
	/// <summary>
	/// Interaction logic for MenuWindow.xaml
	/// </summary>
	public partial class MenuWindow : Window
	{
		public MenuWindow()
		{
			InitializeComponent();
		}

		private void MenuItemClose_Click(object sender, RoutedEventArgs e)
		{
			System.Environment.Exit(0);
        }
    }
}