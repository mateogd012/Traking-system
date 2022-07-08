using Traking_system.Entites;

namespace Traking_system.Interfaces
{
    public interface ITrips : IRepository
    {
        void AddTrip(Trips newTrip);
        IOrderedQueryable<Trips> GetPendingTrip(int userId, bool withResponses);
        Trips? GetTrip(int tripId);
        bool IsQuestionIdValid(int tripsId);
    }
}
