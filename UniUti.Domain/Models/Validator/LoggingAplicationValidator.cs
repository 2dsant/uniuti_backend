using FluentValidation;

namespace UniUti.Domain.Models.Validator
{
    public class LoggingAplicationValidator : AbstractValidator<LoggingAplication>
    {
        public LoggingAplicationValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia.")
                .NotNull()
                .WithMessage("A entidade não pode ser nula.");


            RuleFor(x => x.Id)
                .NotNull()
                .WithMessage("O Id não pode ser nulo.")
                .NotEmpty()
                .WithMessage("O Id não pode ser vazio.");

            RuleFor(x => x.UserId)
                .NotNull()
                .WithMessage("O UserId não pode ser nulo.")
                .NotEmpty()
                .WithMessage("O UserId não pode ser vazio.");

            RuleFor(x => x.Action)
                .NotNull()
                .WithMessage("A Action não pode ser nula.")
                .NotEmpty()
                .WithMessage("A Action não pode ser vazia.");

            RuleFor(x => x.Path)
                .NotNull()
                .WithMessage("O Path não pode ser nulo.")
                .NotEmpty()
                .WithMessage("O Path não pode ser vazio.");
        }
    }
}
