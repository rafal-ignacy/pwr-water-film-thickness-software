﻿using System;
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
        private double position;
        private double lowLimit;
        private double highLimit;
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
            {
                return position;
            }
        }
        public int Connect(string _serialNumber, string _deviceCode, double _highLimit)
        {
            serialNumber = _serialNumber;
            lowLimit = 0;
            highLimit = _highLimit;
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
            position = Convert.ToDouble(device.Position);
        }
        public void SetMoveAbsolutePosition(double position)
        {
            try
            {
                device.SetMoveAbsolutePosition(Convert.ToDecimal(position / 0.19));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " - error when attempt of setting absolute move position was made");
            }
        }
        public void MoveAbsolute()
        {
            int waitTimeout = 30000;
            try
            {
                device.MoveAbsolute(waitTimeout);
                position = Convert.ToDouble(device.Position);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " - error during absolute movement procedure");
            }
        }
    }
}