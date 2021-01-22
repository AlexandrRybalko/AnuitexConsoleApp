using System;

namespace AnuitexConsoleApp
{
    public class Taskmaster : Employee
    {
        public void BuyMaterials()
        {

        }
        public override void Work()
        {
            BuyMaterials();
        }
        public void CheckWorkers()
        {
            Console.WriteLine("Workers have been checked");
        }
    }
}
