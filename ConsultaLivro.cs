using System;
using System.Drawing;
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
            // Ligamos os botões às suas funções
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
        }

        private void ConsultaLivro_Load(object sender, EventArgs e)
        {
            // Carrega os livros quando o formulário abre
            CarregarEExibirLivros();
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            // O botão de pesquisar simplesmente chama o método que carrega e filtra
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
                CarregarEExibirLivros(); // Atualiza a tela após a exclusão
            }
        }

        private void CarregarEExibirLivros()
        {
            var listaCompleta = _livroService.CarregarLivros();

            // --- LÓGICA DE FILTRO ATUALIZADA ---
            // Agora ela verifica também os novos ComboBoxes
            var listaFiltrada = listaCompleta.Where(livro =>
                (string.IsNullOrEmpty(Txb_TituloCL.Text) || livro.Titulo.IndexOf(Txb_TituloCL.Text, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(Txt_AutorCL.Text) || livro.Autor.IndexOf(Txt_AutorCL.Text, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(Cbx_GeneroCL.Text) || livro.Genero == Cbx_GeneroCL.Text) &&
                (string.IsNullOrEmpty(Cbx_MidiaCL.Text) || livro.Midia == Cbx_MidiaCL.Text)
            ).ToList();
            if (listaFiltrada.Count == 0 &&
                (!string.IsNullOrEmpty(Txb_TituloCL.Text) ||
                !string.IsNullOrEmpty(Txt_AutorCL.Text) ||
                !string.IsNullOrEmpty(Cbx_GeneroCL.Text) ||
                !string.IsNullOrEmpty(Cbx_MidiaCL.Text)))
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