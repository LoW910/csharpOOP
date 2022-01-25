using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of C# OOP!  Let the games begin ;)");

            Vehicle myVehicle = new Vehicle(7, "Yellow");
            myVehicle.GetInfo();
            Vehicle secondVehicle = new Vehicle("Purple");
            secondVehicle.GetInfo();
            Car newCar = new Car("Blue", "Ford", "F250" );
            Car anotherCar = new Car("Red", "Tesla", "D Class");
            newCar.GetInfo();
            anotherCar.GetInfo();
            newCar.Drive(15);
            newCar.Drive(15);
            newCar.Drive(15);
            newCar.GetInfo();
        }
    }

}
