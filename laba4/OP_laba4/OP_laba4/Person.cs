using System;
using System.Collections.Generic;
using System.Text;

namespace OP_laba4
{
    abstract class Person
    {
        public string name;
        public int spec;
        public int course;
        public int numOfPair;
        public static DateTime dateOfTerm = new DateTime(2022, 6, 15);
        public Person(string name, int spec, int course, int numOfPair)
        {
            this.name = name;
            this.spec = spec;
            this.course = course;
            this.numOfPair = numOfPair;
        }
        public Person()
        {
            Console.WriteLine("Input a neme of person:");
            name = Console.ReadLine();
            Console.WriteLine("Input a specialization of person:");
            spec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a course of person:");
            course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a number of pair of person:");
            course = Convert.ToInt32(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"Name: {name},\nSpec: {spec},\nCourse: {course}");
        }
        public static void Term()
        {
            Console.WriteLine($"Date of term: {dateOfTerm}");
        }
        public void Budget()
        {
           Console.WriteLine($"{name} isn't on budget");
        }
        public void NumOfPair()
        {
            Console.WriteLine($"{name} has {numOfPair} pair a week");
        }

    }
}
