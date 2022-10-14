using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public static class EmployeeCheck
    {
        public static void CheckAttendence()
        {
            int ISFULLTIME = 1;
            int EMPRATEPERHOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck==ISFULLTIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
                empWage = empHrs * EMPRATEPERHOUR;
                Console.WriteLine("Emp Wage:" + empWage);
            }
        }
    }
}
