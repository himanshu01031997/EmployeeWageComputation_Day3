using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public static  class DailyWages
    {
            // public static int ispresent = 1;
        public static int WAGE_PER_HR = 20;
        public static int FULL_TIME = 1;
        public static void Wages()
        {
            int emphr = 0;
            int Empwage = 0;

            Console.WriteLine("Daily wages of employee");
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == FULL_TIME)
            {
                Console.WriteLine("employee is fulltime");
                emphr = 8;

            }
            else
            {
                Console.WriteLine("employee is absent");
                emphr = 0;

            }
            Empwage = emphr * WAGE_PER_HR;
            Console.WriteLine("Daily wage of employee is {0}", Empwage);

        }
    }
}
