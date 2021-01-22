using System;

namespace AnuitexConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager() { Name = "John", ExperienceInYears = 12 };
            Taskmaster t = new Taskmaster() { Name = "David", ExperienceInYears = 12 };
            Worker w = new Worker() { Name = "Michael", ExperienceInYears = 16 };
            Worker x = new Worker() { Name = "Chris", ExperienceInYears = 12 };
            Worker y = new Worker() { Name = "Stephen", ExperienceInYears = 12 };
            Worker z = new Worker() { Name = "Peter", ExperienceInYears = 12 };
            m.Work();
            t.Work();
            w.Work();
            m.GiveAssingment();
            t.CheckWorkers();

            Company c = new Company();
            bool a = c + m;
            a = c + w;
            a = c + t;
            a = c + x;
            a = c + y;
            a = c + z;
            Console.WriteLine("managers:" + c.GetEmployeesCount<Manager>());
            Console.WriteLine("workers:" + c.GetEmployeesCount<Worker>());
            Console.WriteLine("taskmasters:" + c.GetEmployeesCount<Taskmaster>());
            if (c.Contains(new Worker() { Name = "Michael", ExperienceInYears = 16 }))
            {
                c.PrintEmployees();
            }
        }
    }
}
