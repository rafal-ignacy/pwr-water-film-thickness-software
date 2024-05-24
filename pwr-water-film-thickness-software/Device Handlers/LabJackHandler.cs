using System;
using System.Collections.Generic;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.IntegratedStepperMotorsCLI;
using Thorlabs.MotionControl.GenericMotorCLI.Settings;
using System.Threading;

namespace pwr_water_film_thickness_software.DeviceHandlers
{
    internal class LabJackHandler
    {
        private LabJack device;
        private string serialNumber;
        private string deviceCode;
        private bool isConnected;
        public LabJackHandler()
        {
            SimulationManager.Instance.InitializeSimulations(); // simulation enabler
            isConnected = false;
        }
        public bool IsConnected
        {
            get
            {
                return isConnected;
            }
        }
        public double Position
        {
            get
            {   if (this.serialNumber == "46000001")
                {
                    return Math.Round(0.19 * Convert.ToDouble(device.Position), 3);
                }
                else
                {
                    return Math.Round(Convert.ToDouble(device.Position), 3);
                }
            }
        }
        public int Connect(string _serialNumber, string _deviceCode)
        {
            serialNumber = _serialNumber;
            deviceCode = _deviceCode;
            List<string> deviceList;

            try
            {
                DeviceManagerCLI.BuildDeviceList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - error when building device list");
            }

            deviceList = DeviceManagerCLI.GetDeviceList();
            if (!deviceList.Contains(serialNumber))
            {
                throw new Exception("There is no connected device with serial number - " + serialNumber);
            }

            device = LabJack.CreateLabJack(serialNumber);
            if (device == null)
            {
                throw new Exception("Error occured when LabJack object was being created");
            }
            device.Connect(serialNumber);
            if (!device.IsSettingsInitialized())
            {
                device.WaitForSettingsInitialized(10000);
            }

            MotorConfiguration motorConfiguration = device.LoadMotorConfiguration(serialNumber);

            int pollingRate = 250;
            device.StartPolling(pollingRate);

            Thread.Sleep(250);
            device.EnableDevice();
            Thread.Sleep(250);

            isConnected = true;

            return deviceList.Count;
        }
        public void Disconnect()
        {
            try
            {
                device.StopPolling();
                device.ShutDown();
                isConnected = false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " - cannot handle lab jack disconnection");
            }
        }
        public void Home()
        {
            int waitTimeout = 900000;
            try
            {
                device.Home(waitTimeout);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " - error during lab jack homing procedure");
            }
        }
        public void SetMoveAbsolutePosition(double position)
        {
            try
            {
                if (this.serialNumber == "46000001")
                {
                    device.SetMoveAbsolutePosition(Convert.ToDecimal(position / 0.19));
                }
                else
                {
                    device.SetMoveAbsolutePosition(Convert.ToDecimal(position));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " - error when attempt of setting absolute move position was made");
            }
        }
        public void MoveAbsolute()
        {
            int waitTimeout = 1200000;
            try
            {
                device.MoveAbsolute(waitTimeout);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " - error during absolute movement procedure");
            }
        }
    }
}
