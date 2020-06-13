using System;
using System.Collections.Generic;
using System.Text;

namespace _7._8_Exercises_Inheritance
{
    public class Laptop : Computer
    {
        public double BatteryPercent { get; set; } = 100;

        public Laptop(int ram, string hardDrive, bool needsPower, double battery) : base(ram, hardDrive, needsPower)
        {
            BatteryPercent = battery;
            needsPower = false;
        }

        public void WorkRemote()
        {
            if (BatteryPercent > 20)
            {
                Console.WriteLine($"You have {BatteryPercent / 10} hours before running out of power");
            }
            else
            {
                Console.WriteLine("Battery low, charge soon");
            }
            BatteryPercent -= 20;
        }

        public override void Connect()
        {
            BatteryPercent = 100;
        }
    }
}
