using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuitexConsoleApp
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ExperienceInYears { get; set; }

        public abstract void Work();
    }
}
