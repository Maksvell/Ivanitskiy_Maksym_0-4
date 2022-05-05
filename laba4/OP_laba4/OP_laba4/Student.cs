using System;
using System.Collections.Generic;
using System.Text;
using OP_laba4;

namespace Student
{
    class BudgetStudent : Person
    {
        public int scholarship;
        public BudgetStudent(string name, int spec, int course, int numOfPair, int scholarship) : base(name, spec, course, numOfPair)
        {
            this.scholarship = scholarship;
        }
        public BudgetStudent() : base()
        {
            Console.WriteLine("Input a scholarship of person:");
            scholarship = Convert.ToInt32(Console.ReadLine());
        }
        public void Scholarship()
        {
            Console.WriteLine($"{name} has {scholarship} of scholarship");
        }
        public new void Budget()
        {
            Console.WriteLine($"{name} is on budget");
        }

    }

    class ContractStudent : Person
    {
        public int fee;
        public ContractStudent(string name, int spec, int course, int numOfPair, int fee) : base(name, spec, course, numOfPair)
        {
            this.fee = fee;
        }
        public ContractStudent() : base()
        {
            Console.WriteLine("Input a fee of person:");
            fee = Convert.ToInt32(Console.ReadLine());
        }
        public void Fee()
        {
            Console.WriteLine($"Tuition fee of {name} is {fee}");
        }
    }

    class ExtramuralStudent : Person
    {
        public int fee;
        public ExtramuralStudent(string name, int spec, int course, int numOfPair, int fee) : base(name, spec, course, numOfPair)
        {
            this.fee = fee;
        }
        public ExtramuralStudent() : base()
        {
            Console.WriteLine("Input a fee of person:");
            fee = Convert.ToInt32(Console.ReadLine());
        }
        public void Fee()
        {
            Console.WriteLine($"Tuition fee of {name} is {fee}");
        }
    }
}
