using System;

namespace EmployeeWageComputationProblem
{
    public class UC2_EmployeeWage
    {
        //Constants
        public int is_Present = 1;
        public int emp_Rate_Per_Hr = 20;

        //variables
        public int empHrs = 0;
        public int empWage = 0;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            UC2_EmployeeWage UC2 = new UC2_EmployeeWage();
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == UC2.is_Present)
            {
                UC2.empHrs = 8;
            }
            else
            {
                UC2.empHrs = 0;
            }
                UC2.empWage = UC2.empHrs * UC2.emp_Rate_Per_Hr;
            Console.WriteLine("Emp Wage =" + UC2.empWage);
        }
    }
}



