using UniUti.Domain.Models.Validator;
using UniUti.Domain.Models.Base;
using UniUti.Domain.Models.Enum;

namespace UniUti.Domain.Models
{
    public class Monitoria : EntidadeBase
    {
        public string Titulo { get; set;}
        public string? SolicitanteId { get; private set; }
        public string? PrestadorId { get; private set; }
        public string? Descricao { get; private set; }
        public Disciplina? Disciplina { get; private set; }
        public Guid? DisciplinaId { get; private set; }
        public StatusSolicitacao? StatusSolicitacao { get; private set; }
        public TipoSolicitacao? TipoSolicitacao { get; private set; }
        public bool Deletado { get; private set; } = false;

        protected Monitoria() { }

        public Monitoria(Guid? id, string titulo, string solicitanteId, string? prestadorId, string descricao, Disciplina disciplina,
            Instituicao? instituicao, StatusSolicitacao statusSolicitacaco, TipoSolicitacao tipoSolicitacao, bool? deletado = false) : base(id)
        {
            Titulo = titulo;
            SolicitanteId = solicitanteId;
            PrestadorId = prestadorId;
            Descricao = descricao;
            Disciplina = disciplina;
            DisciplinaId = Disciplina.Id;
            StatusSolicitacao = statusSolicitacaco;
            TipoSolicitacao = tipoSolicitacao;
            Validate();
        }

        public Monitoria(Guid? id, string titulo, string solicitanteId, string? prestadorId, string descricao, Disciplina disciplina,
            Instituicao? instituicao, StatusSolicitacao statusSolicitacaco, TipoSolicitacao tipoSolicitacao, DateTime createdAt, bool? deletado = false) : base(id, createdAt)
        {
            Titulo = titulo;
            SolicitanteId = solicitanteId;
            PrestadorId = prestadorId;
            Descricao = descricao;
            Disciplina = disciplina;
            DisciplinaId = Disciplina.Id;
            StatusSolicitacao = statusSolicitacaco;
            TipoSolicitacao = tipoSolicitacao;
            Validate();
        }

        public Monitoria(Guid? id, string titulo, string solicitanteId, string? prestadorId, string descricao, Disciplina disciplina,
            Instituicao? instituicao, StatusSolicitacao statusSolicitacaco, TipoSolicitacao tipoSolicitacao, DateTime createdAt, DateTime updatedAt, bool? deletado = false) : base(id, createdAt, updatedAt)
        {
            Titulo = titulo;
            SolicitanteId = solicitanteId;
            PrestadorId = prestadorId;
            Descricao = descricao;
            Disciplina = disciplina;
            DisciplinaId = Disciplina.Id;
            StatusSolicitacao = statusSolicitacaco;
            TipoSolicitacao = tipoSolicitacao;
            Validate();
        }

        public bool Validate()
            => base.Validate<MonitoriaValidator, Monitoria>(new MonitoriaValidator(), this);

        public void SetSolicitanteId(string id)
        {
            SolicitanteId = id;
            Validate();
        }

        public void SetId()
        {
            Id = Guid.NewGuid();
        }

        public void SetPrestadoId(string id)
        {
            PrestadorId = id;
            Validate();
        }

        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
            Validate();
        }

        public void SetDisciplina(Disciplina disciplina)
        {
            Disciplina = disciplina;
            Validate();
        }

        public void SetDisciplinaId(string id)
        {
            DisciplinaId = Guid.Parse(id);
            Validate();
        }

        public void SetStatusSolicitacao(StatusSolicitacao status)
        {
            this.StatusSolicitacao = status;
            Validate();
        }

        public void SetTipoSolicitacao(TipoSolicitacao tipo)
        {
            this.TipoSolicitacao = tipo;
            Validate();
        }

        public void SetDeletado(bool value)
        {
            Deletado = value;
            Validate();
        }
    }
}