using System.Globalization;

namespace RealSuite
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var danishCulture = new CultureInfo("da-DK");
            Thread.CurrentThread.CurrentCulture = danishCulture;
            Thread.CurrentThread.CurrentUICulture = danishCulture;

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
