using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nextlane.Sections.Section2.Static_InstanceMethods
{
    public class DeliveryTruck
    {
        public double MaxLoad { get; set; }
        public double CurrentLoad { get; set; }

        // Instance method to calculate remaining load capacity
        public double CalculateRemainingLoad()
        {
            return MaxLoad - CurrentLoad;
        }
    }
}
