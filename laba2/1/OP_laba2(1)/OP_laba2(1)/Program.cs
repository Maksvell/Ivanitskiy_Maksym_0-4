using System;
using Components;

namespace OP_laba2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.StatusOfComponent();
            computer.ConnectMonitor();
            computer.ConnectSystemUnit();
            computer.ConnectMouse();
            computer.ConnectKeyboard();
            computer.StatusOfComponent();
            computer.TurnOn();
            computer.TurnOn();
            computer.TurnOff();
        }
    }
}
