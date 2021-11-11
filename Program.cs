using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB__APPLICATION
{
    class Program
    {
        static void Main(string[] args)
        {
            List<JobDetails> joblist = null;
            Console.WriteLine("enter the no of job openings");
            int no = Convert.ToInt32(Console.ReadLine());
            JobDetails[] jobs = new JobDetails[no];
            for (int i = 0; i < no; i++)
            {
                jobs[i] = new JobDetails();
                Console.WriteLine("Enter your  Job Role");
                jobs[i].Role = Console.ReadLine();
                Console.WriteLine("Enter SkilSet");
                jobs[i].Skillset = Console.ReadLine();
                Console.WriteLine("Enter EmployementType");
                jobs[i].EmploymentType = Console.ReadLine();
                Console.WriteLine("Enter Location");
                jobs[i].Location = Console.ReadLine();
                Console.WriteLine("Enter MiniExperiance");
                jobs[i].MiniExperience = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Salary");
                jobs[i].Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Thank you for entering your Details");
            }
            Console.WriteLine("Enter a Search type :");
            Console.WriteLine("1.By Salary");
            Console.WriteLine("2.Bylocation");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            JobBo jbo = new JobBo();
            List<JobDetails> job_deatails = null;
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the Salary");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        job_deatails = jbo.findSalary(joblist, salary);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the Location");
                        String location = Console.ReadLine();
                        job_deatails = jbo.findLocation(joblist, location);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please Enter a correct choice..! \n  Thank You");
                        break;

                    }

            }
            if (job_deatails != null)
            {
                foreach (var item in job_deatails)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }

        }
    }
}
