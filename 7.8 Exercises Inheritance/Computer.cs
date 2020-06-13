using System;
using System.Collections.Generic;
using System.Text;

namespace _7._8_Exercises_Inheritance
{
    public class Computer : AbstractEntity
    {
        public int IMEI { get; set; }
        public string HardDrive { get; set; }
        public bool NeedsPower { get; set; } = true;

        public Computer(int imei, string hardDrive, bool needsPower)
        {
            IMEI = imei;
            HardDrive = hardDrive;
            NeedsPower = needsPower;
        }

        public virtual void ReadDeviceID()
        {
            Console.WriteLine(IMEI);
        }

        public virtual void Connect()
        {
            NeedsPower = false;
        }

        public void Disconnect()
        {
            NeedsPower = true;
        }
    }
}
