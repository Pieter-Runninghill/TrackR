using System.Net.Http.Json;
using TrackR.Helpers;
using TrackR.Models;
using TrackR.Models.RequestModel;
using TrackR.Models.ResponseModel;
using TrackR.Services.Interface;

namespace TrackR.Services
{
    public class TripService : ITripService
    {
        private readonly HttpClient _httpClient;

        public TripService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(ApiConfig.BaseAddress);
        }

        public async Task<ResponseModel> Create(Trip entity)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();

                var jsoncontent = JsonContent.Create(entity);
                var response = await _httpClient.PostAsync("Trip", jsoncontent);

                if(response.IsSuccessStatusCode)
                {
                    responseModel.Success = true;
                    responseModel.Message = "Succesfully Logged Trip";
                }
                else
                {
                    responseModel.Success = false;
                    responseModel.Message = "Could not create trip";
                }

                return responseModel;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Trip> CreateTrip(TripRequest request)
        {
            try
            {
                Trip trip = new Trip();

                var jsoncontent = JsonContent.Create(request);
                var createTripDetais = await _httpClient.PostAsync("Trip/createTrip", jsoncontent);

                if (createTripDetais.IsSuccessStatusCode)
                {
                    var response = await createTripDetais.Content.ReadFromJsonAsync<Trip>();

                    if(response != null)
                    {
                        trip = response;
                    }
                }

                return trip;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<List<Trip>> GetAllTripsByUser(int userId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"Trip/getTripsByUserId/{userId}");

                if (response.IsSuccessStatusCode)
                {
                    var trips = await response.Content.ReadFromJsonAsync<List<Trip>>();

                    if(trips != null)
                    {
                        return trips;
                    }
                }
                
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Trip> GetTripById(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"Trip/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var trip = await response.Content.ReadFromJsonAsync<Trip>();

                    if (trip != null)
                    {
                        return trip;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
