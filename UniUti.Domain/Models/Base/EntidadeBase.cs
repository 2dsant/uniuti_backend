using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniUti.Domain.Models.Base
{
    public abstract class EntidadeBase
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; private set; } = DateTime.Now;

        public DateTime UpdatedAt { get; private set; } = DateTime.Now;

        internal List<string> _errors = new List<string>();
        public IReadOnlyCollection<string> Errors => _errors;
        public bool IsValid => _errors.Count == 0;

        protected EntidadeBase() { }

        public EntidadeBase(Guid? id, DateTime createdAt, DateTime updatedAt)
        {
            Id = id is null ? Guid.NewGuid() : id.Value;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public EntidadeBase(Guid? id)
        {
            Id = id is null ? Guid.NewGuid() : id.Value;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public EntidadeBase(Guid? id, DateTime createdAt)
        {
            Id = id is null ? Guid.NewGuid() : id.Value;
            CreatedAt = createdAt;
            UpdatedAt = DateTime.Now;
        }

        private void AddErrorsList(IList<ValidationFailure> errors)
        {
            foreach (var error in errors)
            {
                _errors.Add(error.ErrorMessage);
            }
        }

        protected bool Validate<V, O>(V validator, O obj) where V : AbstractValidator<O>
        {
            var validation = validator.Validate(obj);
            if (validation.Errors.Count > 0)
                AddErrorsList(validation.Errors);

            return IsValid;
        }

        public string ErrorsToString()
        {
            var builder = new StringBuilder();

            foreach (var error in _errors)
                builder.AppendLine(error);

            return builder.ToString();
        }

        public void SetCreatedAt(DateTime createdAt)
        {
            CreatedAt = createdAt;
        }

        public void SetUpdatedAt(DateTime updatedAt)
        {
            UpdatedAt = updatedAt;
        }
    }
}