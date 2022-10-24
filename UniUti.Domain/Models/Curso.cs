using UniUti.Domain.Models.Validator;
using UniUti.Domain.Models.Base;

namespace UniUti.Domain.Models
{
    public class Curso : EntidadeBase
    {
        public string? Nome { get; private set; }
        public Boolean Deletado { get; private set; } = false;

        protected Curso() { }

        public Curso(Guid? id, string? nome, bool? deletado = false) : base(id)
        {
            Nome = nome;
            Deletado = deletado.Value;
            _errors = new List<string>();

            this.Validate();
        }

        public Curso(Guid? id, string? nome, DateTime createdAt, bool? deletado = false) : base(id, createdAt)
        {
            Nome = nome;
            Deletado = deletado.Value;
            _errors = new List<string>();

            this.Validate();
        }

        public Curso(Guid? id, string? nome, DateTime createdAt, DateTime updatedAt, bool? deletado = false) : base(id, createdAt, updatedAt)
        {
            Nome = nome;
            Deletado = deletado.Value;
            _errors = new List<string>();

            this.Validate();
        }


        public bool Validate()
            => base.Validate<CursoValidator, Curso>(new CursoValidator(), this);

        public void SetNome(string nome)
        {
            Nome = nome;
            Validate();
        }

        public void SetId()
        {
            Id = Guid.NewGuid();
        }
        public void SetDeletado(bool value)
        {
            Deletado = value;
            Validate();
        }
    }
}