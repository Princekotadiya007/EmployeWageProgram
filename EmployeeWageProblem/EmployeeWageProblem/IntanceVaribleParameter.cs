using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class IntanceVaribleParameter
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;

        // By difulat varible is Private
        string CompanyName;
        int EMP_RATE_PER_HRS;
        int NUM_OF_WORKING_DAYS ;
        int MAX_RATE_IN_MONTH;
        int totalEmpWage;

        public  IntanceVaribleParameter(string CompanyName, int EMP_RATE_PER_HRS, int NUM_OF_WORKING_DAYS, int MAX_RATE_IN_MONTH)
        {
            this.CompanyName = CompanyName;
            this.EMP_RATE_PER_HRS = EMP_RATE_PER_HRS;
            this.NUM_OF_WORKING_DAYS = NUM_OF_WORKING_DAYS;
            this.MAX_RATE_IN_MONTH = MAX_RATE_IN_MONTH;
        }
        public void ComputeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);


            while (totalEmpHrs < MAX_RATE_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                switch (empCheck)
                {
                    case IS_PARTTIME:
                        empHrs = 4;
                        break;
                    case IS_FULLTIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine(totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            int totalEmpWages = totalEmpHrs * this.EMP_RATE_PER_HRS;
            Console.WriteLine("Total Employee wages:" + CompanyName + "is :" + totalEmpWages);
        }

        public string toString()
        {
            return "Total Emp Wage for Compny :" +this.CompanyName + "is :" + this.totalEmpWage;
        }
    }
}
