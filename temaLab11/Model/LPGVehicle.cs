using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaLab11.Model
{
    public class LPGVehicle : Vehicle
    {
        public override double MaxCapacity => 50;
        public override void Describe()
        {
            Console.WriteLine($"LPG Vehicle: Model - {Model}, ID - {Id}");
        }

        public override void Refuel(double amount, FuelType fuelType)
        {
            if (fuelType != FuelType.LPG && fuelType != FuelType.Gasoline)
                throw new ArgumentException("Incompatible fuel type for LPG Vehicle");
            
        }
    }
}
