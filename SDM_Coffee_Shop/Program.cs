using System;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            FileManager manager = new FileManager();
            FileReaderWriter readerWriter = new FileReaderWriter();
            manager.CreateFile(readerWriter.PATH_LOG_ORDERS);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}