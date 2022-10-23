using UniUti.Domain.Models.Base;
using UniUti.Domain.Models.Validator;

namespace UniUti.Domain.Models
{
    public class LoggingAplication : EntidadeBase
    {
        public DateTime? CreatedAt { get; private set; }
        public string? UserId { get; private set; }
        public string Action { get; private set; }
        public string Path { get; private set; }

        protected LoggingAplication() { }

        public LoggingAplication(Guid? id, string? userId, string action, string path)
        {
            Id = id is null ? Guid.NewGuid() : id.Value;
            CreatedAt = DateTime.Now;
            UserId = userId;
            Action = action;
            Path = path;
        }

        public bool Validate()
            => base.Validate<LoggingAplicationValidator, LoggingAplication>(new LoggingAplicationValidator(), this);

        public void SetCreatedAt(DateTime createdAt)
        {
            CreatedAt = createdAt;
        }

        public void SetUserId(string userId)
        {
            UserId = userId;
        }

        public void SetAction(string action)
        {
            Action = action;
        }
        
        public void SetPath(string path)
        {
            Path = path;
        }
    }
}
