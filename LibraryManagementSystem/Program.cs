using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
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
            Application.Run(new LoginForm());
            //string sourcePath = @"C:\\PROGRAM FILES\Tivrasoft\LMS";
            //string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //string fileName = "LibraryDatabase.mdf";
            //System.IO.File.Copy(sourcePath + "\\" + fileName, appDataPath + "\\" + fileName, false);
        }
    }
}
