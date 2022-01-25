namespace OOP
{
    class Horse : IRideable
    {
        public string Name;
        public double Endurance;

        public void Ride(double distance){
            System.Console.WriteLine("Neeeayyyyh I'm riding!!!");
            if(distance >= Endurance) distance = Endurance;
            DistanceTraveled += distance;
        }
        public double DistanceTraveled {get;set;}


        public Horse(string name, double endurance) {
            Name = name;
            Endurance = endurance;
            DistanceTraveled = 0;
        }
    }
}