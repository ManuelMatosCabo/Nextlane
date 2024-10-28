using System;
using Nextlane.Sections.Section1;
using Nextlane.Sections.Section2;
using Nextlane.Sections.Section2.Static_InstanceMethods;
using Nextlane.Sections.Section2.Vehicle_Car;

namespace NextlaneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing SingletonPattern
            var optimizer = RouteOptimizer.GetInstance();
            optimizer.OptimizeRoute("Location A", "Location B");
            optimizer.OptimizeRoute("Location C", "Location D");
            Console.WriteLine($"Both optimizer instances are the same: {ReferenceEquals(optimizer, RouteOptimizer.GetInstance())}\n");

            // Testing Reverse
            string route = "A-B-C-D";
            Console.WriteLine($"Original Route: {route}");
            Console.WriteLine($"Reversed Route: {Reverse.ReverseString(route)}\n");

            // Testing LogisticsUtilities
            Console.WriteLine($"Distance between locations: {LogisticsUtilities.CalculateDistance(34.0522, -118.2437, 36.1699, -115.1398)} km\n");

            // Testing DeliveryTruck
            var truck = new DeliveryTruck { MaxLoad = 1000, CurrentLoad = 600 };
            Console.WriteLine($"Remaining load capacity: {truck.CalculateRemainingLoad()} kg\n");

            // Testing ExceptionHandling
            var routeHandler = new RouteHandler();
            string[] routes = { "A-B-C", null, "D-E-F", "", "G-H-I" };

            foreach (var r in routes)
            {
                try
                {
                    routeHandler.PrintRoute(r);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"Warning: {ex.Message}. Route skipped.");
                }
            }

            Console.WriteLine("Program continues running...\n");

            // Testing Vehicle and Car Classes
            Car myCar = new Car("Toyota", "Camry", 2022, "Gasoline");
            Console.WriteLine(myCar);

            // Calculating fuel efficiency
            double distance = 300; 
            double fuelConsumed = 15;

            try
            {
                double efficiency = myCar.CalculateFuelEfficiency(distance, fuelConsumed);
                Console.WriteLine($"Fuel Efficiency: {efficiency} km/l");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
