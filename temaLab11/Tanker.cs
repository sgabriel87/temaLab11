using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using temaLab11.Interfaces;
using temaLab11.Model;

namespace temaLab11
{
    public class Tanker : ITanker
    {
        private double capacity;
        private double currentLoad;

        public Tanker(double capacity)
        {
            this.capacity = capacity;
        }

        public void Load(double amount, FuelType fuelType)
        {
            if (currentLoad + amount > capacity)
                throw new OverflowException("Tanker capacity exceeded");
            
        }

        public void FuelVehicle(Vehicle vehicle, double amount, FuelType fuelType)
        {
            if (amount > vehicle.MaxCapacity)
                throw new ArgumentException("Fuel amount exceeds vehicle capacity");

            if (vehicle is GasolineVehicle && fuelType != FuelType.Gasoline)
                throw new ArgumentException("Incompatible fuel type for Gasoline Vehicle");

            if (vehicle is DieselVehicle && fuelType != FuelType.Diesel)
                throw new ArgumentException("Incompatible fuel type for Diesel Vehicle");

            if (vehicle is LPGVehicle && (fuelType != FuelType.LPG && fuelType != FuelType.Gasoline))
                throw new ArgumentException("Incompatible fuel type for LPG Vehicle");

            if (vehicle is PlugInHybridVehicle && (fuelType != FuelType.Gasoline && fuelType != FuelType.Electricity))
                throw new ArgumentException("Incompatible fuel type for Plug-In Hybrid Vehicle");

            vehicle.Refuel(amount, fuelType);
        }
    }
}
