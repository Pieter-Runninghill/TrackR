using TrackR.Models;

namespace TrackR.Services.Interface
{
    public interface IClientLocationService
    {
        Task<List<ClientLocation>> GetAllClientLocations();

        Task<ClientLocation> GetClientLocationById(int id);
    }
}
