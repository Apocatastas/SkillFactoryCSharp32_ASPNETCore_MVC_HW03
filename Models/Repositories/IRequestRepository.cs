using MvcStartApp.Models.Db;

namespace MvcStartApp.Models.Repositories
{
    public interface IRequestRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetRequests();
    }
}
