using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_oop_example
{
    class Human : IMovable
    {
        String name;

        public Human(string name)
        {
            this.name = name;
        }

        public void Move()
        {
            Console.WriteLine("I am human. I will start waling right now! Also my name is " + name);
        }
    }
}
