using Traking_system.Models;
using Traking_system.Entites;

namespace Traking_system.Interfaces
{
    public interface IUser : IRepository
    {
        User? ValidateUser(AuthenticationRequestBody authenticationRequestBody);
        User? GetUserById(int userId);
    }
}
