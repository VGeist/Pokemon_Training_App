using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon_Training_App.Views;

namespace Pokemon_Training_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static string buildErrorListMessage(string[] errors, string prompt = "Please fix the following errors:")
        {
            // build error message
            string errorMsg = prompt + Environment.NewLine;

            for (int i = 0; i < errors.Length; i++)
            {
                // add error
                errorMsg += errors[i];

                // check if there is another error
                if (i < errors.Length)
                {
                    // another error exists, put on a new line
                    errorMsg += Environment.NewLine;
                }
            }

            return errorMsg;
        }
    }
}
