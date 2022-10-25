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
    }
}