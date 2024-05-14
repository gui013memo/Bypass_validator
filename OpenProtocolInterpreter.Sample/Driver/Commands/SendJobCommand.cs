using OpenProtocolInterpreter.Communication;
using OpenProtocolInterpreter.Job;
using OpenProtocolInterpreter.IOInterface;
using System;
using System.Windows.Forms;

namespace OpenProtocolInterpreter.Sample.Driver.Commands
{
    public class SendJobCommand
    {
        private readonly OpenProtocolDriver _driver;

        public SendJobCommand(OpenProtocolDriver driver)
        {
            _driver = driver;
        }

        public bool Execute(int jobId)
        {
            Console.WriteLine($"Sending job <{jobId}> to controller!");
            var mid0200 =  new Mid0200();

            mid0200.StatusRelayOne = RelayStatus.On;
            mid0200.StatusRelayTwo = RelayStatus.On;
            mid0200.StatusRelayThree = RelayStatus.On;
            mid0200.StatusRelayFour = RelayStatus.On;
            mid0200.StatusRelayFive = RelayStatus.On;
            mid0200.StatusRelaySix = RelayStatus.On;
            mid0200.StatusRelaySeven = RelayStatus.On;
            mid0200.StatusRelayEight = RelayStatus.On;
            mid0200.StatusRelayNine = RelayStatus.On;
            mid0200.StatusRelayTen = RelayStatus.On;

            



            var mid = _driver.SendAndWaitForResponse(mid0200.Pack(), new TimeSpan(0, 0, 10));

            if (mid.Header.Mid == Mid0004.MID)
            {
                OnJobRefused(mid as Mid0004);
                return false;
            }

            OnJobAccepted(mid as Mid0005);
            return true;
        }

        private void OnJobAccepted(Mid0005 mid)
        {
            MessageBox.Show($"Job Accepted by controller!");
        }

        private void OnJobRefused(Mid0004 mid)
        {
            MessageBox.Show($"Job refused by controller under error code <{(int)mid.ErrorCode}> ({mid.ErrorCode.ToString()})!");
        }
    }
}