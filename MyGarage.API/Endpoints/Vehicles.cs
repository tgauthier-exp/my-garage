using MyGarage.Application;
using MyGarage.Domain;

namespace MyGarage.API.Endpoints
{
    /// <summary>
    /// Vehicles endpoints
    /// </summary>
    public static class Vehicles
    {
        /// <summary>
        /// All vehicles endpoints
        /// </summary>
        /// <param name="endpoints"></param>
        public static void MapVehicles(this IEndpointRouteBuilder endpoints)
        {
            var group = endpoints
                .MapGroup("/vehicles")
                .WithTags("Vehicles")
                .WithOpenApi();

            group
                .MapGet("", (IVehicleService vehicleService) =>
                {
                    var vehicles = vehicleService.GetAllVehicles();
                    return Results.Ok(vehicles);
                })
                .WithName("GetVehicles")
                .Produces<List<Vehicle>>()
                .WithOpenApi();

            group
                .MapGet("/type/{type}", (string type, IVehicleService vehicleService) =>
                {
                    var vehicles = vehicleService.GetVehiclesByType(type);
                    return Results.Ok(vehicles);
                })
                .WithName("GetVehiclesByType")
                .Produces<List<Vehicle>>()
                .WithOpenApi();

            group
                .MapGet("/brand/{brand}", (string brand, IVehicleService vehicleService) =>
                {
                    var vehicles = vehicleService.GetVehiclesByBrand(brand);
                    return Results.Ok(vehicles);
                })
                .WithName("GetVehiclesByBrand")
                .Produces<List<Vehicle>>()
                .WithOpenApi();
        }
    }
}
