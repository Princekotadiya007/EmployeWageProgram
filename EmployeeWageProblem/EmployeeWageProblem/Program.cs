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

            Console.WriteLine("Compute Employee wage Using Class Methods ");
            EmployeClassMethods employeClassMethods = new EmployeClassMethods();
            employeClassMethods.ComputeEmpWage();
            Console.WriteLine("\n");

            Console.WriteLine("Compute Employee wage Parameters instend class method");
            EmployeParametersInstendClass parameters = new EmployeParametersInstendClass();
            parameters.ComputeEmpWage("Amazon",20, 5, 20);
            parameters.ComputeEmpWage("Paytam", 30, 4, 10);
            Console.WriteLine("\n");

            Console.WriteLine("Compute Employee Wage and save Total Wage Intance varible parametre");
            IntanceVaribleParameter amazon = new IntanceVaribleParameter("Amazon", 20 ,4, 30);
            amazon.ComputeEmpWage();
            Console.WriteLine(amazon.ToString());
            IntanceVaribleParameter google = new IntanceVaribleParameter("google", 25, 8, 20);
            google.ComputeEmpWage();
            Console.WriteLine(google.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Employee Wage of multiple companies");
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanyEmpWage("Amazon", 20, 20, 100);
            empWageBuilder.AddCompanyEmpWage("Google", 25, 25, 120);
            empWageBuilder.ComputeEmployeeWage();
            Console.WriteLine("\n");

            Console.WriteLine("Employee Wage Of Multiple compnies Interface Methoad");
            EmpWageBuilders empWageBuilderUC11 = new EmpWageBuilders();
            empWageBuilderUC11.AddCompanys("Dmart",10,15,80);
            empWageBuilderUC11.AddCompanys("Microsoft", 28, 15, 90);
            empWageBuilderUC11.ComputeWage();
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
