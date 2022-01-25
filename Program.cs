using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of C# OOP!  Let the games begin ;)");

            Vehicle myVehicle = new Vehicle(7, "Yellow");
            // myVehicle.GetInfo();
            Vehicle secondVehicle = new Vehicle("Purple");
            // secondVehicle.GetInfo();
            Car newCar = new Car("Blue", "Ford", "F250" );
            Car anotherCar = new Car("Red", "Tesla", "D Class");
            // newCar.GetInfo();
            // anotherCar.GetInfo();
            newCar.Drive(15);
            newCar.Drive(15);
            newCar.Drive(15);
            // newCar.GetInfo();
            List<Vehicle> vehicles = new List<Vehicle>();

            Person person = new Person("Tom", newCar);
            person.AddToVehicles(myVehicle);
            person.AddToVehicles(secondVehicle);
            person.AddToVehicles(newCar);
            person.AddToVehicles(anotherCar);
            person.DisplayVehicles();
            
            IRideable[] variousRideables = new IRideable[]{
                new Car("Pink", "Dodge", "1500"),
                new Car("Orange", "Toyota", "Tundra"),
                new Horse("Silver Queen", 100),
                new Horse("Betty", 75),
            };
            foreach (var rideable in variousRideables)
            {
                rideable.Ride(50);
            }
        }
    }

}
