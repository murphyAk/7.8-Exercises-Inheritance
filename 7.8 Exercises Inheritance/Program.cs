using System;

namespace _7._8_Exercises_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer newComp = new Computer(0001, "256 GB", true);

            Laptop newLaptop = new Laptop(0002, "128 GB", false, 100);

            SmartPhone newPhone = new SmartPhone(0003, "64 GB", false, 20);

        }
    }
}
