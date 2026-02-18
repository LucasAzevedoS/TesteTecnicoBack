namespace Barber.Services.InputModels
{
    public class IncluiAgendamentoInputModel
    {
        public int? IdAgenda { get; set; }
        public int? IdServico { get; set; }
        
        public string? Cliente { get; set; }

        public string? Celular { get; set; } 
        public int? Profissional { get; set; }
    }
}
