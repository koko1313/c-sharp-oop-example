using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_oop_example
{
    abstract class Vehicle : IMovable
    {
        private int peopleCapacity;
        private int weight;

        protected Vehicle(int peopleCapacity, int weight)
        {
            this.peopleCapacity = peopleCapacity;
            this.weight = weight;
        }

        public void Move()
        {
            Console.WriteLine("I am a vehicle and I will start moving as fast as I can. I can transport " + peopleCapacity + " people.");
        }
    }
}
