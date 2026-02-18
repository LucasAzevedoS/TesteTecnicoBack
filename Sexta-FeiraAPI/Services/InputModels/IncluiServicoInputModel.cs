using Barber.Models;

namespace Barber.Services.InputModels
{
    public class IncluiServicoInputModel
    {
        public int? Id { get; set; }
        public string? servico { get; set; }
        public string? descricao { get; set; }
        public float? valor { get; set; }
        public int? idEstabelecimento { get; set; }
        public string? Imagem{ get; set; }
        public bool? ativo { get; set; }

    }
}
