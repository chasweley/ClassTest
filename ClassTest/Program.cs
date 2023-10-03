namespace ClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("blue", "Jaguar", "I-PACE");

            myCar.RegNo = "ABC123";

            Car familyCar = new Car("red", "Skoda", "Octavia");

            Console.WriteLine("My car is a " + myCar.Color + " " + myCar.Make + " of the model " + myCar.Model + ".");
            Console.WriteLine("The family car is a " + familyCar.Color + " " + familyCar.Make + " of the model " + familyCar.Model + ".");

            Console.WriteLine();
            
            myCar.Drive();
            familyCar.Drive();

            Console.WriteLine();

            myCar.Announce();

            Console.WriteLine();

            familyCar.Announce();

            Console.WriteLine("--------------------------------");

            Animal myAnimal = new Animal("Essmi");

            myAnimal.MakeNoise();
        }
    }
}