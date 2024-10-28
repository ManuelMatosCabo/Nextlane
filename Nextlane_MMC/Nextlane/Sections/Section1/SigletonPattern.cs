using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nextlane.Sections.Section1
{
    public class RouteOptimizer
    {
        private static RouteOptimizer? instance;
        private static readonly object lockObject = new object();

        // Private constructor to prevent external instantiation
        private RouteOptimizer()
        {
            Console.WriteLine("Route Optimizer initialized.");
        }

        // Public method to retrieve the Singleton instance
        public static RouteOptimizer GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new RouteOptimizer();
                    }
                }
            }
            return instance;
        }

        // Example method to optimize a route
        public void OptimizeRoute(string startLocation, string endLocation)
        {
            // Placeholder logic for route optimization
            Console.WriteLine($"Calculating optimal route from {startLocation} to {endLocation}.");
        }
    }
}
