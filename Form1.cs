namespace RepositorioLivros
{
    public partial class MyBook : Form
    {
        public MyBook()
        {
            InitializeComponent();
        }

        private void Btn_CadastroLivro_Click(object sender, EventArgs e)
        {
            Frm_AdicionarLivro f = new Frm_AdicionarLivro();
            f.ShowDialog();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ConsultaLivros_Click(object sender, EventArgs e)
        {
            Frm_ConsultaLivro f = new Frm_ConsultaLivro();
            f.ShowDialog();
        }
    }
}