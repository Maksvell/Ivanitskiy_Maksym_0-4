using System;
using System.Collections.Generic;
using Student;

namespace OP_laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            group.AddStudent(1,"Tom", 126, 2, 17, 2300);
            group.AddStudent(2, "Vasya", 121, 3, 15, 42000);
            group.AddStudent(3, "Yarik", 123, 1, 13, 27000);
            Person.Term();
            group.stud[0].Budget();
            group.stud[1].Budget();
            group.stud[1].Scholarship();
            group.stud[2].Fee();
            group.stud[1].NumOfPair();
            group.Amount();
        }
    }
}
