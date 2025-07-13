namespace RepositorioLivros
{
    partial class Frm_ConsultaLivro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Lbl_TituloCL = new System.Windows.Forms.Label();
            this.Txb_TituloCL = new System.Windows.Forms.TextBox();
            this.Lbl_AutorCL = new System.Windows.Forms.Label();
            this.Txt_AutorCL = new System.Windows.Forms.TextBox();
            this.Lbl_GeneroCL = new System.Windows.Forms.Label();
            this.Cbx_GeneroCL = new System.Windows.Forms.ComboBox();
            this.Lbl_MidiaCL = new System.Windows.Forms.Label();
            this.Cbx_MidiaCL = new System.Windows.Forms.ComboBox();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_TituloCL
            // 
            this.Lbl_TituloCL.AutoSize = true;
            this.Lbl_TituloCL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_TituloCL.Location = new System.Drawing.Point(23, 29);
            this.Lbl_TituloCL.Name = "Lbl_TituloCL";
            this.Lbl_TituloCL.Size = new System.Drawing.Size(59, 23);
            this.Lbl_TituloCL.Text = "Título:";
            // 
            // Txb_TituloCL
            // 
            this.Txb_TituloCL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Txb_TituloCL.Location = new System.Drawing.Point(88, 26);
            this.Txb_TituloCL.Name = "Txb_TituloCL";
            this.Txb_TituloCL.Size = new System.Drawing.Size(370, 30);
            // 
            // Lbl_AutorCL
            // 
            this.Lbl_AutorCL.AutoSize = true;
            this.Lbl_AutorCL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_AutorCL.Location = new System.Drawing.Point(480, 29);
            this.Lbl_AutorCL.Name = "Lbl_AutorCL";
            this.Lbl_AutorCL.Size = new System.Drawing.Size(57, 23);
            this.Lbl_AutorCL.Text = "Autor:";
            // 
            // Txt_AutorCL
            // 
            this.Txt_AutorCL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Txt_AutorCL.Location = new System.Drawing.Point(545, 26);
            this.Txt_AutorCL.Name = "Txt_AutorCL";
            this.Txt_AutorCL.Size = new System.Drawing.Size(370, 30);
            // 
            // Lbl_GeneroCL
            // 
            this.Lbl_GeneroCL.AutoSize = true;
            this.Lbl_GeneroCL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_GeneroCL.Location = new System.Drawing.Point(23, 70);
            this.Lbl_GeneroCL.Name = "Lbl_GeneroCL";
            this.Lbl_GeneroCL.Size = new System.Drawing.Size(68, 23);
            this.Lbl_GeneroCL.Text = "Gênero:";
            // 
            // Cbx_GeneroCL
            // 
            this.Cbx_GeneroCL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cbx_GeneroCL.FormattingEnabled = true;
            // --- CÓDIGO ADICIONADO PARA POPULAR A LISTA ---
            this.Cbx_GeneroCL.Items.AddRange(new object[] {
            "Horror",
            "Romance",
            "Thriller e Suspense",
            "Infantil",
            "Crimes Reais",
            "Humor e comédia",
            "Ficção científica",
            "Ação e aventura",
            "Autoajuda",
            "Gastronomia",
            "Fantasia"});
            // --- FIM DO CÓDIGO ADICIONADO ---
            this.Cbx_GeneroCL.Location = new System.Drawing.Point(95, 67);
            this.Cbx_GeneroCL.Name = "Cbx_GeneroCL";
            this.Cbx_GeneroCL.Size = new System.Drawing.Size(180, 31);
            // 
            // Lbl_MidiaCL
            // 
            this.Lbl_MidiaCL.AutoSize = true;
            this.Lbl_MidiaCL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_MidiaCL.Location = new System.Drawing.Point(295, 70);
            this.Lbl_MidiaCL.Name = "Lbl_MidiaCL";
            this.Lbl_MidiaCL.Size = new System.Drawing.Size(57, 23);
            this.Lbl_MidiaCL.Text = "Mídia:";
            // 
            // Cbx_MidiaCL
            // 
            this.Cbx_MidiaCL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cbx_MidiaCL.FormattingEnabled = true;
            this.Cbx_MidiaCL.Items.AddRange(new object[] { "Física", "Digital" });
            this.Cbx_MidiaCL.Location = new System.Drawing.Point(358, 67);
            this.Cbx_MidiaCL.Name = "Cbx_MidiaCL";
            this.Cbx_MidiaCL.Size = new System.Drawing.Size(180, 31);
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Pesquisar.Location = new System.Drawing.Point(27, 120);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(120, 40);
            this.Btn_Pesquisar.Text = "Pesquisar";

            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Excluir.Location = new System.Drawing.Point(163, 120);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(120, 40);
            this.Btn_Excluir.Text = "Excluir";

            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(896, 399);

            // 
            // Frm_ConsultaLivro
            // 
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Cbx_MidiaCL);
            this.Controls.Add(this.Lbl_MidiaCL);
            this.Controls.Add(this.Cbx_GeneroCL);
            this.Controls.Add(this.Lbl_GeneroCL);
            this.Controls.Add(this.Txt_AutorCL);
            this.Controls.Add(this.Lbl_AutorCL);
            this.Controls.Add(this.Txb_TituloCL);
            this.Controls.Add(this.Lbl_TituloCL);
            this.Name = "Frm_ConsultaLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Livros";
            this.Load += new System.EventHandler(this.ConsultaLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Lbl_TituloCL;
        private System.Windows.Forms.TextBox Txb_TituloCL;
        private System.Windows.Forms.Label Lbl_AutorCL;
        private System.Windows.Forms.TextBox Txt_AutorCL;
        private System.Windows.Forms.Label Lbl_GeneroCL;
        private System.Windows.Forms.ComboBox Cbx_GeneroCL;
        private System.Windows.Forms.Label Lbl_MidiaCL;
        private System.Windows.Forms.ComboBox Cbx_MidiaCL;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}