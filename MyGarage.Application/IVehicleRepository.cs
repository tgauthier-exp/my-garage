using MyGarage.Domain;

namespace MyGarage.Application
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetAllVehicles();

        List<Vehicle> GetVehiclesByType(string type);

        List<Vehicle> GetVehiclesByBrand(string brand);
    }
}
