using System.Collections.Generic;
using System.Linq;

namespace AnuitexConsoleApp
{
    public class Company
    {
        public List<Employee> Emplyees { get; }

        public Company()
        {
            Emplyees = new List<Employee>();
        }
        public static bool operator +(Company company, Employee employee)
        {
            company.Emplyees.Add(employee);

            return true;
        }
        public static bool operator -(Company company, Employee emplyee)
        {
            if (company.Emplyees.Contains(emplyee))
            {
                company.Emplyees.Remove(emplyee);

                return true;
            }

            return false;
        }

        public IEnumerable<Employee> GetEmployees<TEmployee>()
        {
            return Emplyees.Where(x => x is TEmployee);
        }

        public int GetEmployeesCount<TEmployee>()
        {
            return Emplyees.Where(x => x is TEmployee).Count();
        }
    }
}
