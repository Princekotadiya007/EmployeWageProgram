using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee is attandance");
            Attandance attandance = new Attandance();
            attandance.Attendance();

            Console.WriteLine("Employee is calculate");
            Calculate calculate = new Calculate();
            calculate.EmpCalculate();

            Console.WriteLine("Employee checking Part Time");
            PartTime partTime = new PartTime();
            partTime.EmpPartTime();

            Console.WriteLine("Employee switch case");
            SwitchCase switchCase = new SwitchCase();
            Console.ReadLine();
        }
    }
}
