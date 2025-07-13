using System;
using System.Windows.Forms;
using RepositorioLivros.Services;

// Este arquivo define a lógica para a classe Frm_ConsultaLivro
namespace RepositorioLivros
{
    public partial class Frm_ConsultaLivro : Form
    {
        private readonly LivroService _livroService;

        public Frm_ConsultaLivro()
        {
            InitializeComponent();
            _livroService = new LivroService();
        }

        //
        // Este é o método que o seu Designer está procurando.
        // Ao adicioná-lo aqui, no arquivo ConsultaLivro.cs, o erro será resolvido.
        //
        private void ConsultaLivro_Load(object sender, EventArgs e)
        {
            CarregarEExibirLivros();
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarEExibirLivros();
        }

        private void CarregarEExibirLivros()
        {
            try
            {
                var listaDeLivros = _livroService.CarregarLivros();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaDeLivros;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado ao carregar os livros: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // Método que o designer também procura, pode ficar vazio.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deixe este método vazio se não precisar de nenhuma ação ao clicar na célula.
        }
    }
}