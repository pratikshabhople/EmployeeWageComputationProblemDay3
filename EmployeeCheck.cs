﻿using System;
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


            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck==ISFULLTIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");

            }
        }
    }
}
