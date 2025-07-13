using System;
using System.Drawing; // Necessário para usar cores e fontes
using System.Windows.Forms;
using RepositorioLivros.Services;

namespace RepositorioLivros
{
    public partial class Frm_ConsultaLivro : Form
    {
        private readonly LivroService _livroService;

        public Frm_ConsultaLivro()
        {
            InitializeComponent();
            _livroService = new LivroService();
            
            // Chama o método para aplicar nosso novo design
            AplicarEstiloModerno();
            
            // Carrega os dados no evento Load do formulário
            this.Load += ConsultaLivro_Load;
        }

    private void AplicarEstiloModerno()
    {
        // --- Paleta de Cores ---
        var corFundo = Color.FromArgb(248, 249, 250); // Um branco quase gelo
        var corTextoPrincipal = Color.FromArgb(33, 37, 41); // Cinza quase preto
        var corTextoSecundario = Color.FromArgb(108, 117, 125); // Cinza médio
        var corDestaque = Color.FromArgb(13, 110, 253); // Azul padrão do Bootstrap
        var corBorda = Color.FromArgb(222, 226, 230); // Cinza bem claro para bordas

        // --- Estilo do Formulário ---
        this.BackColor = corFundo;
        this.Font = new Font("Segoe UI", 10F);

        // --- GroupBox de Filtros ---
        filtersGroupBox.ForeColor = corTextoPrincipal;
        filtersGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        // --- NOVO: Adiciona o espaçamento interno para corrigir o corte ---
        filtersGroupBox.Padding = new Padding(10); // Adiciona 10 pixels de respiro em todos os lados

        // --- Labels ---
        Lbl_TituloCL.ForeColor = corTextoSecundario;
        Lbl_GeneroCL.ForeColor = corTextoSecundario;
        Lbl_AutorCL.ForeColor = corTextoSecundario;

        // --- Botão de Pesquisa ---
        Btn_Pesquisar.FlatStyle = FlatStyle.Flat;
        Btn_Pesquisar.FlatAppearance.BorderSize = 0;
        Btn_Pesquisar.BackColor = corDestaque;
        Btn_Pesquisar.ForeColor = Color.White;
        Btn_Pesquisar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        Btn_Pesquisar.Height = 35; // Altura consistente

        // --- DataGridView ---
        dataGridView1.BorderStyle = BorderStyle.None;
        dataGridView1.BackgroundColor = Color.White;
        dataGridView1.EnableHeadersVisualStyles = false;
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridView1.GridColor = corBorda;

        // Estilo do Cabeçalho do Grid
        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = corFundo;
        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = corTextoSecundario;
        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 5, 5, 5);
        dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        
        // Estilo das Células
        dataGridView1.DefaultCellStyle.BackColor = Color.White;
        dataGridView1.DefaultCellStyle.ForeColor = corTextoPrincipal;
        dataGridView1.DefaultCellStyle.SelectionBackColor = corDestaque;
        dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
        dataGridView1.DefaultCellStyle.Padding = new Padding(10, 5, 5, 5);

        // Linhas Alternadas
        dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = corFundo;
    }


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
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deixe este método vazio se não precisar de nenhuma ação.
        }
    }
}