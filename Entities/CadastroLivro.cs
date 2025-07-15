using System; // Importe para usar o Guid

namespace RepositorioLivros.Entities
{
    public class CadastroLivro
    {
        // --- MUDANÇA: Adicionamos a propriedade ID ---
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Midia { get; set; }
        public string AnoLancamento { get; set; }
        public string StatusLeitura { get; set; }
        public string AnoCompra { get; set; }
        public double ValorPago { get; set; }
        public string Autor { get; set; }
        public string Esaga { get; set; }

        public CadastroLivro()
        {
            // Quando um novo livro é criado, ele recebe um ID único e universal.
            Id = Guid.NewGuid();
        }

        // O construtor com parâmetros não precisa ser alterado, pois o construtor padrão
        // já é chamado implicitamente e atribui o ID.
        public CadastroLivro(string titulo, string genero, string midia, string anoLancamento, string statusLeitura, string anoCompra, double valorPago, string autor, string esaga) : this()
        {
            Titulo = titulo;
            Genero = genero;
            Midia = midia;
            AnoLancamento = anoLancamento;
            StatusLeitura = statusLeitura;
            AnoCompra = anoCompra;
            ValorPago = valorPago;
            Autor = autor;
            Esaga = esaga;
        }
    }
}