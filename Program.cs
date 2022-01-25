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

            Person person = new Person();
            person.AddToVehicles(myVehicle);
            person.AddToVehicles(secondVehicle);
            person.AddToVehicles(newCar);
            person.AddToVehicles(anotherCar);
            person.DisplayVehicles();
            
        }
    }

}
