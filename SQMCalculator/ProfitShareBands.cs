using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SQMCalculator.CalculatorModel;

namespace SQMCalculator
{
    class BonusBands
    {
        //Mapping from lower bound of salary to its bonus
        //e.g. (10000,0.05) means if you earn 10000 or over you receivce a 5% bonus
        private SortedList<int, double> _bands = new SortedList<int, double>();

        public BonusBands AddBand(int bound, double rate)
        {
            _bands.Add(bound, rate);
            return this;
        }

        public double GetRateBySalary(int salary)
        {
            if(_bands?.Count > 0)
                return _bands
                        .Where(band => band.Key <= salary)
                        .Last().Value;

            return 0;
        }
    }
}
