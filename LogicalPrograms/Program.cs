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
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            CouponNumbers.getDistinctNumbers(n);
            Console.ReadLine();
        }
    }
}
