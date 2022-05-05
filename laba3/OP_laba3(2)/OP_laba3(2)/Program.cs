using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace OP_laba3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 9;
            var sth = new Dictionary<int, string>()
            {
                {10, "sth1" },
                {7, "sth2" },
                {13, "sth3" },
                {5, "sth4" }
            };
            var dic = new Dictionary<int, string>();
            foreach(KeyValuePair<int, string> el in sth)
            {
                if(el.Key > value)
                {
                    dic.Add(el.Key, el.Value);
                }
            }
            //foreach (KeyValuePair<int, string> el in dic)
            string str = JsonConvert.SerializeObject(dic);
            File.WriteAllText(@"E:\кпи топ\ОП\laba3\OP_laba3(2)\OP_laba3(2)\Data.json", str);
        
        }
    }
}
