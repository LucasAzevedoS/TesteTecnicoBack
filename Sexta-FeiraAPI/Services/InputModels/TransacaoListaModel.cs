namespace API.Services.InputModels
{
    public class TransacaoListaModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public decimal Valor { get; set; }

        public string Tipo { get; set; } = string.Empty;

        public string NomePessoa { get; set; } = string.Empty;

        public string NomeCategoria { get; set; } = string.Empty;
    }

}
