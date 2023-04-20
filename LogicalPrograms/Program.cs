using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer number to find prime or not");
            int input = Convert.ToInt32(Console.ReadLine());
            PrimeNumber.FindPrimeNumber(input);
            Console.ReadLine();

        }
    }
}
