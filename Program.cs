namespace EmployeeWageComputation
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Employee Wage Computation");
            //     DailyWages.Wages();
            // ParttimeEmp.Wages();
            // SwitchCase.Wages();
            // MonthlyWages.wages();
            //  MaximumHr.wages();
            //MaximumHr MHr = new MaximumHr();
            //MHr.wages();
            MultipleCompany company1 = new MultipleCompany();
            company1.wages("dmart", 10, 15, 40);
            MultipleCompany company2 = new MultipleCompany();
            company2.wages("bigbazar", 12, 10, 30);

        }
    }
}