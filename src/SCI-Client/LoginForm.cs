using System.Diagnostics;

namespace SCI_Client
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			System.Environment.Exit(0);
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			string serverAddress = textBoxServerAddress.Text;
			string username = textBoxUsername.Text;
			string password = textBoxPassword.Text;
			Debug.WriteLine($"Login:\nServer Address:\t{serverAddress}\nUsername:\t\t{username}\nPassword:\t\t{password}");

			string encryptedText = Crypt.Encrypt("Das ist ein Test mein Freund :D", Crypt.CreateKey("Test"));
			Debug.WriteLine(encryptedText);

			string decryptedText = Crypt.Decrypt(encryptedText, Crypt.CreateKey("Test"));
			Debug.WriteLine(decryptedText);
			ClientSocket.IsLockedIn = true;

			this.Close();
		}
	}
}
