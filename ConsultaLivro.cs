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
            AplicarEstiloModerno();
            
            // Ligando os botões às suas funções
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            this.Btn_LimparFiltros.Click += new System.EventHandler(this.Btn_LimparFiltros_Click); // LIGAÇÃO DO NOVO BOTÃO
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora cliques no cabeçalho
            if (e.RowIndex < 0) return;

            // Pega o ID do livro da linha que recebeu o duplo-clique
            var idDoLivro = (Guid)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            var livroSelecionado = _livroService.CarregarLivros().FirstOrDefault(l => l.Id == idDoLivro);

            if (livroSelecionado != null)
            {
                // Cria e exibe o formulário de detalhes
                var formDetalhes = new Frm_DetalhesLivro(livroSelecionado);
                formDetalhes.ShowDialog();
            }
        }
        private void AplicarEstiloModerno()
        {
            var corFundo = Color.FromArgb(248, 249, 250);
            var corDestaqueAzul = Color.FromArgb(13, 110, 253);
            var corPerigoVermelho = Color.FromArgb(220, 53, 69);
            var corSecundariaCinza = Color.FromArgb(108, 117, 125);
            var corSucessoVerde = Color.FromArgb(25, 135, 84); // Cor para o botão Editar

            this.BackColor = corFundo;
            this.Font = new Font("Segoe UI", 10F);
            this.MinimumSize = new Size(950, 600);

            // Botão Pesquisar (Ação Principal)
            Btn_Pesquisar.FlatStyle = FlatStyle.Flat;
            Btn_Pesquisar.FlatAppearance.BorderSize = 0;
            Btn_Pesquisar.BackColor = corDestaqueAzul;
            Btn_Pesquisar.ForeColor = Color.White;
            Btn_Pesquisar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Botão Editar (Ação Positiva)
            Btn_Editar.FlatStyle = FlatStyle.Flat;
            Btn_Editar.FlatAppearance.BorderSize = 0;
            Btn_Editar.BackColor = corSucessoVerde;
            Btn_Editar.ForeColor = Color.White;
            Btn_Editar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Botão Excluir (Ação de Perigo)
            Btn_Excluir.FlatStyle = FlatStyle.Flat;
            Btn_Excluir.FlatAppearance.BorderSize = 0;
            Btn_Excluir.BackColor = corPerigoVermelho;
            Btn_Excluir.ForeColor = Color.White;
            Btn_Excluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Botões Secundários (Voltar e Limpar Filtros)
            var botoesSecundarios = new[] { Btn_Voltar, Btn_LimparFiltros };
            foreach(var btn in botoesSecundarios)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = corSecundariaCinza;
                btn.BackColor = corFundo;
                btn.ForeColor = corSecundariaCinza;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void ConsultaLivro_Load(object sender, EventArgs e)
        {
            CarregarEExibirLivros();
        }

        // --- NOVO MÉTODO PARA O BOTÃO LIMPAR FILTROS ---
        private void Btn_LimparFiltros_Click(object sender, EventArgs e)
        {
            // Limpa o conteúdo de todos os campos de filtro
            Txb_TituloCL.Clear();
            Txt_AutorCL.Clear();
            Cbx_GeneroCL.SelectedIndex = -1; // Reseta a seleção do ComboBox
            Cbx_MidiaCL.SelectedIndex = -1;

            // Recarrega a lista completa de livros
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
        
        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione o livro que deseja editar.", "Nenhum Livro Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idParaEditar = (Guid)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            var livroParaEditar = _livroService.CarregarLivros().FirstOrDefault(l => l.Id == idParaEditar);

            if (livroParaEditar != null)
            {
                var formEdicao = new Frm_AdicionarLivro(livroParaEditar);
                formEdicao.ShowDialog();
                CarregarEExibirLivros();
            }
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione o livro que deseja excluir.", "Nenhum Livro Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idParaExcluir = (Guid)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            string tituloDoLivro = dataGridView1.SelectedRows[0].Cells["Titulo"].Value.ToString();
            var confirmacao = MessageBox.Show($"Tem certeza que deseja excluir o livro '{tituloDoLivro}'?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                _livroService.ExcluirLivro(idParaExcluir);
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

            if (dataGridView1.Columns.Contains("Id") && dataGridView1.Columns["Id"] != null)
            {
                dataGridView1.Columns["Id"].Visible = false;
            }
            if (listaFiltrada.Count == 1)
            {
                tssStatusLabel.Text = "1 livro encontrado.";
            }
            else
            {
                tssStatusLabel.Text = $"{listaFiltrada.Count} livros encontrados.";
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
        }
    }
}