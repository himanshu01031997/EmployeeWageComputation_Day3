using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        //variable
        public string company;
        public int EmpRateprhr;
        public int NumWorkingDay;
        public int MaxHrPrMonth;
        public int TotalEmpWage;
        public CompanyEmpWage(string company, int EmpRateprHr, int NumWorkingDay, int MaxHrPrMonth)// constructor 
        {
            this.company = company;
            this.EmpRateprhr = EmpRateprhr;
            this.NumWorkingDay = NumWorkingDay;
            this.MaxHrPrMonth = MaxHrPrMonth;
        }
        public void SetTotalEmpWage(int TotalEmpWage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }
        public string tostring()
        {
            return "total emp wage for company:" +this.company+"is"+this.TotalEmpWage;
        }
    }
}
