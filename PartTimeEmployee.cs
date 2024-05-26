using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public class PartTimeEmployee : IEmployee
    {
        private int totalHoursWorked;
        private double ratePerHour;

        public int TotalHouseWorked
        {
            get 
            { 
                return totalHoursWorked; 
            }
            set 
            {
                totalHoursWorked = value; 
            }
        }

        public double RatePerHour
        {
            get
            {
                return ratePerHour;
            }
            set
            {
                ratePerHour = value;
            }
        }

        public double ComputeSalary()
        {
            return totalHoursWorked * ratePerHour;
        }

        public double ComputeSalary(int TotalHoursworked, double RatePerHour)
        {
            throw new NotImplementedException();
        }
    }
}

