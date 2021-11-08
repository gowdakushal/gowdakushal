using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_REQ
{
    class SalaryComparator : Job, IComparable
    {

        public int CompareTo(object obj)
        {
            Job t = (Job)obj;
            return this.Salary.CompareTo(t.Salary);
        }
        public override string ToString()
        {
            return String.Format(base.ToString());
        }
    }

}
