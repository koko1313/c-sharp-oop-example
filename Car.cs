using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_oop_example
{
    class Car : WheeledVehicle
    {
        private int doorsCount;

        public Car(int peopleCapacity, int weight, int wheelsCount, int doorsCount) : base(peopleCapacity, weight, wheelsCount)
        {
            this.doorsCount = doorsCount;
        }
    }
}
