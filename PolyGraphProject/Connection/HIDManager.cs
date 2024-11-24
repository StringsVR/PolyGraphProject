using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HidSharp;

namespace PolyGraphProject.Connection
{

    public class HIDManager
    {
        //Initialize HID Manager with vid and pid
        public HIDManager(int pid, int vid)
        {
            if (pid <= 0 || vid <= 0)
                throw new ArgumentException("PID and VID must be positive integers.");
            this.pid = pid;
            this.vid = vid;
        }
        
        //Tries to connect to HID Device with pid and hid specified in initalization
        public bool connect()
        {
            try
            {
                //Grabs device list of HID Devices on your local PC
                var deviceList = DeviceList.Local;

                //Sets the device field by searching for HID Devices with the pid and hid
                device = deviceList.GetHidDevices().FirstOrDefault(d => d.VendorID == this.vid && d.ProductID == this.pid);
                //Checks to make sure it ain't null
                if (device == null)
                {
                    Console.WriteLine("HID Device Not Found.");
                    return false;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            Console.WriteLine($"Device found: {device.ProductID}");
            return true;
        }

        public bool disconnect()
        {
            //Sets device back to null and sends true for completion don't even need a try catch.
            device = null;
            return true;
        }

        private HidDevice device { get; set; }
        private protected int vid { get; private set; }
        private protected int pid { get; private set; }
    }
}
