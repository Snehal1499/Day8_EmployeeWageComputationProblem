using System;

namespace EmployeeWageComputationProblem
{
    public class UC5_EmployeeWage
    {
        //Constants
        public int is_FullTime = 1;
        public int is_PartTime = 2;
        public int emp_Rate_Per_Hr = 20;
        public int no_of_Working_Days = 20;

        //Variables
        public int empHrs = 0;
        public int empWage_per_day = 0;
        public int empWage_per_Month = 0;

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            UC5_EmployeeWage UC5 = new UC5_EmployeeWage();
            Random random = new Random();

            //Computation

            int empCheck = random.Next(0, 3);
            if (empCheck == UC5.is_FullTime)
            {
                UC5.empHrs = 8;

            }
            else if (empCheck == UC5.is_PartTime)
            {
                UC5.empHrs = 4;
            }
            else
            {
                UC5.empHrs = 0;
            }
            UC5.empWage_per_day = UC5.empHrs * UC5.emp_Rate_Per_Hr;
            Console.WriteLine("Wage Per Day=" + UC5.empWage_per_day);
            UC5.empWage_per_Month = UC5.empWage_per_day * UC5.no_of_Working_Days;
            Console.WriteLine("Wage PEr Month=" + UC5.empWage_per_Month);
        }
    }
}










