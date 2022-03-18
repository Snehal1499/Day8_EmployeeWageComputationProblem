using System;

namespace EmployeeWageComputationProblem
{
    public class UC4_EmployeeWage
    {
        //Constants
        public int is_FullTime = 1;
        public int is_PartTime = 2;
        public int emp_Rate_Per_Hr = 20;

        //Variables
        public int empHrs = 0;
        public int empWage = 0;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            UC4_EmployeeWage UC4 = new UC4_EmployeeWage();
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case 1:
                    UC4.empHrs = 8;
                    break;
                case 2:
                    UC4.empHrs = 4;
                    break;
                default:
                    UC4.empHrs = 0;
                    break;
            }
            UC4.empWage = UC4.empHrs * UC4.emp_Rate_Per_Hr;
            Console.WriteLine("Emp Wage =" + UC4.empWage);
        }
    }
}








