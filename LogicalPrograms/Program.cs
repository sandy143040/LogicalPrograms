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
            Console.WriteLine("Enter a temperature:");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the unit (C for Celsius or F for Fahrenheit):");
            char unit = char.Parse(Console.ReadLine());

            Double convertedTemperature = Util.temperatureConversion(temperature, unit);
            Console.WriteLine("Converted temperature: "+convertedTemperature);

            Console.ReadLine();
        }
    }
}
