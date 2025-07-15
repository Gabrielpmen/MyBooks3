using System.Globalization;
using System.Windows.Forms;
using RepositorioLivros.Entities;

namespace RepositorioLivros
{
    public partial class Frm_DetalhesLivro : Form
    {
        // Construtor que recebe o livro a ser exibido
        public Frm_DetalhesLivro(CadastroLivro livro)
        {
            InitializeComponent();
            PopularDados(livro);

            // Adiciona a funcionalidade ao botão Fechar
            this.Btn_Fechar.Click += (sender, e) => this.Close();
        }

        // Método para preencher os labels com as informações do livro
        private void PopularDados(CadastroLivro livro)
        {
            // Define o título da janela com o nome do livro
            this.Text = $"Detalhes de: {livro.Titulo}";

            // Preenche cada label com seu respectivo dado
            lblTituloData.Text = livro.Titulo;
            lblAutorData.Text = livro.Autor;
            lblGeneroData.Text = livro.Genero;
            lblMidiaData.Text = livro.Midia;
            lblAnoLancamentoData.Text = livro.AnoLancamento;
            lblStatusData.Text = livro.StatusLeitura;
            lblAnoCompraData.Text = livro.AnoCompra;
            // Formata o valor para moeda brasileira
            lblValorPagoData.Text = livro.ValorPago.ToString("C", new CultureInfo("pt-BR"));
            lblSagaData.Text = livro.Esaga;
        }
    }
}