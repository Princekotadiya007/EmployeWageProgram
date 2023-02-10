using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class CalculateMonth
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        public const int EMP_RATE_PER_HRS = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        public void CalculateWage()
        {

            int empHrs = 0;
            int empWages = 0;
            int totalWages = 0;
            int empCheck = 0;
            

            for (int i = 1; i <= NUM_OF_WORKING_DAYS; i++)
            {
                switch (empCheck)
                {
                    case IS_PARTTIME:
                        empHrs = 4;
                        break;
                    case IS_FULLTIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                empWages = empHrs * EMP_RATE_PER_HRS;
                Console.WriteLine("Employee wages:" + empWages);
            }
            totalWages = totalWages + empWages;
            Console.WriteLine("Total monthly wages of an employee is: " + totalWages);
        }
    }
}
