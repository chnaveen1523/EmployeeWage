using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {   // UC1 EmployeeWage
            int IS_PRESENT = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
            Console.ReadLine();
        }
    }
}
