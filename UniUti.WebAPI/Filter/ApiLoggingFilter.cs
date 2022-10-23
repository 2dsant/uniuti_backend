using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics.CodeAnalysis;
using UniUti.Application.Interfaces;
using UniUti.Domain.Models;

namespace UniUti.WebAPI.Filters
{
    public class ApiLoggingFilter : IActionFilter
    {
        private readonly ILogService _log;

        public ApiLoggingFilter(ILogService log)
        {
            _log = log;
        }

        //executa antes da Action
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var id = context.HttpContext.User.FindFirst("id")?.Value;
            var action = context.ActionDescriptor.DisplayName;
            var path = context.HttpContext.Request.Path.Value;
            var loggingApp = new LoggingAplication(null, id, action, path);

            _log.GravarLog(loggingApp);
        }

        [ExcludeFromCodeCoverage]
        //executa depois da Action
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Method intentionally left empty.
        }
    }
}

