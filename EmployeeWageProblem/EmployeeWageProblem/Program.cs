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
            Console.WriteLine("\n");

            Console.WriteLine("Employee is calculate");
            Calculate calculate = new Calculate();
            calculate.EmpCalculate();
            Console.WriteLine("\n");

            Console.WriteLine("Employee checking Part Time");
            PartTime partTime = new PartTime();
            partTime.EmpPartTime();
            Console.WriteLine("\n");

            Console.WriteLine("Employee switch case");
            SwitchCase switchCase = new SwitchCase();
            switchCase.EmpSwitchCase();
            Console.WriteLine("\n");

            Console.WriteLine("Employe calculate month Wage");
            CalculateMonth calculateMonth = new CalculateMonth();
            calculateMonth.CalculateWage();
            Console.WriteLine("\n");

            Console.WriteLine("Employe Calculate total working day and hours");
            CalculateTotalHrs calculateTotalHrs = new CalculateTotalHrs();
            calculateTotalHrs.CalculateMonthHrs();
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
