using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackR.Models;
using TrackR.Models.ResponseModel;

namespace TrackR.Services.Interface
{
    public interface IUserService
    {
        Task<User> GetUserByEmail(string emailAddress);

        Task<List<User>> GetUsers();

        Task<ResponseModel> Update(User entity);
    }
}
