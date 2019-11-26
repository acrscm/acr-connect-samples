using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Acr.Connect.Samples.WinForms.RefreshToken
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            Application.ThreadException += Application_ThreadException;
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            using (var log = File.OpenWrite("Error.log"))
            {
                var writer = new StreamWriter(log);

                writer.WriteLine($"{DateTime.Now}: {e}");
            }
        }
    }
}
