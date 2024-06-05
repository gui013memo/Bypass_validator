using OpenProtocolInterpreter.Communication;
using OpenProtocolInterpreter.Job;
using OpenProtocolInterpreter.IOInterface;
using System;
using System.Windows.Forms;

namespace OpenProtocolInterpreter.Sample.Driver.Commands
{
    public class SendCommand
    {
        Logger logger = new Logger(); 

        private readonly OpenProtocolDriver _driver;

        public SendCommand(OpenProtocolDriver driver)
        {
            _driver = driver;
        }

        public bool Execute(bool relayOneSetReset)
        {
            if(_driver.Connected)
            {
                var mid0200 = new Mid0200();

                if (relayOneSetReset)
                {
                    mid0200.StatusRelayOne = RelayStatus.On;
                    mid0200.StatusRelayTwo = RelayStatus.Off;
                    mid0200.StatusRelayThree = RelayStatus.Off;
                    mid0200.StatusRelayFour = RelayStatus.Off;
                    mid0200.StatusRelayFive = RelayStatus.Off;
                    mid0200.StatusRelaySix = RelayStatus.Off;
                    mid0200.StatusRelaySeven = RelayStatus.Off;
                    mid0200.StatusRelayEight = RelayStatus.Off;
                    mid0200.StatusRelayNine = RelayStatus.Off;
                    mid0200.StatusRelayTen = RelayStatus.Off;
                }
                else
                {
                    mid0200.StatusRelayOne = RelayStatus.Off;
                    mid0200.StatusRelayTwo = RelayStatus.Off;
                    mid0200.StatusRelayThree = RelayStatus.Off;
                    mid0200.StatusRelayFour = RelayStatus.Off;
                    mid0200.StatusRelayFive = RelayStatus.Off;
                    mid0200.StatusRelaySix = RelayStatus.Off;
                    mid0200.StatusRelaySeven = RelayStatus.Off;
                    mid0200.StatusRelayEight = RelayStatus.Off;
                    mid0200.StatusRelayNine = RelayStatus.Off;
                    mid0200.StatusRelayTen = RelayStatus.Off;
                }

                var mid = _driver.SendAndWaitForResponse(mid0200.Pack(), new TimeSpan(0, 0, 5));

               logger.Log("Pack sent: " + mid0200.Pack());

                if (mid.Header.Mid == Mid0004.MID)
                {
                    CommandRefused(mid as Mid0004);
                    return false;
                }

                CommandAccepted(mid as Mid0005);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void CommandAccepted(Mid0005 mid)
        {
            logger.Log($"Cmd Accepted by controller!");
        }

        private void CommandRefused(Mid0004 mid)
        {
            string str = $"Cmd refused by controller under error code <{(int)mid.ErrorCode}> ({mid.ErrorCode.ToString()})!";
            logger.Log(str);
            MessageBox.Show(str);
        }
    }
}