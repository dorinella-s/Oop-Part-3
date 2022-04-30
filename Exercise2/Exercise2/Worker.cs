using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Worker : User
    {
        private int _salary;

        public Worker(string name, int age, int salary)
        {
            base._name = name;
            base._age = age;
            _salary = salary;
        }

        public void SetSalary(int salary)
        {
            _salary = salary;
        }
        public int GetSalary()
        {
            return _salary;

        }

    }
}
