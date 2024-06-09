using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenProtocolInterpreter.Sample
{
    public partial class SplashScreenForm : Form
    {
        private ManualResetEvent splashCompletedEvent;

        public SplashScreenForm(ManualResetEvent splashCompletedEvent)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(SetRoundedRegion);
            this.Opacity = 0;
            this.splashCompletedEvent = splashCompletedEvent;
        }

        private void SetRoundedRegion(object sender, PaintEventArgs e)
        {
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), -90, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        private void ShadeEffectTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.10;
            else
            {
                ShadeEffectTimer.Stop();
                Task.Delay(1000).ContinueWith(t => CloseSplashScreen());
            }
        }

        public void StartShadeEffect()
        {
            ShadeEffectTimer.Start();
        }

        private void CloseSplashScreen()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CloseSplashScreen));
                return;
            }

            splashCompletedEvent.Set(); // Signal that the splash screen has completed
            Close();
        }
    }
}
