using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nextlane.Sections.Section2.Static_InstanceMethods
{
    public class LogisticsUtilities
    {
        // Static method to calculate distance between two locations (in kilometers)
        public static double CalculateDistance(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            // Placeholder logic for distance calculation
            return Math.Sqrt(Math.Pow(latitude2 - latitude1, 2) + Math.Pow(longitude2 - longitude1, 2));
        }
    }
}
