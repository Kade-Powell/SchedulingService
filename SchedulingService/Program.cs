using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace SchedulingService
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		static ApplicationContext MainContext = new ApplicationContext();
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainContext.MainForm = new LoginForm();
			Application.Run(MainContext);
		}


		public static void SetMainForm(Form MainForm)
		{
			MainContext.MainForm = MainForm;
		}

		public static void ShowMainForm()
		{
			MainContext.MainForm.Show();
		}
	}
}
