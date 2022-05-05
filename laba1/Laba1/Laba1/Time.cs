using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Text;


namespace Laba1
{
    class Time
    {
       
        public string Name { private set; get; }
        public int Hour { private set; get; }
        public int Min { private set; get; }
        public int Sec { private set; get; }
        public Time()
        {
            Name = "untitled";
            Hour = 11;
            Min = 11;
            Sec = 11;
        }
        public Time(string name, int hour, int min, int sec)
        {
            Name = name; Hour = hour; Min = min; Sec = sec;
        }
        public void Input()
        {
            Console.WriteLine("Введіть підпис часу: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введіть години: ");
            Hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть хвилини: ");
            Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть секунди: ");
            Sec = Convert.ToInt32(Console.ReadLine());
            if (Sec >= 60)
            {
                Min += Sec / 60;
                Sec = Sec % 60;
            }
            if (Min >= 60)
            {
                Hour += Min / 60;
                Min = Min % 60;
            }
        }
        public void Show()
        {
            Console.WriteLine($"{Name} - {Hour}:{Min}:{Sec}");
        }
        public void Difference(Time time)
        {
            int dif = Math.Abs((time.Hour - Hour) * 3600 + (time.Min - Min) * 60 + (time.Sec - Sec));
            Console.WriteLine($"Difference between {Name} and {time.Name} is {dif} sec");
        }
        public void DistanceSec(int sec)
        {
            int dif_sec = sec % 60, dif_min = (sec % 3600) / 60, dif_hour = sec / 3600;
            int min_sec = dif_sec, min_min = dif_min, min_hour = dif_hour;
            if(min_sec > Sec)
            {
                min_min++;
                min_sec -= 60;
            }
            if(min_min > Min)
            {
                min_hour++;
                min_min -= 60;
            }
            Console.WriteLine($"Time removed by {sec} seconds from '{Name}' is - " +
                $"{Hour + dif_hour}:{Min + dif_min}:{Sec + dif_sec} or " +
                $"{Hour - min_hour}:{Min - min_min}:{Sec - min_sec}");
        }
        public void DistanceMin(int min)
        {
            int dif_min = min % 60, dif_hour = min / 60;
            int min_min = dif_min, min_hour = dif_hour;
            if (min_min > Min)
            {
                min_hour++;
                min_min -= 60;
            }
            Console.WriteLine($"Time removed by {min} minutes from '{Name}' is - " +
                $"{Hour + dif_hour}:{Min + dif_min}:{Sec} or " +
                $"{Hour - min_hour}:{Min - min_min}:{Sec}");
        }
        /*public string Serializing()
        {
            string obj = JsonConvert.SerializeObject(this);
            Console.WriteLine(obj);
            return obj;
        }
        public Time Deserializing(string path)
        {
            string jsonString = File.ReadAllText(path);
            Time jsonDes = JsonConvert.DeserializeObject<Time>(jsonString);
            return jsonDes;
        */
    }
}
