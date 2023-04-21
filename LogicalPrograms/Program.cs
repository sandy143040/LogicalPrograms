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
            Console.WriteLine("Please Enter Amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            VendingMachine.GetMinimumNumOfNotes(amount);
            Console.ReadLine();
        }
    }
}
