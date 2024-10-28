using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nextlane.Sections.Section2.Vehicle_Car
{
    public class Car : Vehicle
    {
        public string FuelType { get; set; }

        public Car(string brand, string model, int year, string fuelType)
            : base(brand, model, year)
        {
            FuelType = fuelType;
        }

        // Method to calculate fuel efficiency based on distance and fuel consumption
        public double CalculateFuelEfficiency(double distance, double fuelConsumed)
        {
            if (fuelConsumed <= 0)
            {
                throw new ArgumentException("Fuel consumed must be greater than zero.");
            }
            return distance / fuelConsumed; // Efficiency in distance per unit of fuel
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Fuel Type: {FuelType}";
        }
    }
}
