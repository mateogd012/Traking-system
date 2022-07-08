using Traking_system.Entites;

namespace Traking_system.Interfaces
{
    public interface IEmployee
    {
        Employee? GetEmployeeById(int userId);
        ICollection<Trips> GetEmployeeTrips(int tripsId);
    }
}
