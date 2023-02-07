using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class SwitchCase
    {
        public void EmpSwitchCase()
        {
            const int Is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 20;
            const int Is_Part_Time = 2;
            int Empwage;
            int Emphours;

            Random random = new Random();
            int empcheck = random.Next(0, 3);

            switch (empcheck)
            {
                case Is_Full_Time:

                    Emphours = 8;
                    Console.WriteLine(" Is_Full_Time");
                    break;

                case Is_Part_Time:
                    Emphours = 4;
                    Console.WriteLine("Is_Part_Time");
                    break;

                default:
                    Emphours = 0;

                    break;
            }

            Empwage = Emphours * Emp_Rate_Per_Hour;
            Console.WriteLine("Daily employee wage is : " + Empwage);
        }
    }
}
