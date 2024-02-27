using MyGarage.Domain;

namespace MyGarage.Application
{
    //Implement Bussiness Rule / USE CASES
    public class VehicleService(IVehicleRepository vehicleRepository) : IVehicleService
    {
        private readonly IVehicleRepository vehicleRepository = vehicleRepository;

        List<Vehicle> IVehicleService.GetAllVehicles()
        {
            return vehicleRepository.GetAllVehicles();
        }

        List<Vehicle> IVehicleService.GetVehiclesByType(string type)
        {
            return vehicleRepository.GetVehiclesByType(type);
        }

        List<Vehicle> IVehicleService.GetVehiclesByBrand(string brand)
        {
            return vehicleRepository.GetVehiclesByBrand(brand);
        }
    }
}
