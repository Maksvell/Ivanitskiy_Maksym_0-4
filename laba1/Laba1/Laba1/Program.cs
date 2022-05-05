using System;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time();
            Time time2 = new Time("to", 10, 5, 5);
            time1.Input();
            time1.Difference(time2);
            time2.DistanceSec(4601);
            time2.DistanceMin(72);


            //string path = time1.Serializing();
            //Time time3 = new Time().Deserializing(@"E:\кпи топ\ОП\laba1\Laba1\Laba1\obj");
            //time3.Show();

            time1.Show();

            string str = JsonConvert.SerializeObject(time1);
            File.WriteAllText("E:/кпи топ/ОП/laba1/Laba1/Laba1/Data.json", str);

            string jsonstr = File.ReadAllText("E:/кпи топ/ОП/laba1/Laba1/Laba1/Data.json");
            Time t = JsonConvert.DeserializeObject<Time>(jsonstr);
            t.Show();
            Console.WriteLine(t.Name);
        }
    }
}
