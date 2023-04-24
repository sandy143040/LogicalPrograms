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
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation: " + BinaryConverter.ToBinary(decimalNumber));
            Console.ReadLine();
        }
    }
}
