using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_REQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of jobs");
            int no = Convert.ToInt32(Console.ReadLine());
            SalaryComparator[] sc = new SalaryComparator[no];
            for (int i = 0; i < no; i++)
            {
                sc[i] = new SalaryComparator();
                Console.WriteLine("Enter your  Job Role");
                sc[i].Role = Console.ReadLine();
                Console.WriteLine("Enter SkilSet");
                sc[i].Skillset = Console.ReadLine();
                Console.WriteLine("Enter EmployementType");
                sc[i].EmploymentType = Console.ReadLine();
                Console.WriteLine("Enter Location");
                sc[i].Location = Console.ReadLine();
                Console.WriteLine("Enter MiniExperiance");
                sc[i].MiniExperience = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Salary");
                sc[i].Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Thank you for entering your Details");
            }
            Console.WriteLine("Enter a type to Sort");
            Console.WriteLine("1.Sort by mini.experiance");
            Console.WriteLine("2.Sort by slary");
            Console.WriteLine("enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            Job j = new Job();
            String print = j.ToString();
            SalaryComparator s = new SalaryComparator();
            String printSalary = sc.ToString();
            switch (ch)
            {
                case 1:
                    {

                        j.CompareTo(j);
                        j.ToString();
                        Console.WriteLine(print);
                        break;
                    }
                case 2:
                    {

                        s.CompareTo(j);
                        s.ToString();
                        Console.WriteLine(printSalary);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Pleace Enter correct Option..!");
                        Console.WriteLine("Thank you");
                        break;
                    }
            }

        }
    }
}
