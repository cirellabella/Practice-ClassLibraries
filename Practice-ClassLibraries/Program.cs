using System.Numerics;
using ClassLibrary1;

namespace Practice_ClassLibraries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle vehicle = new Vehicle("Purple");
            Air air = new Air("Yellow");
            Helicopter helicopter = new Helicopter("Pink", 5);
            ClassLibrary1.Plane plane = new ClassLibrary1.Plane("Chartreuse", 4);
            Sea sea = new Sea("Orange", "Sailboat");
            Land land = new Land("Amethyst", 3);

            vehicles.Add(vehicle);
            vehicles.Add(air);
            vehicles.Add(helicopter);
            vehicles.Add(plane);
            vehicles.Add(sea);
            vehicles.Add(land);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v);
            }
        }
    }
}