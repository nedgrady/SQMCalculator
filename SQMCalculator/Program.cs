using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQMCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusBands b = new BonusBands()
                .AddBand(0, 0.01)
                .AddBand(10000, 0.05)
                .AddBand(30000, 0.1)
                .AddBand(100000, 0.2)
                .AddBand(1000000, 0.4);

            CalculatorVew view = new CalculatorVew();
            CalculatorModel model = new CalculatorModel(b);
            CalculatorController controller = new CalculatorController(view, model);

            Application.Run(view);
        }
    }
}
