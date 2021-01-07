using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Operation
    {
        //Form1 simpleCalculatorForm = new Form1();
        public double Sub(double v1, double v2)
        {
            return v1-v2;
        }

        public double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        public double Mul(double v1, double v2)
        {
            return v1 * v2;
        }

        public double Div(double v1, double v2)
        {
            return v1 / v2;
        }
    }
}
