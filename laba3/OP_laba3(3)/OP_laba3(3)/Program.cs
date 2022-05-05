using System;
using System.Linq;


namespace OP_laba3_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 6;
            string[] list = {"3sadna", "askld", "sdfnls", "7aksdj", "gmlkd"};

            string str = list.LastOrDefault(s => (s.Length == len && s[0] > 47 && s[0] < 58)/*, "Not found"*/);
            Console.WriteLine(str);
            
        }
    }
}
