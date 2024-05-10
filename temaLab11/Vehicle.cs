using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using temaLab11.Interfaces;

namespace temaLab11
{
    public abstract class Vehicle : IFuelable
    {
        public required string Model { get; set; }
        public Guid Id { get; } = Guid.NewGuid(); 
        public abstract double MaxCapacity { get; } 

        public abstract void Describe();

        public virtual void Refuel(double amount, FuelType fuelType)
        {
        }
    }
}
