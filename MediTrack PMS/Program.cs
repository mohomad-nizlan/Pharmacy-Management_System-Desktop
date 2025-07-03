using System;
using System.Windows.Forms;

namespace MediTrack_PMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable high-DPI support for better rendering on modern displays
            if (Environment.OSVersion.Version.Major >= 6) // Windows Vista or later
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // Import the SetProcessDPIAware function from user32.dll
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}