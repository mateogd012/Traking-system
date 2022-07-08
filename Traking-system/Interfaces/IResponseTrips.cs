using Traking_system.Entites;

namespace Traking_system.Interfaces
{
    public interface IResponseTrips : IRepository
    {
        void AddResponse(Response newResponse);
        Response? GetResponse(int responseId);
    }
}
