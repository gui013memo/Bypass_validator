﻿using OpenProtocolInterpreter.Communication;
using OpenProtocolInterpreter.Job;
using OpenProtocolInterpreter.IOInterface;
using System;
using System.Windows.Forms;

namespace OpenProtocolInterpreter.Sample.Driver.Commands
{
    public class SendJobCommand
    {
        Logger logger = new Logger();

        private readonly OpenProtocolDriver _driver;

        public SendJobCommand(OpenProtocolDriver driver)
        {
            _driver = driver;
        }

        public bool Execute(bool relayOneSetReset)
        {
            var mid0200 = new Mid0200();

            if(relayOneSetReset)
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
            

            var mid = _driver.SendAndWaitForResponse(mid0200.Pack(), new TimeSpan(0, 0, 15));

            logger.Log("Pack sent: " + mid0200.Pack());

            //mid is being null
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
            logger.Log($"Job Accepted by controller!");
        }

        private void OnJobRefused(Mid0004 mid)
        {
            string str = $"Job refused by controller under error code <{(int)mid.ErrorCode}> ({mid.ErrorCode.ToString()})!";
            logger.Log(str);
            MessageBox.Show(str);
        }
    }
}