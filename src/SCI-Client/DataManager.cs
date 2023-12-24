using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCI_Client
{
	/// <summary>
	/// Main manager to store datas and write into a config file
	/// </summary>
    class DataManager
    {
        private static string _serverIP = "127.0.0.1";
        private static int _serverPort = 8080;
        private static string _username = "user";
        private static string _password = "user";

		/// <summary>
		/// Server Address
		/// </summary>
        public static string ServerIP
        {
            get
            {
                return _serverIP;
            }
            set
            {
                _serverIP = value;
            }
        }
		/// <summary>
		/// Server Port
		/// </summary>
        public static int ServerPort
		{
			get
			{
				return _serverPort;
			}
			set
			{
				_serverPort = value;
			}
		}
		/// <summary>
		/// Current username
		/// </summary>
		public static string Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
			}
		}
		/// <summary>
		/// Current password. HINT: Remove in the future
		/// </summary>
		public static string Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
			}
		}
		/// <summary>
		/// Write current datas into a config file
		/// </summary>
		public static void UpdateConfigFile()
		{
			string datas = $"SERVER_IP={ServerIP}\nSERVER_PORT={ServerPort}\nUSERNAME={Username}\nPASSWORD={Password}";
			try
			{
				System.IO.File.WriteAllText("settings.conf", datas);
				Debug.WriteLine("config updated");
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
