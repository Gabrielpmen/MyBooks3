using System.Drawing; // Importe para usar Font e Color
using System.Windows.Forms;

namespace RepositorioLivros
{
    public partial class MyBook : Form
    {
        public MyBook()
        {
            InitializeComponent();
            AplicarEstiloModerno();
        }

        private void AplicarEstiloModerno()
        {
            var corFundo = Color.FromArgb(248, 249, 250);
            var corTextoPrincipal = Color.FromArgb(33, 37, 41);
            var corDestaque = Color.FromArgb(13, 110, 253);
            var corSecundaria = Color.FromArgb(108, 117, 125);

            this.BackColor = corFundo;
            this.mainTableLayoutPanel.BackColor = corFundo;

            Lbl_AppTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            Lbl_AppTitle.ForeColor = corTextoPrincipal;
            Lbl_AppTitle.Margin = new Padding(10, 10, 10, 40);

            var botoesPrimarios = new[] { Btn_CadastroLivro, Btn_ConsultaLivros };
            foreach (var btn in botoesPrimarios)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = corDestaque;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                btn.TextImageRelation = TextImageRelation.ImageBeforeText; // Posição do ícone
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(10, 0, 0, 0); // Espaço entre ícone e texto
            }

            Btn_Sair.FlatStyle = FlatStyle.Flat;
            Btn_Sair.FlatAppearance.BorderSize = 1;
            Btn_Sair.FlatAppearance.BorderColor = corSecundaria;
            Btn_Sair.BackColor = corFundo;
            Btn_Sair.ForeColor = corSecundaria;
            Btn_Sair.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_Sair.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Sair.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Sair.Padding = new Padding(10, 0, 0, 0);

            // --- MUDANÇA: ADICIONA OS ÍCONES ---
            // Substitua 'add_icon', 'search_icon' e 'exit_icon' pelos nomes dos seus arquivos de recurso.
            Btn_CadastroLivro.Image = ByteArrayToImage(Properties.Resources.plus1);
            Btn_ConsultaLivros.Image = ByteArrayToImage(Properties.Resources.search);
            Btn_Sair.Image = ByteArrayToImage(Properties.Resources.logout);
        }


                private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private void Btn_CadastroLivro_Click(object sender, System.EventArgs e)
        {
            Frm_AdicionarLivro f = new Frm_AdicionarLivro();
            f.ShowDialog();
        }

        private void Btn_Sair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Btn_ConsultaLivros_Click(object sender, System.EventArgs e)
        {
            Frm_ConsultaLivro f = new Frm_ConsultaLivro();
            f.ShowDialog();
        }
    }
}