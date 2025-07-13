using System;
using System.Drawing;
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
            AplicarEstiloModerno(); 
        }

        private void AplicarEstiloModerno()
        {
            // --- Paleta de Cores Consistente ---
            var corFundo = Color.FromArgb(248, 249, 250);
            var corTextoPrincipal = Color.FromArgb(33, 37, 41);
            var corDestaque = Color.FromArgb(13, 110, 253);
            var corSecundaria = Color.FromArgb(108, 117, 125);

            // --- Estilo do Formulário ---
            this.BackColor = corFundo;
            this.Font = new Font("Segoe UI", 10F);
            this.ForeColor = corTextoPrincipal;

            // --- Estilo dos Controles de Input ---
            foreach (var control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = new Font("Segoe UI", 10F);
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.FlatStyle = FlatStyle.Flat;
                    comboBox.Font = new Font("Segoe UI", 10F);
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.BorderStyle = BorderStyle.FixedSingle;
                    maskedTextBox.Font = new Font("Segoe UI", 10F);
                }
            }

            // --- Estilo dos Botões ---
            Btn_SalvarLivro.FlatStyle = FlatStyle.Flat;
            Btn_SalvarLivro.FlatAppearance.BorderSize = 0;
            Btn_SalvarLivro.BackColor = corDestaque;
            Btn_SalvarLivro.ForeColor = Color.White;
            Btn_SalvarLivro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_SalvarLivro.Height = 40;

            Btn_Voltaradc.FlatStyle = FlatStyle.Flat;
            Btn_Voltaradc.FlatAppearance.BorderSize = 1;
            Btn_Voltaradc.FlatAppearance.BorderColor = corSecundaria;
            Btn_Voltaradc.BackColor = Color.Transparent;
            Btn_Voltaradc.ForeColor = corSecundaria;
            Btn_Voltaradc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Voltaradc.Height = 40;
        }

        private void Btn_SalvarLivro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Titulo2.Text) || string.IsNullOrWhiteSpace(Cbx_Genero.Text) || string.IsNullOrWhiteSpace(Cbx_Midia.Text) || string.IsNullOrWhiteSpace(Cbx_AnoLancamento.Text) || string.IsNullOrWhiteSpace(Cbx_StatusLeitura.Text) || string.IsNullOrWhiteSpace(Cbx_AnoAquisicao.Text) || string.IsNullOrWhiteSpace(Msk_ValorLivro.Text) || string.IsNullOrWhiteSpace(Txt_Autor.Text))
            {
                MessageBox.Show("Ainda existem campos a serem preenchidos!", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(Msk_ValorLivro.Text.Replace("R$", "").Trim(), out double valorLivro))
            {
                MessageBox.Show("O valor do livro informado é inválido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var listaLivros = _livroService.CarregarLivros();
                var novoLivro = new CadastroLivro(
                    Txt_Titulo2.Text, Cbx_Genero.Text, Cbx_Midia.Text, Cbx_AnoLancamento.Text, Cbx_StatusLeitura.Text, Cbx_AnoAquisicao.Text,
                    valorLivro, Txt_Autor.Text, Chkb_SagaS.Checked ? "Sim" : "Não"
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

        private void Btn_Voltaradc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_AdicionarLivro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // --- MÉTODOS ADICIONADOS PARA CORRIGIR ERROS DO DESIGNER ---

        private void label1_Click(object sender, EventArgs e)
        {
            // Este método pode ficar vazio.
        }

        private void Cbx_Midia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este método pode ficar vazio.
        }

        private void Txt_Titulo2_TextChanged(object sender, EventArgs e)
        {
            // Este método pode ficar vazio.
        }

        private void Frm_AdicionarLivro_Load(object sender, EventArgs e)
        {
            // Este método pode ficar vazio.
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            // Chama a mesma função do botão salvar principal
            Btn_SalvarLivro_Click(sender, e);
}

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            // Chama a função de limpar os campos
            LimparCampos();
        }
    }
}