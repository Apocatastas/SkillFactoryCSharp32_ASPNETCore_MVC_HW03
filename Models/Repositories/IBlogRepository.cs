using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models.Db;

namespace MvcStartApp.Models.Repositories
{
    public interface IBlogRepository
    {
        Task Register(User user);

        Task<User[]> GetUsers();
    }
}
