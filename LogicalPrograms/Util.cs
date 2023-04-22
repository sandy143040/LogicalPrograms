using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Util
    {
        public static double temperatureConversion(double temperature, char unit)
        {
            double convert;
            if (unit == 'c' || unit == 'C')
            {
                convert = (temperature * 9 / 5) + 32;
                Console.WriteLine("Temperature converted in Fahrenheit:");
            }
            else if (unit == 'f' || unit == 'F')
            {
                convert = (temperature - 32) * 5 / 9;
                Console.WriteLine("Temperature converted in Celsius:");
            }
            else
            {
                Console.WriteLine("Enter correct input");
                return 0;
            }
            return convert;
        }
    }
}
