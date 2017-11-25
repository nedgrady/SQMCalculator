using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQMCalculator
{
    class CalculatorController
    {
        private readonly CalculatorVew _view;
        private readonly CalculatorModel _model;

        public CalculatorController(CalculatorVew view, CalculatorModel model)
        {
            _view = view;
            _model = model;

            _view.CalculateCalled += CalculateBonus;
        }

        public void CalculateBonus(object sender, CalculateEventArgs e)
        {
            int bonus = _model.CalculateBonus(e.Salary, e.Months);
            _view.SetBonusResult(bonus);
        }
    }
}
