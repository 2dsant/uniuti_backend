using System.ComponentModel.DataAnnotations;

namespace UniUti.Application.ValueObjects
{
    public class CursoUpdateVO
    {
        [Required]
        public string Id { get; set; }

        [MaxLength(100, ErrorMessage = "Nome inválido. O nome deve conter até 100 caracteres.")]
        [MinLength(5, ErrorMessage = "Nome inválido. O nome deve conter no mínimo 5 caracteres.")]
        public string Nome { get; set; }
    }
}
