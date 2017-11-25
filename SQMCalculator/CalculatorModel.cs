using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQMCalculator
{
    class CalculatorModel
    {
        const int MONTHS_MULTIPLIER = 5;
        private readonly BonusBands _bands;

        public CalculatorModel(BonusBands bs)
        {
            _bands = bs ?? throw new ArgumentNullException();
        }

        public int CalculateBonus(int salary, int months)
        {
            double  rate = _bands.GetRateBySalary(salary),
                    bonus = ((salary > 0 ? salary : 0) * rate) + 
                            ((months > 0 ? months : 0) * MONTHS_MULTIPLIER);

            return bonus > 0 ? (int)Math.Floor(bonus) : 0;
        }
    }
}
