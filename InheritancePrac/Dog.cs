using InheritancePrac32;
using System;

namespace InheritancePrac
{
    public class Dog:Animal
    {
        public String Color { get; set; }
        
        public void Bark()
        {
            Console.WriteLine("왈왈");
        }
        public void TestB()
        {
            //Private();
            Protected();
            Public();
        }
    }
}