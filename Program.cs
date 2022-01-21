using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of C# OOP!  Let the games begin ;)");

            Vehicle myVehicle = new Vehicle(7);
            System.Console.WriteLine($"My Vehicle is holding {myVehicle.NumPassengers} people.");
            Vehicle secondVehicle = new Vehicle();
            System.Console.WriteLine($"Second vehicle is holding {secondVehicle.NumPassengers} people");
        }
    }

    public class Vehicle
    {
        //Fields
        public int NumPassengers;
        string color;
        double maxSpeed;

        // Construstors
        public Vehicle(int val)
        {
            NumPassengers = val;
        }
        public Vehicle(){
            NumPassengers = 5;
        }

        // Methods
        public void MakeNoise(string noise) {
            System.Console.WriteLine(noise);
        }
        // Method overload
        public void MakeNoise(){
            System.Console.WriteLine("Beep!");
        }


    }


}
