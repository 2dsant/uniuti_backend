namespace UniUti.Application.ValueObjects
{
    public class UsuarioResponseVO : BaseVO
    {
        public string? NomeCompleto { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public EnderecoResponseVO? Endereco { get; set; }
        public InstituicaoResponseVO? Instituicao { get; set; }
        public CursoResponseVO? Curso { get; set; }
    }
}