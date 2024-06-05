using System;
using System.Threading;
using System.Windows.Forms;

namespace OpenProtocolInterpreter.Sample
{
    static class Program
    {
        private static ManualResetEvent splashCompletedEvent;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashCompletedEvent = new ManualResetEvent(false);
            Thread splashThread = new Thread(new ThreadStart(ShowSplashScreen));
            splashThread.Start();

            splashCompletedEvent.WaitOne();

            Application.Run(new DriverForm());
        }

        static void ShowSplashScreen()
        {
            SplashScreenForm splashScreen = new SplashScreenForm(splashCompletedEvent);
            splashScreen.Load += (s, e) => splashScreen.StartShadeEffect();
            Application.Run(splashScreen);
        }
    }
}
