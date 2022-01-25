using System.Collections.Generic;

namespace OOP
{
    class Person 
    {

        public string Name;
        public double Miles;

        public IRideable Transport;

        public List<Vehicle> OwnedVehicles;
        
        public Person(string name, IRideable trans){
            Name = name;
            Miles = 0;
            Transport = trans;
            OwnedVehicles = new List<Vehicle>();
        }

        public void GoSomewhere(double distance) {
            Transport.Ride(distance);
            Miles += Transport.DistanceTraveled;
        }

        public void AddToVehicles(Vehicle newV){
            OwnedVehicles.Add(newV);
        }

        public void DisplayVehicles() {
            foreach (var v in OwnedVehicles)
            {
                v.GetInfo();
            }
        }
    }
}