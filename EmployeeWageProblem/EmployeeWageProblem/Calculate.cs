using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Calculate
    {
        public void EmpCalculate()
        {
            int EMP_PER_Hour = 20;
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == 0)
            {
                EmpHrs = 8;
                Console.WriteLine("Employee is present");
            }
            else
            {
                EmpHrs = 0;
                Console.WriteLine("Employee is not present");
            }
            EmpWage = EmpHrs * EMP_PER_Hour;
            Console.WriteLine("Emp wage :" + EmpWage);
        }
    }
}
