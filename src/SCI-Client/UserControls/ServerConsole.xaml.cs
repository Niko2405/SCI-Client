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

namespace SCI_Client.UserControls
{
    /// <summary>
    /// Interaktionslogik für ServerConsole.xaml
    /// </summary>
    public partial class ServerConsole : UserControl
    {
        public ServerConsole()
        {
            InitializeComponent();
        }

		private void ButtonSend_Click(object sender, RoutedEventArgs e)
		{
            ClientSocket client = new ClientSocket("127.0.0.1", 8080);
            TextBlock_Output.Text += client.SendData(TextBox_Input.Text);
            TextBox_Input.Clear();
        }
    }
}
