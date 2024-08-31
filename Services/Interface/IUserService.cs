using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackR.Models;

namespace TrackR.Services.Interface
{
    public interface IUserService
    {
        Task<User> GetUserByEmail(string emailAddress);

        Task<List<User>> GetUsers();

        Task Update(User entity);
    }
}
