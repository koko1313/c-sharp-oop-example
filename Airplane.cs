using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_oop_example
{
    class Airplane : FlyableVehicle
    {
        int enginesCount;

        public Airplane(int peopleCapacity, int weight, int wingsCount, int enginesCount) : base(peopleCapacity, weight, wingsCount)
        {
            this.enginesCount = enginesCount;
        }
    }
}
