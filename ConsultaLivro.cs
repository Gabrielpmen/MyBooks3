using System;
using System.Drawing;
using System.Linq;
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
            this.MinimumSize = new Size(950, 700);
            _livroService = new LivroService();
            AplicarEstiloModerno();

            // Ligando os eventos de clique manualmente
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);

            // --- CORREÇÃO: LIGANDO OS BOTÕES AOS SEUS MÉTODOS ---
            // Esta linha diz: "Quando o botão Pesquisar for clicado, execute o método Btn_Pesquisar_Click"
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);

            // Esta linha diz: "Quando o botão Excluir for clicado, execute o método Btn_Excluir_Click"
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
        }

        private void ConsultaLivro_Load(object sender, EventArgs e)
        {
            CarregarEExibirLivros();
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarEExibirLivros();
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione o livro que deseja excluir.", "Nenhum Livro Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tituloParaExcluir = dataGridView1.SelectedRows[0].Cells["Titulo"].Value.ToString();

            var confirmacao = MessageBox.Show($"Tem certeza que deseja excluir o livro '{tituloParaExcluir}'?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    _livroService.ExcluirLivro(tituloParaExcluir);
                    CarregarEExibirLivros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao excluir o livro: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarEExibirLivros()
        {
            try
            {
                var listaCompleta = _livroService.CarregarLivros();
                var listaFiltrada = listaCompleta.Where(livro =>
                    (string.IsNullOrEmpty(Txb_TituloCL.Text) || livro.Titulo.IndexOf(Txb_TituloCL.Text, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (string.IsNullOrEmpty(Txt_AutorCL.Text) || livro.Autor.IndexOf(Txt_AutorCL.Text, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (string.IsNullOrEmpty(Cbx_GeneroCL.Text) || livro.Genero == Cbx_GeneroCL.Text) &&
                    (string.IsNullOrEmpty(Cbx_MidiaCL.Text) || livro.Midia == Cbx_MidiaCL.Text) &&
                    (string.IsNullOrEmpty(Cbx_AnoLancamentoCL.Text) || livro.AnoLancamento == Cbx_AnoLancamentoCL.Text) &&
                    (string.IsNullOrEmpty(Cbx_StatusLeituraCL.Text) || livro.StatusLeitura == Cbx_StatusLeituraCL.Text)
                ).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar os livros: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarEstiloModerno()
        {
            // --- Paleta de Cores (permanece a mesma) ---
            var corFundo = Color.FromArgb(248, 249, 250);
            var corTextoPrincipal = Color.FromArgb(33, 37, 41);
            var corTextoSecundario = Color.FromArgb(108, 117, 125);
            var corDestaque = Color.FromArgb(13, 110, 253);
            var corPerigo = Color.FromArgb(220, 53, 69);
            var corBorda = Color.FromArgb(222, 226, 230);

            // --- Estilo do Formulário ---
            this.BackColor = corFundo;
            this.Font = new Font("Segoe UI", 10F);

            // --- CORREÇÃO DEFINITIVA DE LAYOUT ---
            // 1. Desativamos o AutoSize do GroupBox que não funcionou como esperado.
            this.filtersGroupBox.AutoSize = false;
            this.filtersGroupBox.Dock = DockStyle.Fill; // Garantimos que ele preencha a célula do painel.

            // 2. Definimos um tamanho FIXO para a linha dos filtros e o restante para o grid.
            // Isso resolve o problema do "corte" de forma garantida.
            this.mainTableLayoutPanel.RowStyles[0].SizeType = SizeType.Absolute;
            this.mainTableLayoutPanel.RowStyles[0].Height = 200; // <-- Altura fixa de 200 pixels para a área de filtros.
            this.mainTableLayoutPanel.RowStyles[1].SizeType = SizeType.Percent;
            this.mainTableLayoutPanel.RowStyles[1].Height = 100F; // <-- O grid de livros ocupa 100% do espaço restante.

            // --- Estilos dos Controles (permanecem os mesmos) ---
            filtersGroupBox.ForeColor = corTextoPrincipal;
            filtersGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            filtersGroupBox.Padding = new Padding(10);

            foreach (Control control in this.filtersTableLayoutPanel.Controls)
            {
                control.Margin = new Padding(3, 6, 3, 6);
                if (!(control is Label || control is Panel))
                {
                    control.Dock = DockStyle.Fill;
                }
            }

            var labels = new[] { Lbl_TituloCL, Lbl_AutorCL, Lbl_GeneroCL, Lbl_MidiaCL, Lbl_AnoLancamentoCL, Lbl_StatusLeituraCL };
            foreach (var label in labels)
            {
                label.ForeColor = corTextoSecundario;
                label.Anchor = AnchorStyles.Right;
                label.AutoSize = true;
            }

            Btn_Pesquisar.FlatStyle = FlatStyle.Flat;
            Btn_Pesquisar.FlatAppearance.BorderSize = 0;
            Btn_Pesquisar.BackColor = corDestaque;
            Btn_Pesquisar.ForeColor = Color.White;
            Btn_Pesquisar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            Btn_Excluir.FlatStyle = FlatStyle.Flat;
            Btn_Excluir.FlatAppearance.BorderSize = 0;
            Btn_Excluir.BackColor = corPerigo;
            Btn_Excluir.ForeColor = Color.White;
            Btn_Excluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Estilo do DataGridView (permanece o mesmo)
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            // ... (resto do código de estilo do grid) ...
        }
    }
}