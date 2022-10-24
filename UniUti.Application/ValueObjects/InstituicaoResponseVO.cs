namespace UniUti.Application.ValueObjects
{
    public class InstituicaoResponseVO : BaseVO
    {
        public string? Nome { get; set; }
        public EnderecoResponseVO? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
    }
}