using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class PartTime
    {
        public void EmpPartTime()
        {
            int EMP_PER_HRS = 20;
            int empHrs = 0;
            int empWage = 0;
            int PartTime = 1;
            int FullTime = 2;

            Random random = new Random();
            int checkEmp = random.Next(0, 3);

            if (checkEmp == FullTime)
            {
                empHrs = 8;
                Console.WriteLine("Employee is full Time");
            }
            else if (checkEmp == PartTime)
            {
                empHrs = 4;
                Console.WriteLine("Employee is Part Time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * EMP_PER_HRS;
            Console.WriteLine("Emp Wage:" + empWage);
        }
    }
}
