using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double monthlyPayment = LoanCalculator.CalculateMonthlyPayment(10000, 5, 3.5);
            Console.WriteLine("Your monthly payment is: " + monthlyPayment);

            Console.ReadLine();
        }
    }
}
