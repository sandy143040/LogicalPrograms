using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    internal class BinaryConverter
    {
        public static string ToBinary(int number)
        {
            int quotient;
            string binary = string.Empty;

            while (number > 0)
            {
                quotient = number / 2;
                binary = (number % 2) + binary;
                number = quotient;
            }

            return binary;
        }

        public static int SwapNibbles(string binary)
        {
            int[] nibbles = new int[8];
            for (int i = 0; i < binary.Length; i++)
            {
                nibbles[i] = int.Parse(binary[i].ToString());
            }

            // Swap nibbles
            for (int i = 0; i < 4; i++)
            {
                int temp = nibbles[i];
                nibbles[i] = nibbles[i + 4];
                nibbles[i + 4] = temp;
            }

            // Calculate decimal value of swapped nibbles
            int value = 0;
            for (int i = nibbles.Length - 1; i >= 0; i--)
            {
                value += nibbles[i] * (int)Math.Pow(2, nibbles.Length - 1 - i);
            }

            return value;
        }
        public static bool CheckPowerOfTwo(int number)
        {
            return (number != 0) && ((number & (number - 1)) == 0);
        }
    }
}

