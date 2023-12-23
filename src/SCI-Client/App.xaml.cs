using System.Configuration;
using System.Data;
using System.Windows;

namespace SCI_Client
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.ToString(), "Fatal Error", MessageBoxButton.OK, MessageBoxImage.Error);
			e.Handled = true;
			Environment.Exit(1);
		}

		private void Application_Startup(object sender, StartupEventArgs e)
		{
			foreach (var arg in e.Args)
			{
				#region Nur temporär
				if (arg == "--skipLogin")
				{
					//LoginWindow.IsLoginSkipped = true;
				}
				else if (arg != "--skipLogin")
				{
					//LoginWindow.IsLoginSkipped = false;
				}
				#endregion
			}
		}
	}

}
