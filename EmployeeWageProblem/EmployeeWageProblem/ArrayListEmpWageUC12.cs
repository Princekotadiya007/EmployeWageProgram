using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class ArrayListEmpWageUC12
    {
        // Declare an ArrayList to store company details
        ArrayList companyList;

        // Constructor to initialize the ArrayList
        public ArrayListEmpWageUC12()
        {
            companyList = new ArrayList();
        }

        // Method to add a company to the ArrayList
        public void AddCompanys(string name, int wagePerHour, int workingDaysPerMonth, int workingHoursPerDay)
        {
            companyList.Add(new Companys(name, wagePerHour, workingDaysPerMonth, workingHoursPerDay));
        }

        // Method to compute the wages for all the companies in the ArrayList
        public void ComputeWage()
        {
            foreach (Companys company in companyList)
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
    class Companys
    {
        public string Name { get; set; }
        public int WagePerHour { get; set; }
        public int WorkingDaysPerMonth { get; set; }
        public int WorkingHoursPerDay { get; set; }

        public Companys(string companyName, int wagePerHour, int workingDaysPerMonth, int workingHoursPerDay)
        {
            Name = companyName;
            WagePerHour = wagePerHour;
            WorkingDaysPerMonth = workingDaysPerMonth;
            WorkingHoursPerDay = workingHoursPerDay;
        }
    }
}

