using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    internal class LoanCalculator
    {
        public static double CalculateMonthlyPayment(double P, int Y, double R)
        {
            double n = 12 * Y;
            double r = R / (12 * 100);
            double denominator = 1 - Math.Pow(1 + r, -n);
            double payment = P * r / denominator;
            return payment;
        }
    }
}
