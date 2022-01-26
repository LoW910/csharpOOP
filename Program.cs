using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of C# OOP!  Let the games begin ;)");

            // // commented because vehicle is now abstract class
            // Vehicle myVehicle = new Vehicle(7, "Yellow");
            // myVehicle.GetInfo();
            // Vehicle secondVehicle = new Vehicle("Purple");
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
            // // commented because vehicle is now abstract class
            // person.AddToVehicles(myVehicle);
            // person.AddToVehicles(secondVehicle);
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


            Horse wilber = new Horse("Wilber", 120);
            Car datsun = new Car("Green", "datson", "c30");

            Person tom = new Person("tommy", wilber);
            tom.GoSomewhere(34);
            tom.GetInfo();
            tom.Transport = datsun;
            tom.GoSomewhere(80);
            tom.GetInfo();
            datsun.GetInfo();


            string[] wordArray = new string[]{
                "Goat", "Bear", "Shark", "Deer"
            };

            List<string> wordList = new List<string>(){
                "Plate", "Cup", "Glass", "Fork"
            };

            LoopingSomeWords(wordArray);
            LoopingSomeWords(wordList);

            static void LoopingSomeWords(IEnumerable<string> someWords) {
                foreach (var word in someWords)
                {
                    System.Console.WriteLine(word);
                }
            }

            newCar.MakeNoise();






        }
    }

}
