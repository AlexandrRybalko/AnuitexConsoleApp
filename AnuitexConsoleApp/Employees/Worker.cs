using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuitexConsoleApp
{
    public class Worker : Employee
    {
        public void Produce()
        {

        }
        public override void Work()
        {
            Produce();
        }
    }
}
