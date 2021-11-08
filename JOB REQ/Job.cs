using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_REQ
{
    class Job : IComparable
    {
        String role;
        String skillset;
        String employmentType;
        String location;
        int miniExperience;
        double salary;

        public Job()
        {
        }

        public Job(string role, string skillset, string employmentType, string location, int miniExperience, double salary)
        {
            Role = role;
            Skillset = skillset;
            EmploymentType = employmentType;
            Location = location;
            MiniExperience = miniExperience;
            Salary = salary;
        }

        public string Role { get => role; set => role = value; }
        public string Skillset { get => skillset; set => skillset = value; }
        public string EmploymentType { get => employmentType; set => employmentType = value; }
        public string Location { get => location; set => location = value; }
        public int MiniExperience { get => miniExperience; set => miniExperience = value; }
        public double Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return String.Format("Role : {0}  ,EmployementType : {1}  Location : {2}  Min.Experiance : {3}  Salary :{4}", role, employmentType, location, miniExperience, salary);
        }
        public override bool Equals(object obj)
        {
            Job t = (Job)obj;
            return this.miniExperience.Equals(t.miniExperience);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Job j = (Job)obj;
            return this.miniExperience.CompareTo(j.miniExperience);
        }
    }
}

    
        
        
