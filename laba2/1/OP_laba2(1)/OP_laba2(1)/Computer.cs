using System;
using System.Collections.Generic;
using System.Text;
using Components;

namespace OP_laba2_1_
{
    class Computer
    {
        public string user;
        public Monitor monitor = new Monitor();
        public SystemUnit systemUnit = new SystemUnit();
        public Mouse mouse = new Mouse();
        public Keyboard keyboard = new Keyboard();
        public bool status;
        public Computer()
        {
            Console.WriteLine("Enter a name of user:");
            user = Console.ReadLine();
            monitor.Input();
            systemUnit.Input();
            mouse.Input();
            keyboard.Input();
            status = false;
        }
        public void TurnOn()
        {
            if (status)
                Console.WriteLine($"A computer of '{user}' is already running.");
            else
                Console.WriteLine($"A computer of '{user}' is turned on!");
            status = true;
        }
        public void TurnOff()
        {
            if (status)
                Console.WriteLine($"A computer of '{user}' is turned off!.");
            else
                Console.WriteLine($"A computer of '{user}' is already off.");
            status = false;
        }
        public void StatusOfComponent()
        {
            if (!monitor.connection) Console.WriteLine("A monitor isn't connected!");
            else Console.WriteLine("A monitor is connected.");
            if (!systemUnit.connection) Console.WriteLine("A system unit isn't connected!");
            else Console.WriteLine("A sistem unit is connected.");
            if (!mouse.connection) Console.WriteLine("A mouse isn't connected!");
            else Console.WriteLine("A mouse is connected.");
            if (!keyboard.connection) Console.WriteLine("A keyboard isn't connected!");
            else Console.WriteLine("A monitor is keyboard.");
        }
        public void ConnectMonitor()
        {
            Console.WriteLine($"A monitor '{monitor.name}' by '{monitor.maker}' is connected now");
            monitor.connection = true;
        }
        public void ConnectSystemUnit()
        {
            Console.WriteLine($"A system unit '{systemUnit.name}' by '{systemUnit.maker}' is connected now");
            systemUnit.connection = true;
        }
        public void ConnectMouse()
        {
            Console.WriteLine($"A mouse '{mouse.name}' by '{mouse.maker}' is connected now");
            mouse.connection = true;
        }
        public void ConnectKeyboard()
        {
            Console.WriteLine($"A keyboard '{keyboard.name}' by '{keyboard.maker}' is connected now");
            keyboard.connection = true;
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("Method Equals of Computer is running");
            Computer computer = obj as Computer;
            return this.GetHashCode() == computer.GetHashCode();
        }
        public override int GetHashCode()
        {
            Console.WriteLine("Method GetHashCode of Computer is running");
            return user.GetHashCode() ^ monitor.GetHashCode() ^ systemUnit.GetHashCode()
                ^ mouse.GetHashCode() ^ status.GetHashCode();
        }
        public override string ToString()
        {
            Console.WriteLine("Method ToString of Computer is running");
            return base.ToString() + ": " + user.ToString() + ": " + monitor.ToString() + ": "
                + systemUnit.ToString() + ": " + mouse.ToString() + ": " + keyboard.ToString() + ": "
                + status.ToString();
        }
    }
}
