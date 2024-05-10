using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaLab11.Model
{
    public class DieselVehicle : Vehicle
    {
        public override double MaxCapacity => 75;
        public override void Describe()
        {
            Console.WriteLine($"Diesel Vehicle: Model - {Model}, ID - {Id}");
        }

        public override void Refuel(double amount, FuelType fuelType)
        {
            if (fuelType != FuelType.Diesel)
                throw new ArgumentException("Incompatible fuel type for Diesel Vehicle");
        }
    }
}
