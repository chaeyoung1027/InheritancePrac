using System;

namespace InheritancePrac
{
    internal class Dog
    {
        public int Age { get;set;}
        public String Color { get; set; }
        
        public Dog() { this.Age = 0; }

        internal void Bark()
        {
            Console.WriteLine("왈왈");
        }

        internal void Eat()
        {
            Console.WriteLine("냠냠");
        }

        internal void Sleep()
        {
            Console.WriteLine("쿨쿨");
        }
    }
}