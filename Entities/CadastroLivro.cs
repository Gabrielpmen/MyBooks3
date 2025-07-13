namespace RepositorioLivros.Entities
{
    public class CadastroLivro
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Midia { get; set; }
        public string AnoLancamento { get; set; }
        public string StatusLeitura { get; set; }
        public string AnoCompra { get; set; }
        public double ValorPago { get; set; }
        public string Autor { get; set; }
        public string Esaga { get; set; }

        // Construtor padrão corrigido para inicializar as propriedades.
        // Isso resolve os avisos CS8618.
        public CadastroLivro()
        {
            Titulo = string.Empty;
            Genero = string.Empty;
            Midia = string.Empty;
            AnoLancamento = string.Empty;
            StatusLeitura = string.Empty;
            AnoCompra = string.Empty;
            Autor = string.Empty;
            Esaga = string.Empty;
        }

        public CadastroLivro(string titulo, string genero, string midia, string anoLancamento, string statusLeitura, string anoCompra, double valorPago, string autor, string esaga)
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