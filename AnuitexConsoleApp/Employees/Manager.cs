using System;

namespace AnuitexConsoleApp
{
    public class Manager : Employee
    {
        public void CollectOrders()
        {

        }
        public override void Work()
        {
            CollectOrders();
        }
        public void GiveAssingment()
        {
            Console.WriteLine("Assignment given");
        }
    }
}
