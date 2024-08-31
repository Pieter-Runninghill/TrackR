using TrackR.Models;

namespace TrackR.Services.Interface
{
    public interface IClientService
    {
        Task<List<Client>> Getall();

        Task<Client> GetClientById(int id);
    }
}
