using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenProtocolInterpreter.Sample
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

            SplashScreenForm splashScreen = new SplashScreenForm();
            splashScreen.Show();
            splashScreen.ShadeEffectTimer.Start();
            splashScreen.Refresh();

            while (!splashScreen.introDone)
            {
                
            }

            Application.Run(new DriverForm());
        }
    }
}
