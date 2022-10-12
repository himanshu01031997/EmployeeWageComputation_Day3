namespace EmployeeWageComputation
{
    public static class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();

            empWageBuilderArray.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilderArray.addCompanyEmpWage("Reilance", 10, 4, 20);

            empWageBuilderArray.ComputeWage();
        }

        
    }
}