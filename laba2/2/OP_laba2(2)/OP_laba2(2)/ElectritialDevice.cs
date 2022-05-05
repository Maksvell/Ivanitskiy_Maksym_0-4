using System;
using System.Collections.Generic;
using System.Text;

namespace OP_laba2_2_
{
    abstract class ElectritialDevice
    {
        public string name;
        public int capacity;
        public bool connection;
        public ElectritialDevice()
        {
            name = "unknown";
            capacity = 1000;
            connection = false;
        }
        public ElectritialDevice(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            connection = false;
        }
        public void Input()
        {
            Console.WriteLine("Enter a name of device: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter a capacity of device: ");
            capacity = Convert.ToInt32(Console.ReadLine());
        }
        public void Switch()
        {
            if (connection)
            {
                connection = false;
                Console.WriteLine($"The device '{name}' is turned off!");
            }
            else
            {
                connection = true;
                Console.WriteLine($"The device '{name}' is turned on!");
            }
        }
        private static void Swap(ref ElectritialDevice e1, ref ElectritialDevice e2)
        {
            ElectritialDevice temp = e1;
            e1 = e2;
            e2 = temp;
        }
        public static void Sort(params ElectritialDevice[] arr)
        {
            int len = arr.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (arr[j].capacity > arr[j + 1].capacity)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            Console.WriteLine("Devices sorted by capacity:");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"{arr[i].name} : {arr[i].capacity} W");
            }
        }
        public static void InDiapasone(int min, int max, params ElectritialDevice[] arr)
        {
            Console.WriteLine($"In diapasone from {min} to {max}:");
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i].capacity >= min && arr[i].capacity <= max)
                {
                    Console.WriteLine($"{arr[i].name} with {arr[i].capacity} capacity");
                }
            }
        }

    }
}
