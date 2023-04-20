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
            Console.WriteLine("Please enter integer value");
            int num = Convert.ToInt32(Console.ReadLine());
            ReverseNumber.FindReverseNumber(num);
            Console.ReadLine();
        }
    }
}
