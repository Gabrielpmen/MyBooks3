using System;
using System.Drawing; // Importe para usar a classe Color e Font
using System.Linq;
using System.Windows.Forms;
using RepositorioLivros.Services;
using RepositorioLivros.Entities;

namespace RepositorioLivros
{
    public partial class Frm_ConsultaLivro : Form
    {
        private readonly LivroService _livroService;

        public Frm_ConsultaLivro()
        {
            InitializeComponent();
            _livroService = new LivroService();
            AplicarEstiloModerno(); // Chamamos o novo método de estilo aqui

            // Ligamos os botões às suas funções
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
        }

        // NOVO MÉTODO PARA APLICAR O DESIGN MODERNO
        private void AplicarEstiloModerno()
        {
            // --- Paleta de Cores ---
            var corFundo = Color.FromArgb(248, 249, 250);
            var corDestaqueAzul = Color.FromArgb(13, 110, 253); // Azul para ação principal
            var corPerigoVermelho = Color.FromArgb(220, 53, 69); // Vermelho para ação de perigo
            var corSecundariaCinza = Color.FromArgb(108, 117, 125); // Cinza para ações secundárias

            // Estilo geral do formulário
            this.BackColor = corFundo;
            this.Font = new Font("Segoe UI", 10F);

            // --- Estilo do Botão PESQUISAR (Azul) ---
            Btn_Pesquisar.FlatStyle = FlatStyle.Flat;
            Btn_Pesquisar.FlatAppearance.BorderSize = 0;
            Btn_Pesquisar.BackColor = corDestaqueAzul;
            Btn_Pesquisar.ForeColor = Color.White;
            Btn_Pesquisar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // --- Estilo do Botão EXCLUIR (Vermelho) ---
            Btn_Excluir.FlatStyle = FlatStyle.Flat;
            Btn_Excluir.FlatAppearance.BorderSize = 0;
            Btn_Excluir.BackColor = corPerigoVermelho;
            Btn_Excluir.ForeColor = Color.White;
            Btn_Excluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // --- Estilo do Botão VOLTAR (Secundário) ---
            Btn_Voltar.FlatStyle = FlatStyle.Flat;
            Btn_Voltar.FlatAppearance.BorderSize = 1;
            Btn_Voltar.FlatAppearance.BorderColor = corSecundariaCinza;
            Btn_Voltar.BackColor = corFundo;
            Btn_Voltar.ForeColor = corSecundariaCinza;
            Btn_Voltar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void ConsultaLivro_Load(object sender, EventArgs e)
        {
            CarregarEExibirLivros();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                _livroService.ExcluirLivro(tituloParaExcluir);
                CarregarEExibirLivros();
            }
        }

        private void CarregarEExibirLivros()
        {
            var listaCompleta = _livroService.CarregarLivros();

            var listaFiltrada = listaCompleta.Where(livro =>
                (string.IsNullOrEmpty(Txb_TituloCL.Text) || livro.Titulo.IndexOf(Txb_TituloCL.Text, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(Txt_AutorCL.Text) || livro.Autor.IndexOf(Txt_AutorCL.Text, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(Cbx_GeneroCL.Text) || livro.Genero == Cbx_GeneroCL.Text) &&
                (string.IsNullOrEmpty(Cbx_MidiaCL.Text) || livro.Midia == Cbx_MidiaCL.Text)
            ).ToList();
            
            if (listaFiltrada.Count == 0 && (!string.IsNullOrEmpty(Txb_TituloCL.Text) || !string.IsNullOrEmpty(Txt_AutorCL.Text) || !string.IsNullOrEmpty(Cbx_GeneroCL.Text) || !string.IsNullOrEmpty(Cbx_MidiaCL.Text)))
            {
                MessageBox.Show("Nenhum livro encontrado para os filtros informados.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}