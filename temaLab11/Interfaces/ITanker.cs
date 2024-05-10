using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace temaLab11.Interfaces
{
    public interface ITanker
    {
        void Load(double amount, FuelType fuelType);
        void FuelVehicle(Vehicle vehicle, double amount, FuelType fuelType);
    }
}
