using System;
using System.Collections.Generic;
using System.Text;
using OP_laba2_2_;

namespace Devices
{
    class TV : ElectritialDevice
    {
        public TV() : base() { }
        public TV(string name, int capacity) : base(name, capacity) { }

    }
    class Computer : ElectritialDevice
    {
        public Computer() : base() { }
        public Computer(string name, int capacity) : base(name, capacity) { }

    }
    class Fridge : ElectritialDevice
    {
        public Fridge() : base() { }
        public Fridge(string name, int capacity) : base(name, capacity) { }

    }
    class Microwave : ElectritialDevice
    {
        public Microwave() : base() { }
        public Microwave(string name, int capacity) : base(name, capacity) { }

    }

}
