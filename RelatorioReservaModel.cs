using System;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Caribe_Pallace
{
    public class RelatorioReservaModel
    {
        public int id_reserva { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
        public int QuantidadePessoas { get; set; }
        public decimal? ValorDiaria { get; set; }
        public decimal? ValorTotal { get; set; }
        public string FormaPagamento { get; set; }
        public string StatusReserva { get; set; }

        public string NomeHospede { get; set; }
        public string CpfHospede { get; set; }
        public string TelefoneHospede { get; set; }

        public int NumeroQuarto { get; set; }
        public string TipoQuarto { get; set; }

        public string StatusPagamento { get; set; }
    }
}