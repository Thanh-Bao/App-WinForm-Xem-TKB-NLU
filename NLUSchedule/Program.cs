using NLUSchedule.checkUser;
using NLUSchedule.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLUSchedule
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
            if (!Utility.CheckForInternetConnection())
            {
                Application.Run(new CheckInternet());
            }
            Application.Run(new MainForm());
           
        }
    }
}
