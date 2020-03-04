using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Renamer
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var lang = MainForm.GetConfigString("Lang", "EN");
			if (lang == "CN") {
				Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
			}
			Application.Run(new MainForm());
		}
	}
}