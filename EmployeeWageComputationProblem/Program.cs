using System;

namespace EmployeeWageComputationProblem
{
    public class UC1_EmployeeWage
    {
        //Constants
        public int Is_Full_Time = 1;
    }
    public class Programe
   
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //Computation
            Random random = new Random();
            int empcheck = random.Next(0,2);
            UC1_EmployeeWage emp = new UC1_EmployeeWage ();

            if (empcheck == emp.Is_Full_Time)

            {
                Console.WriteLine("Employee is Present ");
            }
            else
            {
                Console.WriteLine("Employee is Absent ");
            }

            }
    }
}
