using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    public class HourlyEmployee: Employee
    {
        private double thingy;
        public decimal HourlyRate { get; set; }

        public HourlyEmployee(): base()
        {
            HourlyRate = 15.0M;
        }

        public override double something
        {
            get
            {
                return thingy;
            } set
            {
                if (value>=0)
                {
                    thingy = -1;
                } else
                {
                    thingy = value;
                }
            }
        }

        public string GetPaySummary()
        {
            return FirstName + ' ' + LastName + "'s hourly pay is " + HourlyRate;
        }

        public override string ToString()
        {
            return FirstName + ' ' + LastName;
        }
    }
}
