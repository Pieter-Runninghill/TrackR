using System.Net.Http.Json;
using TrackR.Models;
using TrackR.Models.ResponseModel;
using TrackR.Services.Interface;
using TrackR.Helpers;
using TrackR.Models.RequestModel;

namespace TrackR.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(ApiConfig.BaseAddress);
        }

        public async Task<ResponseModel> CreateUser(UserCreateRequest request)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var jsonContent = JsonContent.Create(request);
                var createUser = await _httpClient.PostAsync("Users", jsonContent);

                if(createUser.IsSuccessStatusCode)
                {
                    response.Success = true;
                    response.Message = "Successfully Created User";
                }
                else
                {
                    response.Success = false;
                    response.Message = "Failed to Created User.";
                }

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<User> GetUserByEmail(string emailAddress)
        {
            try
            {
                var response = await _httpClient.GetAsync($"Users/getUserByEmail/{emailAddress}");

                if(response.IsSuccessStatusCode)
                {
                    var user = await response.Content.ReadFromJsonAsync<User>();
                    
                    if(user != null)
                    {
                        return user;
                    }
                }

                return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<List<User>> GetUsers()
        {
            try
            {
                var response = await _httpClient.GetAsync("Users");

                if (response.IsSuccessStatusCode)
                {
                    var users = await response.Content.ReadFromJsonAsync<List<User>>();

                    if (users != null)
                    {
                        return users;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<ResponseModel> Update(User entity)
        {
            try
            {
                ResponseModel response = new ResponseModel();

                var jsonContent = JsonContent.Create(entity);
                var repsonse = await _httpClient.PutAsync("Users", jsonContent);

                if (repsonse.IsSuccessStatusCode)
                {
                    response.Success = true;
                    response.Message = "User Successfully Updated";
                }
                else
                {
                    response.Success = false;
                    response.Message = "Failed to update user.";
                }

                return response;
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }

        public async Task<IdentityResponse> UserLogin(UserLoginRequest request)
        {
            try
            {
                IdentityResponse response = new IdentityResponse();
                var jsonContent = JsonContent.Create(request);
                var login = await _httpClient.PostAsync("Users/login", jsonContent);

                if(login.IsSuccessStatusCode)
                {
                    var contentResponse = await login.Content.ReadFromJsonAsync<IdentityResponse>();

                    response.IsAuthenticated = contentResponse.IsAuthenticated;
                    response.AuthenticationType = contentResponse.AuthenticationType;
                }
                else
                {
                    response.IsAuthenticated = false;
                    response.AuthenticationType = "Password Authentication";
                }

                return response;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }
    }
}
