using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nextlane.Sections.Section2
{
    public class RouteHandler
    {
        public void PrintRoute(string route)
        {
            if (string.IsNullOrEmpty(route))
            {
                throw new ArgumentNullException(nameof(route), "Route cannot be null or empty.");
            }

            Console.WriteLine($"Current Route: {route}");
        }
    }
}
