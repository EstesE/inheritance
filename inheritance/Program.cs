using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent
            Console.WriteLine("-- inheritance (all three examples inherit from the 'Vehicle' class) --\n\n");

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine("Car:");
            Console.WriteLine($"speed: {car.speed}");
            Console.WriteLine($"wheels: {car.wheels}");
            car.go();

            Console.WriteLine("\nBicycle:");
            Console.WriteLine($"speed: {bicycle.speed}");
            Console.WriteLine($"wheels: {bicycle.wheels}");
            bicycle.go();

            Console.WriteLine("\nBoat:");
            Console.WriteLine($"speed: {boat.speed}");
            Console.WriteLine($"wheels: {boat.wheels}");
            boat.go();

            Console.ReadLine();
        }

        class Vehicle
        {
            public int speed = 0;

            public void go()
            {
                Console.WriteLine("This vehicle is moving!");
            }
        }

        class Car : Vehicle
        {
            public int wheels = 4;
        }

        class Bicycle : Vehicle
        {
            public int wheels = 2;
        }

        class Boat : Vehicle
        {
            public int wheels = 0;
        }
    }
}
