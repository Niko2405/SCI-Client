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
	/// Interaktionslogik für ServerDatabase.xaml
	/// </summary>
	public partial class ServerDatabase : UserControl
	{
		public ServerDatabase()
		{
			InitializeComponent();
			List<DatabaseUsers> users = new List<DatabaseUsers>();

			ClientSocket client = new ClientSocket("127.0.0.1", 8080);
			string response = client.SendData("database get profile: root").Replace("\r", "");
			string[] data = response.Split("\n");
			users.Add(new DatabaseUsers() { Id = Convert.ToInt16(data[0]), Username = data[1], Password = data[2], Permission = data[3], Birthday = data[4], Country = data[5], State = data[6], Age = Convert.ToInt32(data[7]), Locked = Convert.ToInt32(data[8])});
			DataGridUsers.ItemsSource = users;
		}
	}
	public class DatabaseUsers
	{
		public required int Id { get; set; }
		public required string Username { get; set; }
		public required string Password { get; set; }
		public required string Permission { get; set; }
		public required string Birthday { get; set; }
		public required string Country { get; set; }
		public required string State { get; set; }
		public required int Age { get; set; }
		public required int Locked { get; set; }
	}
}
