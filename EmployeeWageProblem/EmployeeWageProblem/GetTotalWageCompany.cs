using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
     public class GetTotalWageCompany 
    {
        // Declare a list to store the employees
        ArrayList employeesList;

        // Constructor to initialize the list
        public GetTotalWageCompany()
        {
            employeesList = new ArrayList();
        }

        // Method to add an employee to the list
        public void AddEmployee(string name, string company, int wagePerHour, int workingDaysPerMonth, int workingHoursPerDay)
        {
            employeesList.Add(new Employee(name, company, wagePerHour, workingDaysPerMonth, workingHoursPerDay));
        }

        // Method to compute the wage for all the employees in the list
        public void ComputeWage()
        {
            foreach (Employee emp in employeesList)
            {
                int totalWage = 0;
                int totalWorkingDays = 0;
                int totalWorkingHours = 0;
                ArrayList dailyWages = new ArrayList();
                while (totalWorkingDays < emp.WorkingDaysPerMonth && totalWorkingHours < emp.WorkingHoursPerDay)
                {
                    int empHrs = 0;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case 0:
                            empHrs = 0;
                            break;
                        case 1:
                            empHrs = 4;
                            break;
                        case 2:
                            empHrs = 8;
                            break;
                    }
                    totalWorkingHours += empHrs;
                    totalWorkingDays++;
                    int dailyWage = empHrs * emp.WagePerHour;
                    totalWage += dailyWage;
                    dailyWages.Add(dailyWage);
                }
                emp.TotalWage = totalWage;
                emp.DailyWages = dailyWages;
            }
        }

        // Method to get the total wage for a company
        public int GetTotalWageByCompany(string companyName)
        {
            int totalWage = 0;
            foreach (Employee emp in employeesList)
            {
                if (emp.Company == companyName)
                {
                    totalWage += emp.TotalWage;
                }
            }
            return totalWage;
        }
    }

    // Define the Employee class to store employee details
    public class Employee
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public int WagePerHour { get; set; }
        public int WorkingDaysPerMonth { get; set; }
        public int WorkingHoursPerDay { get; set; }
        public int TotalWage { get; set; }
        public ArrayList DailyWages { get; set; }

        public Employee(string name, string company, int wagePerHour, int workingDaysPerMonth, int workingHoursPerDay)
        {
            Name = name;
            Company = company;
            WagePerHour = wagePerHour;
            WorkingDaysPerMonth = workingDaysPerMonth;
            WorkingHoursPerDay = workingHoursPerDay;
        }
    }
}
