﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace temaLab11.Interfaces
{
    public interface IFuelable
    {
        void Refuel(double amount, FuelType fuelType);
    }
}
