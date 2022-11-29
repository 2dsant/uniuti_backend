using UniUti.Domain.Models.Enum;

namespace UniUti.Application.ValueObjects
{
    public class MonitoriaResponseVO : BaseVO
    {
        public string? Titulo { get; set; }
        public string SolicitanteId { get; set; }
        public string PrestadorId { get; set; }
        public string? Descricao { get; set; }
        public DisciplinaResponseVO? Disciplina { get; set; }
        public TipoSolicitacao TipoSolicitacao { get; set; }
        public StatusSolicitacao? StatusSolicitacaco { get; set; }
    }
}