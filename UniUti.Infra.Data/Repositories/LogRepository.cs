using UniUti.Domain.Interfaces;
using UniUti.Domain.Models;
using UniUti.Database;

namespace UniUti.Infra.Data.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly ApplicationDbContext _context;

        public LogRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SalvarLog(LoggingAplication log)
        {
            await _context.Logs.AddAsync(log);
            await _context.SaveChangesAsync();
        }
    }
}
