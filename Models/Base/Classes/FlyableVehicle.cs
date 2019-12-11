using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_oop_example
{
    class FlyableVehicle : Vehicle
    {
        private int wingsCount;

        public FlyableVehicle(int peopleCapacity, int weight, int wingsCount) : base(peopleCapacity, weight)
        {
            this.wingsCount = wingsCount;
        }
    }
}
