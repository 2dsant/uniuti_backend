using FluentValidation;

namespace UniUti.Domain.Models.Validator
{
    public class DisciplinaValidator : AbstractValidator<Disciplina>
    {
        public DisciplinaValidator()
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

            RuleFor(x => x.Nome)
                .NotNull()
                .WithMessage("O nome não pode ser nulo.")
                .NotEmpty()
                .WithMessage("O nome não pode ser vazio.")
                .MinimumLength(5)
                .WithMessage("O nome deve ter pelo menos 5 caracteres.")
                .MaximumLength(100)
                .WithMessage("O nome deve ter no máximo 100 caracteres.");

            RuleFor(x => x.Descricao)
                .NotNull()
                .WithMessage("Descrição não pode ser nula.")
                .NotEmpty()
                .WithMessage("Descrição não pode ser vazio.")
                .MinimumLength(20)
                .WithMessage("A descrição deve ter pelo menos 5 caracteres.")
                .MaximumLength(800)
                .WithMessage("A descrição deve ter no máximo 100 caracteres.");
        }
    }
}
