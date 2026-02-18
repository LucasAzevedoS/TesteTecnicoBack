namespace API.Services.InputModels
{
    public class IncluiReuniaoInputModel
    {
        public int? id { get; set; }
        public string? nomeReuniao { get; set; }
        public string? dsReuniao { get; set; }
        public string? cep { get; set; }
        public string? endereco { get; set; }
        public string? numeroEndereco { get; set; }
        public string? complemento { get; set; }
        public string? bairro { get; set; }
        public string? cidade { get; set; }
        public string? uf { get; set; }
        public int idGrupo { get; set; }
    }
}
