using System;
using System.Collections.Generic;
using System.Text;

namespace Components
{

    class Monitor
    {
        public string name;
        public int diagonal;
        public string maker;
        public bool connection;
        public Monitor()
        {
            name = "unknown";
            diagonal = 12;
            maker = "HP";
            connection = false;
        }
        public Monitor(string name, int diagonal, string maker)
        {
            this.name = name;
            this.diagonal = diagonal;
            this.maker = maker;
            connection = false;
        }
        public void Input()
        {
            Console.WriteLine("Enter a name of monitor:");
            name = Console.ReadLine();
            Console.WriteLine("Enter a diagonal of monitor:");
            diagonal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maker of monitor:");
            maker = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"Monitor is named '{name}', has type {diagonal} and made by '{maker}'");
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("Method Equals of Monitor is running");
            Monitor monitor = obj as Monitor;
            return this.name == monitor.name;
        }
        public override int GetHashCode()
        {
            Console.WriteLine("Method GetHashCode of Monitor is running");
            return name.GetHashCode() ^ diagonal.GetHashCode() ^ maker.GetHashCode() ^ connection.GetHashCode();
        }
        public override string ToString()
        {
            Console.WriteLine("Method ToString of Monitor is running");
            return base.ToString() + ": " + name.ToString() + ": " + diagonal.ToString() + ": " + maker.ToString();
        }
    }


    class SystemUnit
    {
        public string name;
        public string maker;
        public bool connection;
        public SystemUnit()
        {
            name = "unknown";
            maker = "HP";
            connection = false;
        }
        public SystemUnit(string name, int diagonal, string maker)
        {
            this.name = name;
            this.maker = maker;
            connection = false;
        }
        public void Output()
        {
            Console.WriteLine($"System unit is named '{name}' and made by '{maker}'");
        }
        public void Input()
        {
            Console.WriteLine("Enter a name of system unit:");
            name = Console.ReadLine();
            Console.WriteLine("Enter a maker of system unit:");
            maker = Console.ReadLine();
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("Method Equals of SystemUnit is running");
            SystemUnit systemUnit = obj as SystemUnit;
            return this.name == systemUnit.name;
        }
        public override int GetHashCode()
        {
            Console.WriteLine("Method GetHashCode of SystemUnit is running");
            return name.GetHashCode() ^ maker.GetHashCode() ^ connection.GetHashCode();
        }
        public override string ToString()
        {
            Console.WriteLine("Method ToString of Monitor is running");
            return base.ToString() + ": " + name.ToString() + ": " + maker.ToString();
        }
    }


    class Mouse
    {
        public string name;
        public int dpi;
        public string maker;
        public bool connection;
        public Mouse()
        {
            name = "unknown";
            dpi = 1200;
            maker = "HP";
            connection = false;
        }
        public Mouse(string name, int dpi, string maker)
        {
            this.name = name;
            this.dpi = dpi;
            this.maker = maker;
            connection = false;
        }
        public void Output()
        {
            Console.WriteLine($"Mouse is named '{name}', has dpi {dpi} and made by '{maker}'");
        }
        public void Input()
        {
            Console.WriteLine("Enter a name of mouse:");
            name = Console.ReadLine();
            Console.WriteLine("Enter a dpi of mouse:");
            dpi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maker of mouse:");
            maker = Console.ReadLine();
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("Method Equals of Mouse is running");
            Mouse mouse = obj as Mouse;
            return this.name == mouse.name;
        }
        public override int GetHashCode()
        {
            Console.WriteLine("Method GetHashCode of Mouse is running");
            return name.GetHashCode() ^ dpi.GetHashCode() ^ maker.GetHashCode() ^ connection.GetHashCode();
        }
        public override string ToString()
        {
            Console.WriteLine("Method ToString of Monitor is running");
            return base.ToString() + ": " + name.ToString() + ": " + dpi.ToString() + ": " + maker.ToString();
        }
    }


    class Keyboard
    {
        public string name;
        public string type;
        public string maker;
        public bool connection;
        public Keyboard()
        {
            name = "unknown";
            type = "mechanical";
            maker = "HP";
            connection = false;
        }
        public Keyboard(string name, string type, string maker)
        {
            this.name = name;
            this.type = type;
            this.maker = maker;
            connection = false;
        }
        public void Output()
        {
            Console.WriteLine($"Monitor is named '{name}', has type {type} and made by '{maker}'");
        }
        public void Input()
        {
            Console.WriteLine("Enter a name of keyboard:");
            name = Console.ReadLine();
            Console.WriteLine("Enter a type of keyboard:");
            type = Console.ReadLine();
            Console.WriteLine("Enter a maker of keyboard:");
            maker = Console.ReadLine();
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("Method Equals of Keyboard is running");
            Keyboard keyboard = obj as Keyboard;
            return this.name == keyboard.name;
        }
        public override int GetHashCode()
        {
            Console.WriteLine("Method GetHashCode of Keyboard is running");
            return name.GetHashCode() ^ type.GetHashCode() ^ maker.GetHashCode() ^ connection.GetHashCode();
        }
        public override string ToString()
        {
            Console.WriteLine("Method ToString of Monitor is running");
            return base.ToString() + ": " + name.ToString() + ": " + type.ToString() + ": " + maker.ToString();
        }
    }
}
