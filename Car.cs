namespace OOP
{
    class Car : Vehicle, IRideable
    {
        public string Make;
        public string Model;
        public void Ride(double distance){
            System.Console.WriteLine("I am driving!!!");
            DistanceTraveled += distance;
        }

        public double DistanceTraveled {
            get{
                return Odometer;
            }
            set {
                Odometer = value;
                }
        }

        public Car(string color, string make, string model) : base(color)
        {
            Make = make;
            Model = model;
        }

        public override void GetInfo(){
            // this line calls the parent version of this method
            base.GetInfo();
            // extends functionality of parent method
            System.Console.WriteLine($"Make: {Make}");
            System.Console.WriteLine($"Model: {Model}");
        }

        public void Drive(double distance) {
            Odometer += distance;
            System.Console.WriteLine($"I'm driving!");
        }
    }
}