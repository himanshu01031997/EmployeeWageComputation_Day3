using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{

    public static class SwitchCase
    {

        // public static int ispresent = 1;
        public static int WAGE_PER_HR = 20;
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int ABSENT = 0;
        public static void Wages()
        {
            int emphr = 0;
            int Empwage = 0;

            Console.WriteLine("Daily wages of employee");
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case FULL_TIME:
                    Console.WriteLine("Employee is FullTime");
                    emphr = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Employee is PartTime");
                    emphr = 4;
                    break;
                case ABSENT:
                    Console.WriteLine("Employee is Absent");
                    emphr = 0;
                    break;

            }
            Empwage = emphr * WAGE_PER_HR;
            Console.WriteLine("Daily wage of employee is {0}", Empwage);
        }
    }
}