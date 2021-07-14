using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    public class Employee
    {
        public int EmpNum {get;set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual double something { get; set; }
        public virtual string GetPaySummary()
        {
            return ("Employees, as such, doesn't HAVE a pay summary!");
        }

        public override string ToString()
        {
            return base.ToString() + " for " + FirstName + " " + LastName;
        }
    }
}
