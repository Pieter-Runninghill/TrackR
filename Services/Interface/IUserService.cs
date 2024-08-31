using TrackR.Models;
using TrackR.Models.RequestModel;
using TrackR.Models.ResponseModel;

namespace TrackR.Services.Interface
{
    public interface IUserService
    {
        Task<User> GetUserByEmail(string emailAddress);

        Task<List<User>> GetUsers();

        Task<ResponseModel> Update(User entity);

        Task<ResponseModel> CreateUser(UserCreateRequest request);

        Task<IdentityResponse> UserLogin(UserLoginRequest request);
    }
}
