using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class CompanyEmpWageUC10
    {
        public string companyName;
        public int wagePerHour;
        public int maxWorkingDays;
        public int maxWorkingHours;
        public int totalWage;

        public CompanyEmpWageUC10(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
            this.totalWage = 0;
        }
    }
    public class EmpWageBuilder
    {
        private List<CompanyEmpWageUC10> companyEmpWageList;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new List<CompanyEmpWageUC10>();
        }

        public void AddCompanyEmpWage(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            CompanyEmpWageUC10 companyEmpWage = new CompanyEmpWageUC10(companyName, wagePerHour, maxWorkingDays, maxWorkingHours);
            this.companyEmpWageList.Add(companyEmpWage);
        }

        public void ComputeEmployeeWage()
        {
            foreach (CompanyEmpWageUC10 companyEmpWage in companyEmpWageList)
            {
                int empHours = 0, empWage = 0, totalEmpHours = 0, totalWorkingDays = 0;

                while (totalEmpHours < companyEmpWage.maxWorkingHours && totalWorkingDays < companyEmpWage.maxWorkingDays)
                {
                    totalWorkingDays++;

                    Random random = new Random();
                    int empCheck = random.Next(0, 3);

                    switch (empCheck)
                    {
                        case 1:
                            empHours = 4;
                            break;
                        case 2:
                            empHours = 8;
                            break;
                        default:
                            empHours = 0;
                            break;
                    }

                    totalEmpHours += empHours;
                    empWage = empHours * companyEmpWage.wagePerHour;
                }

                companyEmpWage.totalWage = empWage * totalWorkingDays;
                Console.WriteLine($"Total employee wage for company {companyEmpWage.companyName} is {companyEmpWage.totalWage}");
            }
        }
    }  
}
