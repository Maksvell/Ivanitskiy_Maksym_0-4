using System;
using System.Collections.Generic;
using System.Text;
using Student;

namespace OP_laba4
{
    class Group
    {
        public List<Person> stud = new List<Person>();
        public int am_budg = 0;
        public int am_cont = 0;
        public int am_ext = 0;
        public void AddStudent()
        {
            Console.WriteLine("1 - budget, 2 - contract, 3 - extramural");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                stud.Add(new BudgetStudent());
                am_budg++;
            }
            else if (i == 2)
            {
                stud.Add(new ContractStudent());
                am_cont++;
            }
            else
            {
                stud.Add(new ExtramuralStudent());
                am_ext++;
            }
        }
        public void AddStudent(int i, string name, int spec, int course, int numOfPair, int feeOrScholarship)
        {
            if (i == 1)
            {
                stud.Add(new BudgetStudent(name, spec, course, numOfPair, feeOrScholarship));
                am_budg++;
            }
            else if (i == 2)
            {
                stud.Add(new ContractStudent(name, spec, course, numOfPair, feeOrScholarship));
                am_cont++;
            }
            else
            {
                stud.Add(new ExtramuralStudent(name, spec, course, numOfPair, feeOrScholarship));
                am_ext++;
            }
        }
        public void Amount()
        {
            Console.WriteLine($"Amount of budget student - {am_budg}");
            Console.WriteLine($"Amount of contract student - {am_cont}");
            Console.WriteLine($"Amount of extramurak student - {am_ext}");
        }
        
    }
}
