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
            Console.WriteLine("Please Enter Value");
            int n = Convert.ToInt32(Console.ReadLine());
            bool b = PerfectNumber.IsPerfect(n);
            if (b)
                Console.WriteLine("Its a perfect number");
            else
                Console.WriteLine("Its not a perfect number");
            Console.ReadLine();

        }
    }
}
