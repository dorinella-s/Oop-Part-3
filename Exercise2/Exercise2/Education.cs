using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public abstract class Education
    {
        public abstract void PrintTodayDate();

        public void PrintText()
        {
            Console.WriteLine("Text from abstract class");
        }

        public void PrintText(string text)
        {
            Console.WriteLine("This is overloading of the method PrintText, here we display your text: \n" + text);
        }
    }
}
