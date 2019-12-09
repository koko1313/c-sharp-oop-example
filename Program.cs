using System;

namespace c_sharp_oop_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(5, 2500, 4, 5);
            Bicycle bicycle1 = new Bicycle(1, 10, 2, "Red");
            Airplane airplane1 = new Airplane(500, 50000, 2, 2);

            StartMoving(car1);
            StartMoving(bicycle1);
            StartMoving(airplane1);

            void StartMoving(Vehicle movableThing)
            {
                movableThing.Move();
            }
        }
    }
}
