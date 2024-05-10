using temaLab11.Model;
using temaLab11;

Tanker tanker = new Tanker(3000.0);

GasolineVehicle gasolineCar = new GasolineVehicle { Model = "Toyota Camry"};
DieselVehicle dieselTruck = new DieselVehicle { Model = "Ford F-150"};
LPGVehicle lpgCar = new LPGVehicle { Model = "Hyundai Sonata"};
PlugInHybridVehicle hybridCar = new PlugInHybridVehicle { Model = "Prius"};


try
{
    tanker.Load(250, FuelType.Gasoline);
    Console.WriteLine($"Success: Filled up the {nameof(tanker)} with {FuelType.Gasoline}.");
    tanker.FuelVehicle(gasolineCar, 30, FuelType.Gasoline);
    Console.WriteLine($"Success: Filled up the {gasolineCar.Model}, Car FuelType: {FuelType.Gasoline}, (ID: {gasolineCar.Id}, Max Capacity: {gasolineCar.MaxCapacity} liters).");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
try {
    tanker.Load(500, FuelType.Diesel);
    Console.WriteLine($"Success: Filled up the {nameof(tanker)} with {FuelType.Diesel}.");
    tanker.FuelVehicle(dieselTruck, 70, FuelType.Diesel);
    Console.WriteLine($"Success: Filled up the {dieselTruck.Model}, Car FuelType: {FuelType.Diesel} (ID: {dieselTruck.Id}, Max Capacity: {dieselTruck.MaxCapacity} liters).");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
try{tanker.Load(400, FuelType.LPG);
    tanker.FuelVehicle(lpgCar, 50, FuelType.LPG);
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
try
{
    tanker.Load(300, FuelType.Electricity);
    tanker.FuelVehicle(hybridCar, 100, FuelType.Electricity);
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}


