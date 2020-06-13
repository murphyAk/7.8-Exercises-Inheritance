using System;
using System.Collections.Generic;
using System.Text;

namespace _7._8_Exercises_Inheritance
{
    public class SmartPhone : Computer
    {
        public string Camera { get; }
        public int NumPicture { get; set; } = 0;

        public SmartPhone(int ram, string hardDrive, bool needsPower, int numPicture) : base(ram, hardDrive, needsPower)
        {
            NumPicture = numPicture;
        }

        public void TakePicture()
        {
            Console.WriteLine("click");
            NumPicture++;
        }
    }
}
