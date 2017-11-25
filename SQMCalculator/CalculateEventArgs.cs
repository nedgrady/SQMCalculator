using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQMCalculator
{
    public class CalculateEventArgs
    {
        public int Salary { get; private set; }
        public int Months { get; private set; }

        public CalculateEventArgs(int salary, int months)
        {
            Salary = salary;
            Months = months;
        }
    }
}
