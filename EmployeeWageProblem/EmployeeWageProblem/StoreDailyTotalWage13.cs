using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    interface StoreDailyTotalWage13
    {
        void AddCompanys(string name, int wagePerHour, int workingDaysPerMonth, int workingHoursPerDay);
        void ComputeWage();
    }

    // Implement the interface in the EmpWageBuilders class
    class EmpWageBuilders13 : StoreDailyTotalWage13
    {
        // Declare an ArrayList to store company details
        ArrayList companyList;

        // Constructor to initialize the ArrayList
        public EmpWageBuilders13()
        {
            companyList = new ArrayList();
        }

        // Method to add a company to the list
        public void AddCompanys(string name, int wagePerHour, int workingDaysPerMonth, int workingHoursPerDay)
        {
            companyList.Add(new Companie(name, wagePerHour, workingDaysPerMonth, workingHoursPerDay));
        }

        // Method to compute the wages for all the companies in the list
        public void ComputeWage()
        {
            foreach (Companie company in companyList)
            {
                int totalWage = 0;
                int totalWorkingDays = 0;
                int totalWorkingHours = 0;
                ArrayList dailyWages = new ArrayList();
                while (totalWorkingDays < company.WorkingDaysPerMonth && totalWorkingHours < company.WorkingHoursPerDay)
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
                    int dailyWage = empHrs * company.WagePerHour;
                    dailyWages.Add(dailyWage);
                    totalWorkingHours += empHrs;
                    totalWorkingDays++;
                    totalWage += dailyWage;
                }
                Console.WriteLine("Company: {0}\nTotal wage: {1}\nDaily wages: {2}\n", company.Name, totalWage, string.Join(", ", dailyWages.ToArray()));
            }
        }
    }

    // Define the Company class to store company details
    class Companie
    {
        public string Name { get; set; }
        public int WagePerHour { get; set; }
        public int WorkingDaysPerMonth { get; set; }
        public int WorkingHoursPerDay { get; set; }

        public Companie(string companyName, int wagePerHour, int workingDaysPerMonth, int workingHoursPerDay)
        {
            Name = companyName;
            WagePerHour = wagePerHour;
            WorkingDaysPerMonth = workingDaysPerMonth;
            WorkingHoursPerDay = workingHoursPerDay;
        }
    }
}
