using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaLab11.Model
{
    public class PlugInHybridVehicle : Vehicle
    {
        public override double MaxCapacity => 200;

        public override void Refuel(double amount, FuelType fuelType)
        {
            if (fuelType != FuelType.Gasoline && fuelType != FuelType.Electricity)
                throw new ArgumentException("Incompatible fuel type for Plug-In Hybrid Vehicle");
        }

        public override void Describe()
        {
            Console.WriteLine($"Plug-In Hybrid Vehicle: Model - {Model}, ID - {Id}");
        }
    }

}
