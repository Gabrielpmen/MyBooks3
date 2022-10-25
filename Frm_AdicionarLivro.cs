using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepositorioLivros.Entities;

namespace RepositorioLivros
{
    public partial class Frm_AdicionarLivro : Form 
    {
        public Frm_AdicionarLivro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_AdicionarLivro_Load(object sender, EventArgs e)
        {

        }

        private void Frm_AdicionarLivro_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Se o usuário clicar em “Não” na caixa de dialogo a saída será abortada, caso contrario o form é fechado.

            if (MessageBox.Show("Deseja realmente sair ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)

            {

                e.Cancel = true;

            }

        }

        private void Btn_SalvarLivro_Click(object sender, EventArgs e)
        {
           

            if (Txt_Titulo2.Text == "" || Cbx_Genero.Text == "" || Cbx_Midia.Text == "" || Cbx_AnoLancamento.Text == "" || Cbx_StatusLeitura.Text == "" || Cbx_AnoAquisicao.Text == "" || Msk_ValorLivro.Text == "" || Txt_Autor.Text == "") 
            {
                MessageBox.Show("Ainda existem campos à serem preenchidos!", "Erro",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string midia = Cbx_Midia.Text;
                string anolancamento = Cbx_AnoLancamento.Text;
                string esaga = Chkb_SagaS.Text;
                CadastroLivro.cadastraolivro(Txt_Titulo2.Text, Cbx_Genero.Text, midia, anolancamento, Cbx_StatusLeitura.Text, Cbx_AnoAquisicao.Text, Msk_ValorLivro.Text, Txt_Autor.Text, esaga);

                Txt_Titulo2.Text = null;
                Cbx_Genero.Text = null;
                Cbx_Midia.Text = null;
                Cbx_AnoLancamento.Text = null;
                Cbx_StatusLeitura.Text = null;
                Cbx_AnoAquisicao.Text = null;
                Msk_ValorLivro.Text = null;
                Txt_Autor.Text = null;
            }
            
            
        }

        private void Txt_Titulo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cbx_Midia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Voltaradc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
    }

