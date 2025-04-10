using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models.Repositories;
using MvcStartApp.Middlewares;

namespace MvcStartApp.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestRepository _repo;

        public RequestController(IRequestRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Logs()
        {
            var logs = await _repo.GetRequests();
            return View(logs);
        }
    }
}
