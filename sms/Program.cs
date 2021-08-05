using SMS.ChildForm;
using SMS.ChildForm.Popups;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
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
            string configFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SMS\\Config.ini";
            string configText = "";
            //if (File.Exists(configFilePath)) configText = File.ReadAllText(configFilePath);
            //DbOperation action = new DbOperation(true);
            //bool userExists = action.GetUsersCount();
            //if (userExists == false)
            //{
            //    Application.Run(new InitialForm());
            //}
            //else

                Application.Run(new LoginForm());
            //Application.Run(new mainForm(new UserModel() { Username = "Saransh" }));
            // Application.Run(new CompanyPopup(new UserModel() { Username = "Saransh" }));
        }
      
    }
}
