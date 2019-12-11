using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_oop_example
{
    class WheeledVehicle : Vehicle
    {
        private int wheelsCount;

        public WheeledVehicle(int peopleCapacity, int weight, int wheelsCount) : base(peopleCapacity, weight)
        {
            this.wheelsCount = wheelsCount;
        }
    }
}
