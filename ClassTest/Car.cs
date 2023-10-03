using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Car
    {
        public string Color;
        public string Make;
        public string Model;
        public string RegNo;

        public Car(string newColor, string newMake, string newModel)
        {
            Color = newColor;
            Make = newMake;
            Model = newModel;
            RegNo = "(No registation number added)";
        }

        public void Drive()
        {
            Console.WriteLine($"This is a {Make} driving. Brumbrum!");
        }

        public void Announce()
        {
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Registration number: " + RegNo);
        }
    }
}
