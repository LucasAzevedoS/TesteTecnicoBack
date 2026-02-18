namespace API.Models
{
    public class Pessoa
    {
        public int? id { get; set; }
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
