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
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //string binary = BinaryConverter.ToBinary(number);
            //Console.WriteLine("Binary: {0}", binary);

            //int swapped = BinaryConverter.SwapNibbles(binary);
            //Console.WriteLine("Swapped: {0}", swapped);

            //bool isPowerOfTwo = BinaryConverter.CheckPowerOfTwo(swapped);
            //Console.WriteLine("Is power of two: {0}", isPowerOfTwo);
            //Console.ReadLine();

            int decimalNumber = 100;
            string binaryNumber = BinaryConverter.ToBinary(decimalNumber);
            int swappedDecimalNumber = BinaryConverter.SwapNibbles(binaryNumber);

            Console.WriteLine("Decimal number: " + decimalNumber);
            Console.WriteLine("Binary number: " + binaryNumber);
            Console.WriteLine("Swapped decimal number: " + swappedDecimalNumber);
            Console.ReadLine();
        }
    }
}
