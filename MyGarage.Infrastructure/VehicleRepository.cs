using MyGarage.Application;
using MyGarage.Domain;

namespace MyGarage.Infrastructure
{
    public class VehicleRepository : IVehicleRepository
    {
        public static readonly List<Vehicle> lstVehicles =
        [
            // Peugeot
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "104" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "204" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "205" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "304" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "305" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "309" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "403" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "404" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "504" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "505" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "604" },
            new Vehicle { Type = "Car", Brand = "Peugeot", Model = "605" },
            // Renault
            new Vehicle { Type = "Car", Brand = "Renault", Model = "4" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "5" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "6" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "7" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "8" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "10" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "11" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "12" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "14" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "16" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "18" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "20" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "21" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "25" },
            new Vehicle { Type = "Car", Brand = "Renault", Model = "30" },
            // Kawasaki
            new Vehicle { Type = "Motorcycle", Brand = "Kawasaki", Model = "250 S1" },
            new Vehicle { Type = "Motorcycle", Brand = "Kawasaki", Model = "250 KH" },
            new Vehicle { Type = "Motorcycle", Brand = "Kawasaki", Model = "350 S2" },
            new Vehicle { Type = "Motorcycle", Brand = "Kawasaki", Model = "400 S3" },
            new Vehicle { Type = "Motorcycle", Brand = "Kawasaki", Model = "400 KH" },
            new Vehicle { Type = "Motorcycle", Brand = "Kawasaki", Model = "500 H1" },
            new Vehicle { Type = "Motorcycle", Brand = "Kawasaki", Model = "500 KH" },
            new Vehicle { Type = "Motorcycle", Brand = "Kawasaki", Model = "750 H2" },
            // Yamaha
            new Vehicle { Type = "Motorcycle", Brand = "Yamaha", Model = "350 RD" },
            new Vehicle { Type = "Motorcycle", Brand = "Yamaha", Model = "400 RD" },
            new Vehicle { Type = "Motorcycle", Brand = "Yamaha", Model = "500 XT" },
            new Vehicle { Type = "Motorcycle", Brand = "Yamaha", Model = "650 XS" }
        ];

        public List<Vehicle> GetAllVehicles()
        {
            return lstVehicles;
        }

        public List<Vehicle> GetVehiclesByType(string type)
        {
            return lstVehicles.Where(v => string.Equals(v.Type, type, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public List<Vehicle> GetVehiclesByBrand(string brand)
        {
            return lstVehicles.Where(v => string.Equals(v.Brand, brand, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }
    }
}
