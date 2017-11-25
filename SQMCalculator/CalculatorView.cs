using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQMCalculator
{
    public partial class CalculatorVew : Form
    {
        public int Salary => ParseInput(salaryText);
        public int Months => ParseInput(monthsText);

        public event CalculateHandler CalculateCalled;
        public delegate void CalculateHandler(object sender, CalculateEventArgs args);

        public CalculatorVew()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void SetBonusResult(int bonus)
        {
            bonusText.Text = bonus.ToString();
        }

        private int ParseInput(Control t)
        {
            if (int.TryParse(t.Text, out int result))
                return result;

            MessageBox.Show("Error - Enter an integer for " + t.AccessibleName);
            return 0;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            RaiseCalculateCalled();
        }

        protected void RaiseCalculateCalled()
        {
            CalculateCalled?.Invoke(this, new CalculateEventArgs(Salary, Months));
        }
    }
}
