using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    public class Worker: Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        {
            FirstName = firstName;
            LastName = lastName;
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return WeekSalary / 5 / WorkHoursPerDay;
        }
    }
}
