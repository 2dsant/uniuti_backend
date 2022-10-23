using UniUti.Application.Interfaces;
using UniUti.Domain.Interfaces;
using UniUti.Domain.Models;

namespace UniUti.Application.Services
{
    public class LogService : ILogService
    {
        private readonly ILogRepository _logRepository;

        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public async Task GravarLog(LoggingAplication log)
        {
            await _logRepository.SalvarLog(log);
        }
    }
}
