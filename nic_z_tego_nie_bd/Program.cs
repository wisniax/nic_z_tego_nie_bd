using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nic_z_tego_nie_bd
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var thread = new Thread(() => Application.Run(new MainGui()));
			thread.Name = "MainThread";
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			//new coreF();
		}
	}
}
