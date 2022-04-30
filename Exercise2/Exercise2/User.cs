using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class User : Education
    {
        protected string _name;
        protected int _age;
        DateTime thisDay = DateTime.Today;

        public void SetName(string name)
        {
            _name = name;
        }

        public void GetName()
        {
            Console.WriteLine(_name);
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void GetAge()
        {
            Console.WriteLine(_age);

        }

        public override void PrintTodayDate()
        {
            Console.WriteLine(thisDay.ToString("D"));
        }

        public virtual void CalculateSum(int x, int y)
        {
            Console.WriteLine("The sum is: " + (x + y));
        }
    }
}
