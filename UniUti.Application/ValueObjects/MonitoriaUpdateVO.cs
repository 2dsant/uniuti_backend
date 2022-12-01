using System.ComponentModel.DataAnnotations;
using UniUti.Domain.Models.Enum;

namespace UniUti.Application.ValueObjects
{
    public class MonitoriaUpdateVO
    {
        [Required(ErrorMessage = "Id é obrigatório.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Título é obrigatório.")]
        [MaxLength(150, ErrorMessage = "Título inválido. Título deve possuir até 150 caracteres.")]
        [MinLength(10, ErrorMessage = "Título inválido. Título deve possuir no mínimo 10 caracteres.")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "SolicitanteId é obrigatório.")]
        public virtual Guid SolicitanteId { get; set; }
        public Guid? PrestadorId { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório.")]
        [MaxLength(500, ErrorMessage = "Descrição inválida. Descrição deve possuir até 500 caracteres.")]
        [MinLength(20, ErrorMessage = "Descrição inválida. Descrição deve possuir no mínimo 20 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Disciplina é obrigatório.")]
        public string DisciplinaId { get; set; }

        [Required(ErrorMessage = "Status da solicitação é obrigatório.")]
        public StatusSolicitacao? StatusSolicitacaco { get; set; }

        [Required(ErrorMessage = "Tipo da solicitação é obrigatório.")]
        public TipoSolicitacao? TipoSolicitacao { get; set; }
    }
}