using System;
using Hotel.Front.Properties;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using IContainer = QuestPDF.Infrastructure.IContainer;
using System.IO;

namespace Caribe_Pallace
{
    public class ComprovanteReservaDocument : IDocument
    {
        private readonly RelatorioReservaModel _model;

        public ComprovanteReservaDocument(RelatorioReservaModel model)
        {
            _model = model;
        }

        public DocumentSettings GetSettings() => DocumentSettings.Default;

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(50); // Margem

                    page.Header().Element(ComposeHeader); // Cabeçalho
                    page.Content().Element(ComposeContent); // Conteúdo
                    page.Footer().Element(ComposeFooter); // Rodapé
                });
        }

        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(col =>
                {
                    col.Item().Text("Caribe Pallace Hotel")
                        .Bold().FontSize(20);

                    col.Item().Text($"Comprovante de Reserva Nº: {_model.id_reserva}")
                        .SemiBold().FontSize(14);

                    col.Item().Text($"Data da Emissão: {_model.DataReserva:dd/MM/yyyy HH:mm}");
                });
                // Adicione 'using System.IO;' no topo do seu arquivo
                byte[] logoData = File.ReadAllBytes("caminho/completo/para/seu_logo.png");

                row.ConstantItem(100).Height(50).Image(logoData); //Logo
            });
        }

        void ComposeContent(IContainer container)
        {
            container.PaddingVertical(20).Column(col =>
            {
                //Dados do Hóspede
                col.Item().Element(ComposeSectionTitle).Text("Dados do Hóspede");
                col.Item().Element(ComposeSectionContent).Column(c =>
                {
                    c.Item().Text($"Nome: {_model.NomeHospede}");
                    c.Item().Text($"CPF: {_model.CpfHospede}");
                    c.Item().Text($"Telefone: {_model.TelefoneHospede}");
                });

                //Detalhes da Estadia
                col.Item().Element(ComposeSectionTitle).Text("Detalhes da Estadia");
                col.Item().Element(ComposeSectionContent).Column(c =>
                {
                    c.Item().Text($"Quarto Nº: {_model.NumeroQuarto} ({_model.TipoQuarto})");
                    c.Item().Text($"Check-in: {_model.DataCheckin:dd/MM/yyyy}");
                    c.Item().Text($"Check-out: {_model.DataCheckout:dd/MM/yyyy}");
                    c.Item().Text($"Hóspedes: {_model.QuantidadePessoas}");
                });

                //Detalhes Financeiros
                col.Item().Element(ComposeSectionTitle).Text("Detalhes Financeiros");
                col.Item().Element(ComposeSectionContent).Column(c =>
                {
                    c.Item().Text($"Diária: {_model.ValorDiaria?.ToString("C") ?? "N / A"}");
                    c.Item().Text($"Valor Total: {_model.ValorTotal?.ToString("C") ?? "N / A"}");
                    c.Item().Text($"Forma de Pagamento: {_model.FormaPagamento ?? "Não definido"}");
                    c.Item().Text($"Status Pagamento: {_model.StatusPagamento ?? "Pendente"}").Bold();
                });
            });
        }


        static IContainer ComposeSectionTitle(IContainer container)
        {
            return container
                .BorderBottom(1)
                .BorderColor(Colors.Grey.Lighten1)
                .PaddingBottom(5)
                .PaddingTop(15);
        }

        static IContainer ComposeSectionContent(IContainer container)
        {
            return container.PaddingVertical(10);
        }

        void ComposeFooter(IContainer container)
        {
            container.AlignCenter().Text(text =>
            {
                text.DefaultTextStyle(x => x.FontSize(10).SemiBold());
                text.Span("Obrigado pela preferência! | ");
                text.Span("Contato: (XX) XXXX-XXXX | Endereço: Rua Fictícia, 123");
            });
        }

        
    }
}
