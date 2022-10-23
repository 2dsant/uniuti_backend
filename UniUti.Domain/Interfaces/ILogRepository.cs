using UniUti.Domain.Models;

namespace UniUti.Domain.Interfaces
{
    public interface ILogRepository
    {
        public Task SalvarLog(LoggingAplication log);
    }
}
