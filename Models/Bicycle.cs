using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_oop_example
{
    class Bicycle : WheeledVehicle
    {
        private String color;

        public Bicycle(int peopleCapacity, int weight, int wheelsCount, String color) : base(peopleCapacity, weight, wheelsCount)
        {
            this.color = color;
        }
    }
}
