using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public interface IEmployee
    {
        double ComputeSalary(int TotalHoursWorked, double RatePerHour);
    }
}
