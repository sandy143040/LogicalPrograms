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
            int m = int.Parse(args[0]);
            int d = int.Parse(args[1]);
            int y = int.Parse(args[2]);


            int day = Util.dayOfWeek(m, d, y);
            Console.WriteLine("Day is:" + day);
            Console.ReadLine();
        }
    }
}
