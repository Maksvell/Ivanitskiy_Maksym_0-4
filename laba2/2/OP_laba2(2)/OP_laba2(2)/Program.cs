using System;
using Devices;

namespace OP_laba2_2_
{
    class Program
    {
        static void Main(string[] args)
        {

            TV tv = new TV();
            Computer computer = new Computer();
            Fridge fridge = new Fridge();
            Microwave microwave = new Microwave();
            tv.Input();
            computer.Input();
            fridge.Input();
            microwave.Input();
            ElectritialDevice.Sort(tv, computer, fridge, microwave);
            ElectritialDevice.InDiapasone(1000, 2000, tv, computer, fridge, microwave);

        }
    }
}
