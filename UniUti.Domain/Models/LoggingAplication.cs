using Microsoft.Extensions.Logging;
using UniUti.Domain.Models.Base;
using UniUti.Domain.Models.Validator;

namespace UniUti.Domain.Models
{
    public class LoggingAplication : EntidadeBase
    {
        public string? UserId { get; private set; }
        public string Action { get; private set; }
        public string Path { get; private set; }
        public LogLevel LogLevel { get; private set; }
        public string? Information { get; private set; }

        protected LoggingAplication() { }

        public LoggingAplication(Guid? id, string? userId, string action, string path, string? information, LogLevel logLevel = LogLevel.Information) : base(id)
        {
            UserId = userId;
            Action = action;
            Path = path;
            LogLevel = logLevel;
            Information = information;
        }

        public LoggingAplication(Guid? id, string? userId, string action, string path, DateTime createdAt, string? information, LogLevel logLevel = LogLevel.Information) 
            : base(id, createdAt)
        {
            UserId = userId;
            Action = action;
            Path = path;
            LogLevel = logLevel;
            Information = information;
        }

        public LoggingAplication(Guid? id, string? userId, string action, string path, DateTime createdAt, DateTime updatedAt, 
            string? information, LogLevel logLevel = LogLevel.Information) : base(id, createdAt, updatedAt)
        {
            UserId = userId;
            Action = action;
            Path = path;
            LogLevel = logLevel;
            Information = information;
        }

        public bool Validate()
            => base.Validate<LoggingAplicationValidator, LoggingAplication>(new LoggingAplicationValidator(), this);


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
