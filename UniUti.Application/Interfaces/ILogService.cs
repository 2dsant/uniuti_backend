using UniUti.Domain.Models;

namespace UniUti.Application.Interfaces
{
    public interface ILogService
    {
        public Task GravarLog(LoggingAplication log);
    }
}
