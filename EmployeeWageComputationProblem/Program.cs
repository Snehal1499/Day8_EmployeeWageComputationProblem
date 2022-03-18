using System;

namespace EmployeeWageComputationProblem
{
    public class UC5_EmployeeWage
    {
        //Constants
        public int is_FullTime = 1;
        public int is_PartTime = 2;
        public int emp_Rate_Per_Hr = 20;
        public int total_Working_Hrs = 99;
        public int total_Work_Days_In_Month = 20;

        //Variables
        public int empHrs = 0;
        public int empTotalWage = 0;
        public int total_Worked_DAys = 0;
        public int total_Worked_Hrs = 0;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            UC5_EmployeeWage UC5 = new UC5_EmployeeWage();
            //Computation
            while (UC5.total_Worked_DAys <= UC5.total_Work_Days_In_Month || UC5.total_Worked_Hrs <= UC5.total_Working_Hrs)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                UC5.total_Worked_DAys++;
                UC5.total_Worked_Hrs++;
                switch (empCheck)
                {
                    case 1:
                        UC5.empHrs = 8;
                        break;
                    case 2:
                        UC5.empHrs = 4;
                        break;
                    default:
                        UC5.empHrs = 0;
                        break;
                }

            }
            Console.WriteLine("Total Worked Hr =" + UC5.total_Worked_Hrs);
            UC5.empTotalWage = UC5.total_Worked_Hrs * UC5.emp_Rate_Per_Hr;
            Console.WriteLine("emp Total Wage =" + UC5.empTotalWage);
        }
    }
}










