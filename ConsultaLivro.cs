using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RepositorioLivros.Entities;


namespace RepositorioLivros
{
    public partial class Frm_ConsultaLivro : Form
    {
        public Frm_ConsultaLivro()
        {
            InitializeComponent();
        }

        private void ConsultaLivro_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            var lista = CadastroLivro.JsonDesserializarLista(@"C:\REPOS\arq.txt");
            

            dataGridView1.DataSource = lista;
        }

        private void Ltv_BdLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

