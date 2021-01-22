using System;
using System.Linq;

namespace AnuitexConsoleApp
{
    public static class CompanyExtension
    {
        public static bool Contains(this Company company, Employee emplyee)
        {
            if(company.Emplyees.Any(x => x.Name.Equals(emplyee.Name) && x.ExperienceInYears == emplyee.ExperienceInYears))
            {
                return true;
            }

            return false;
        }

        public static void PrintEmployees(this Company company)
        {
            foreach(var employee in company.Emplyees)
            {
                Console.WriteLine($"Name: {employee.Name}, experience: {employee.ExperienceInYears};");
            }
        }
    }
}
