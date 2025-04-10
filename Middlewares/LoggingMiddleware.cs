using MvcStartApp.Models.Repositories;
using MvcStartApp.Models.Db;

namespace MvcStartApp.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IRequestRepository _repo)
        {
            Console.WriteLine($"[{DateTime.Now}]: New request to http://{context.Request.Host.Value + context.Request.Path}");
            var newRequest = new Request()
            {
                Url = $"http://{context.Request.Host.Value + context.Request.Path}"
            };
            await _repo.AddRequest(newRequest);
            await _next.Invoke(context);
        }
    }
}