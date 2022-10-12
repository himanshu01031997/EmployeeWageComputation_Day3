using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{

    public  class MaximumHr
    {


        // public static int ispresent = 1;
        public  int WAGE_PER_HR = 20;
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int ABSENT = 0;
        public const int NumofWorkingDay = 20;
        public const int Maximum_Hr = 100;

        public  void wages()
        {
            //variable
            int emphr = 0;
            //int Empwage = 0;
            //int totalempwage = 0;
            int totalemphr = 0;
            int totalworkingday = 0;
            Console.WriteLine("monthly wages of employee");
            Console.WriteLine("------------------------------");
            while (totalemphr <= Maximum_Hr && totalworkingday < NumofWorkingDay)
            {
                totalworkingday++;
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
                    default:
                        break;
                }
                totalemphr += emphr;
                Console.WriteLine("days {0}:", totalworkingday + " emp hour " + emphr);

            }
             Console.WriteLine("total Employee hour is {0}",totalemphr);

            int totalempwage = totalemphr * WAGE_PER_HR;
            Console.WriteLine("total employee wage : {0}", totalempwage);
        }
    }
}