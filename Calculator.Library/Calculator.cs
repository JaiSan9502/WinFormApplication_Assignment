﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library
{
    public class Calculator
    {
        public static double Add(double Operand1, double Operand2)
        {
            return Operand1 + Operand2;
        }

        public static double Sub(double Operand1, double Operand2)
        {
            return Operand1 - Operand2;
        }

        public static double Mul(double Operand1, double Operand2)
        {
            return Operand1 * Operand2;
        }

        public static double Div(double Operand1, double Operand2)
        {
            return Operand1 / Operand2;
        }

    }
}
