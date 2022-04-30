using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("John", 25, 1000);
            Worker worker2 = new Worker("Ivan", 25, 1000);
            Worker worker3 = new Worker("Vasya", 26, 2000);
            Student st1 = new Student("Amelie", 21, 300, "Computer Science");
            User us1 = new User();

            us1.SetName("Admin");

            //worker3.SetName("Vasya");
            //worker3.SetAge(26);
            //worker3.SetSalary(2000);
            worker1.PrintTodayDate();
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("The sum of Ivan and Vasya salaries: " + (worker2.GetSalary() + worker3.GetSalary()));
            Console.WriteLine("_________________");
            st1.PrintStudentInfo();

            Console.WriteLine("\n----------------------------------");
            st1.CalculateSum(8, 4);
            us1.CalculateSum(8, 4);
            Console.WriteLine("\n----------------------------------");
            st1.PrintTodayDate();
            Console.WriteLine("\n----------------------------------");
            st1.PrintText();
            st1.PrintText("Good Job!");

        }
    }
}
