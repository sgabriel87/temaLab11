using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaLab11.Model
{
    public class GasolineVehicle : Vehicle
    {
        public override double MaxCapacity => 35;
        public override void Describe()
        {
            Console.WriteLine($"Gasoline Vehicle: Model - {Model}, ID - {Id}");
        }

        public override void Refuel(double amount, FuelType fuelType)
        {
            if (fuelType != FuelType.Gasoline)
                throw new ArgumentException("Incompatible fuel type for Gasoline Vehicle");
            
        }
    }
}
