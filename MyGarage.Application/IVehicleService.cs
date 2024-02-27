using MyGarage.Domain;

namespace MyGarage.Application
{
    //This interface is use for Bussiness Rule / USE CASE
    public interface IVehicleService
    {
        List<Vehicle> GetAllVehicles();

        List<Vehicle> GetVehiclesByType(string type);

        List<Vehicle> GetVehiclesByBrand(string brand);
    }
}
