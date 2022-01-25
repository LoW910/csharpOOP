namespace OOP
{
    class Car : Vehicle
    {
        public string Make;
        public string Model;

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