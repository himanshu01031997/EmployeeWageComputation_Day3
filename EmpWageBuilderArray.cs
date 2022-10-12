using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilderArray
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        private int NumofCompany = 0;
        private CompanyEmpWage[] companyEmpWagesArray;//array which accept CompanyEmpWage type of variable
        public EmpWageBuilderArray()// constructor 
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];////////// companyEmpWagesArray it will accept details of 5 companies
        }
        public void addCompanyEmpWage(string company, int EmpRateprhr, int NumWorkingDay, int MaxHrPrMonth)////////////20
        {
            companyEmpWagesArray[this.NumofCompany] = new CompanyEmpWage(company, EmpRateprhr, NumWorkingDay, MaxHrPrMonth);////////22
            NumofCompany++;
        }
        public void ComputeWage()//method 
        {
            for (int i = 0; i < NumofCompany; i++)
            {
                int val = this.ComputeWage(this.companyEmpWagesArray[i]);///////
                companyEmpWagesArray[i].SetTotalEmpWage(val);
                Console.WriteLine(this.companyEmpWagesArray[i].ToString());

            }
        }
        private int ComputeWage(CompanyEmpWage companyEmpWage)//method overloading
        {
            int emphr = 0, totalemphr = 0, totalworkingday = 0;
            Console.WriteLine("monthly wages of employee");
            Console.WriteLine("------------------------------");
            while (totalemphr <= companyEmpWage.MaxHrPrMonth && totalworkingday < companyEmpWage.NumWorkingDay)
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
            return totalemphr * companyEmpWage.EmpRateprhr;
        }
    }

}
                
