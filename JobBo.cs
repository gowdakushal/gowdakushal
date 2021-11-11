using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB__APPLICATION
{
    class JobBo
    {
        public List<JobDetails> findLocation(List<JobDetails> jobList, string location)
        {
            List<JobDetails> result = new List<JobDetails>();
            foreach (var item in jobList)
            {
                if (item.Location.Equals(location))
                {
                    result.Add(item);
                }
            }
            return result;

        }
        public List<JobDetails> findSalary(List<JobDetails> jobList, double salary)
        {
            List<JobDetails> result = new List<JobDetails>();
            foreach (var item in jobList)
            {
                if (item.Salary.Equals(salary))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}

