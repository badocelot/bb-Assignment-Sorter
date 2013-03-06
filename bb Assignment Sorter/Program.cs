using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bb_Assignment_Sorter
{
    static class Program
    {
        public static string[] folders = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments)
        {
            // Allow for invocation through arguments
            if (arguments.Length > 0)
            {
                folders = new string[arguments.Length];
                arguments.CopyTo(folders, 0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
