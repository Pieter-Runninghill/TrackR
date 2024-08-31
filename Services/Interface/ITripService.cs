using TrackR.Models;
using TrackR.Models.RequestModel;
using TrackR.Models.ResponseModel;

namespace TrackR.Services.Interface
{
    public interface ITripService
    {
        Task<List<Trip>> GetAllTripsByUser(int userId);

        Task<Trip> GetTripById(int id);

        Task<ResponseModel> Create(Trip entity);

        Task<Trip> CreateTrip(TripRequest request);

    }
}
