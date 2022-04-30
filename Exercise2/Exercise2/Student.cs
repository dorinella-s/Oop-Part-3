using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Student : User
    {
        private int _scholarship;
        private string _course;

        public Student(string name, int age, int bourse, string course)
        {
            _scholarship = bourse;
            _course = course;
            base._name = name;
            base._age = age;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Info about student: " + _name + "\nCourse name - " + _course + "\nScloarship in $ = " + _scholarship);
        }

        public override void CalculateSum(int x, int y)
        {
            Console.WriteLine("The diference is: " + (x - y));
        }
    }
}
