using Microsoft.Extensions.Primitives;
using Newtonsoft.Json.Linq;
using System.Net;
using UniUti.Application.Interfaces;
using UniUti.Domain.Models;

namespace UniUti.WebAPI.Middleware
{
    public class UniUtiMiddlewareException
    {
        private readonly RequestDelegate next;
        private readonly IServiceProvider _provider;

        public UniUtiMiddlewareException(RequestDelegate next, IServiceProvider provider)
        {
            this.next = next;
            _provider = provider;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private async Task<Task?> HandleExceptionAsync(HttpContext context, Exception exception)
        {
            using (var scope = _provider.CreateScope())
            {
                var _log = scope.ServiceProvider.GetRequiredService<ILogService>();
                var id = context.User.FindFirst("id")?.Value;
                var path = context.Request.Path.Value;

                JObject resultMsg = new JObject();
                resultMsg.Add("erro", $"{exception.Message}");

                if (context != null)
                {
                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = 500;
                }

                var loggingApp = new LoggingAplication(null, id, String.Empty, path, exception.ToString(), LogLevel.Error);
                await _log.GravarLog(loggingApp);

                return context?.Response.WriteAsync(resultMsg.ToString());
            }
        }
    }
}
