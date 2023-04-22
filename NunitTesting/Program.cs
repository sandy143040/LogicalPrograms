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
            Console.Write("Enter a non-negative number: ");
            double c = double.Parse(Console.ReadLine());
            double sqrtC = MathUtils.Sqrt(c);
            Console.WriteLine($"The square root of {c} is approximately {sqrtC}");
            Console.ReadLine();
        }
    }
}
