using System;
using System.Collections.Generic;
using System.Text;

namespace YearCal
{
    internal class SubtractOP
    {
        public double Subtract(double a, double b)
        {
            MessageBox.Show("Subtracting " + b + " from " + a);
            return a - b;
        }
    }
}
