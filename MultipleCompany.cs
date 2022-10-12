using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{

    public  class MultipleCompany
    {


        // public static int ispresent = 1;
      //  public  int WAGE_PER_HR = 20;
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
     //   public const int ABSENT = 0;
      //  public const int NumofWorkingDay = 20;
       // public const int Maximum_Hr = 100;

        public   int  wages(string company,int EmpRateprHr,int NumWorkingDay,int MaxHrPrMonth)
        {
            //variable
            int emphr = 0;
            int totalemphr = 0;
            int totalworkingday = 0;
            Console.WriteLine("monthly wages of employee");
            Console.WriteLine("------------------------------");
            while (totalemphr <= MaxHrPrMonth && totalworkingday < NumWorkingDay)
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
                    default:
                        Console.WriteLine("Employee is Absent");
                        emphr = 0;
                        break;
                    
                }
                totalemphr += emphr;
                Console.WriteLine("days {0}:", totalworkingday + " emp hour " + emphr);

            }
             Console.WriteLine("total Employee hour is {0}",totalemphr);

            int totalempwage = totalemphr * EmpRateprHr;
            Console.WriteLine("total employee wage for company {0} and total Employee wage {1} " ,company, totalempwage);
            return totalempwage;
        }
    }
}