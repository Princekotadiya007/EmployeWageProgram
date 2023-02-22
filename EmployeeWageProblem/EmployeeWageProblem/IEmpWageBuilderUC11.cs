using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    interface IEmpWageBuilderUC11
    {
        void AddCompanys(string name, int wagePerHour, int workingDaysPerMonth, int workingHoursPerDay);
        void ComputeWage();
    }

    // Implement the interface in the EmpWageBuilder class
    class EmpWageBuilders : IEmpWageBuilderUC11
    {
        // Declare a list to store company details
        List<Company> companyList;

        // Constructor to initialize the list
        public EmpWageBuilders()
        {
            companyList = new List<Company>();
        }

        // Method to add a company to the list
        public void AddCompanys(string name, int wagePerHour, int workingDaysPerMonth, int workingHoursPerDay)
        {
            companyList.Add(new Company(name, wagePerHour, workingDaysPerMonth, workingHoursPerDay));
        }

        // Method to compute the wages for all the companies in the list
        public void ComputeWage()
        {
            foreach (Company company in companyList)
            {
                int totalWage = 0;
                int totalWorkingDays = 0;
                int totalWorkingHours = 0;
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
                    totalWorkingHours += empHrs;
                    totalWorkingDays++;
                    totalWage += empHrs * company.WagePerHour;
                }
                Console.WriteLine("Total wage for {0} company: {1}", company.Name, totalWage);
            }
        }
    }

    // Define the Company class to store company details
    class Company
    {
        public string Name { get; set; }
        public int WagePerHour { get; set; }
        public int WorkingDaysPerMonth { get; set; }
        public int WorkingHoursPerDay { get; set; }

        public Company(string companyName, int wagePerHour, int workingDaysPerMonth, int workingHoursPerDay)
        {
            Name = companyName;
            WagePerHour = wagePerHour;
            WorkingDaysPerMonth = workingDaysPerMonth;
            WorkingHoursPerDay = workingHoursPerDay;
        }
    }
}
