namespace OOP
{
    public class Vehicle
        {
            //Fields
            public int NumPassengers;
            public string Color;
            protected double Odometer;

            // Construstors
            public Vehicle(int numPas, string col)
            {
                NumPassengers = numPas;
                Color = col;
                Odometer = 0;
            }
            public Vehicle(string col){
                Color = col;
                NumPassengers = 5;
                Odometer = 0;
            }

            // Methods
            public void MakeNoise(string noise) {
                System.Console.WriteLine(noise);
            }
            // Method overload
            public void MakeNoise(){
                System.Console.WriteLine("Beep!");
            }

            public virtual void GetInfo(){
                System.Console.WriteLine($"Number of passangers: {NumPassengers}");
                System.Console.WriteLine($"Color: {Color}");
                System.Console.WriteLine($"Miles: {Odometer}");
            }
        }
}