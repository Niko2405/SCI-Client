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
using System.Windows.Shapes;

namespace SCI_Client
{
    /// <summary>
    /// Interaktionslogik für LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

		private void ButtonLogin_Click(object sender, RoutedEventArgs e)
		{
            DataManager.ServerIP = TextBoxServerIP.Text;
            DataManager.ServerPort = Convert.ToInt32(TextBoxServerPort.Text);
            DataManager.Username = TextBoxUsername.Text;
            DataManager.Password = PasswordBoxPassword.Password;
            DataManager.UpdateConfigFile();

            ClientSocket client = new(DataManager.ServerIP, DataManager.ServerPort);
            string response = client.SendData($"database login profile: {DataManager.Username} {DataManager.Password}");
            if (response == "database: ok")
            {
                MenuWindow menu = new MenuWindow();
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login incorrect", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
		}
	}
}
