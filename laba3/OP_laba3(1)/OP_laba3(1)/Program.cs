using System;
using System.Collections.Generic;
using System.Linq;

namespace OP_laba3_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //n = Convert.ToInt32(Console.ReadLine());
            List<string> poem = new List<string>
            {
                "Мені тринадцятий минало, мені купили жигулі,",
                "Мені так любо любо стало, що я заїхав у таксі,",
                "Мене міліція шукає, а я сиджу у гаражі,",
                "Останю пляшку допиваю і ремонтую жигулі."
            };
            /*for(int i = 0; i < n; i++)
            {
                poem.Add(Console.ReadLine()); ;
            }*/
            var sortedPoem = from p in poem
                             orderby p.Length
                             select p;
            foreach(var line in sortedPoem)
            {
                Console.WriteLine(line);
            }
        }
    }
}
