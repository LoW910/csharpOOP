using System.Collections.Generic;

namespace OOP
{
    class Person
    {
        public List<Vehicle> OwnedVehicles;
        
        public Person(){
            OwnedVehicles = new List<Vehicle>();
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