using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RepositorioLivros.Entities;
using RepositorioLivros.Services;

namespace RepositorioLivros
{
    public partial class Frm_AdicionarLivro : Form
    {
        private readonly LivroService _livroService;

        public Frm_AdicionarLivro()
        {
            InitializeComponent();
            _livroService = new LivroService();
        }

        // ... (mantenha o seu método Btn_SalvarLivro_Click e outros que já funcionam)
        private void Btn_SalvarLivro_Click(object sender, EventArgs e)
        {
            // Validação do Input do Front-End
            if (string.IsNullOrWhiteSpace(Txt_Titulo2.Text) ||
                string.IsNullOrWhiteSpace(Cbx_Genero.Text) ||
                string.IsNullOrWhiteSpace(Cbx_Midia.Text) ||
                string.IsNullOrWhiteSpace(Cbx_AnoLancamento.Text) ||
                string.IsNullOrWhiteSpace(Cbx_StatusLeitura.Text) ||
                string.IsNullOrWhiteSpace(Cbx_AnoAquisicao.Text) ||
                string.IsNullOrWhiteSpace(Msk_ValorLivro.Text) ||
                string.IsNullOrWhiteSpace(Txt_Autor.Text))
            {
                MessageBox.Show("Ainda existem campos a serem preenchidos!", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(Msk_ValorLivro.Text, out double valorLivro))
            {
                MessageBox.Show("O valor do livro informado é inválido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<CadastroLivro> listaLivros = _livroService.CarregarLivros();
                var novoLivro = new CadastroLivro(
                    Txt_Titulo2.Text,
                    Cbx_Genero.Text,
                    Cbx_Midia.Text,
                    Cbx_AnoLancamento.Text,
                    Cbx_StatusLeitura.Text,
                    Cbx_AnoAquisicao.Text,
                    valorLivro,
                    Txt_Autor.Text,
                    Chkb_SagaS.Checked ? "Sim" : "Não"
                );
                listaLivros.Add(novoLivro);
                _livroService.SalvarLivros(listaLivros);
                MessageBox.Show("Livro salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado ao salvar o livro: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LimparCampos()
        {
            Txt_Titulo2.Clear();
            Cbx_Genero.SelectedIndex = -1;
            Cbx_Midia.SelectedIndex = -1;
            Cbx_AnoLancamento.SelectedIndex = -1;
            Cbx_StatusLeitura.SelectedIndex = -1;
            Cbx_AnoAquisicao.SelectedIndex = -1;
            Msk_ValorLivro.Clear();
            Txt_Autor.Clear();
            Chkb_SagaS.Checked = false;
        }

        private void novaToolStripButton_Click(object sender, EventArgs e) { LimparCampos(); }
        private void salvarToolStripButton_Click(object sender, EventArgs e) { Btn_SalvarLivro_Click(sender, e); }
        private void Btn_Voltaradc_Click(object sender, EventArgs e) { this.Close(); }
        private void Frm_AdicionarLivro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        // --- MÉTODOS ADICIONADOS PARA CORRIGIR ERROS CS1061 ---
        private void label1_Click(object sender, EventArgs e) { /* Deixe vazio */ }
        private void Cbx_Midia_SelectedIndexChanged(object sender, EventArgs e) { /* Deixe vazio */ }
        private void Txt_Titulo2_TextChanged(object sender, EventArgs e) { /* Deixe vazio */ }
        private void Frm_AdicionarLivro_Load(object sender, EventArgs e) { /* Deixe vazio */ }
    }
}