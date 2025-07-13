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
            this.components = new System.ComponentModel.Container();
            // Declaração de todos os componentes
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.filtersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.Lbl_TituloCL = new System.Windows.Forms.Label();
            this.Txb_TituloCL = new System.Windows.Forms.TextBox();
            this.Lbl_AutorCL = new System.Windows.Forms.Label();
            this.Txt_AutorCL = new System.Windows.Forms.TextBox();
            this.Lbl_GeneroCL = new System.Windows.Forms.Label();
            this.Cbx_GeneroCL = new System.Windows.Forms.ComboBox();
            this.Lbl_MidiaCL = new System.Windows.Forms.Label();
            this.Cbx_MidiaCL = new System.Windows.Forms.ComboBox();
            this.Lbl_AnoLancamentoCL = new System.Windows.Forms.Label();
            this.Cbx_AnoLancamentoCL = new System.Windows.Forms.ComboBox();
            this.Lbl_StatusLeituraCL = new System.Windows.Forms.Label();
            this.Cbx_StatusLeituraCL = new System.Windows.Forms.ComboBox();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            // Pausa o desenho do layout para configurar os componentes
            this.mainTableLayoutPanel.SuspendLayout();
            this.filtersGroupBox.SuspendLayout();
            this.filtersTableLayoutPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.filtersGroupBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.dataGridView1, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.filtersTableLayoutPanel);
            this.filtersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersGroupBox.Text = "Filtros de Pesquisa";

            // 
            // filtersTableLayoutPanel
            // 
            this.filtersTableLayoutPanel.ColumnCount = 4;
            this.filtersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.filtersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.filtersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersTableLayoutPanel.RowCount = 4;
            this.filtersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filtersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filtersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filtersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());

            // Adicionando controles à grade de filtros
            this.filtersTableLayoutPanel.Controls.Add(this.Lbl_TituloCL, 0, 0);
            this.filtersTableLayoutPanel.Controls.Add(this.Txb_TituloCL, 1, 0);
            this.filtersTableLayoutPanel.SetColumnSpan(this.Txb_TituloCL, 3);
            this.filtersTableLayoutPanel.Controls.Add(this.Lbl_AutorCL, 0, 1);
            this.filtersTableLayoutPanel.Controls.Add(this.Txt_AutorCL, 1, 1);
            this.filtersTableLayoutPanel.SetColumnSpan(this.Txt_AutorCL, 3);
            this.filtersTableLayoutPanel.Controls.Add(this.Lbl_GeneroCL, 0, 2);
            this.filtersTableLayoutPanel.Controls.Add(this.Cbx_GeneroCL, 1, 2);
            this.filtersTableLayoutPanel.Controls.Add(this.Lbl_MidiaCL, 2, 2);
            this.filtersTableLayoutPanel.Controls.Add(this.Cbx_MidiaCL, 3, 2);
            this.filtersTableLayoutPanel.Controls.Add(this.Lbl_AnoLancamentoCL, 0, 3);
            this.filtersTableLayoutPanel.Controls.Add(this.Cbx_AnoLancamentoCL, 1, 3);
            this.filtersTableLayoutPanel.Controls.Add(this.Lbl_StatusLeituraCL, 2, 3);
            this.filtersTableLayoutPanel.Controls.Add(this.Cbx_StatusLeituraCL, 3, 3);
            this.filtersTableLayoutPanel.Controls.Add(this.buttonsPanel, 0, 4);
            this.filtersTableLayoutPanel.SetColumnSpan(this.buttonsPanel, 4);

            // 
            // buttonsPanel (Painel para alinhar os botões à direita)
            // 
            this.buttonsPanel.Controls.Add(this.Btn_Excluir);
            this.buttonsPanel.Controls.Add(this.Btn_Pesquisar);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            // Configuração individual dos controles
            this.Lbl_TituloCL.Text = "Título:";
            this.Lbl_AutorCL.Text = "Autor:";
            this.Lbl_GeneroCL.Text = "Gênero:";
            this.Lbl_MidiaCL.Text = "Mídia:";
            this.Lbl_AnoLancamentoCL.Text = "Ano Lanç.:";
            this.Lbl_StatusLeituraCL.Text = "Status:";

            this.Btn_Pesquisar.Text = "Pesquisar";
            this.Btn_Pesquisar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Pesquisar.Size = new System.Drawing.Size(120, 40);

            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Excluir.Size = new System.Drawing.Size(120, 40);

            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);

            // 
            // Frm_ConsultaLivro
            // 
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "Frm_ConsultaLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Livros";
            this.Load += new System.EventHandler(this.ConsultaLivro_Load); // Ligando o evento Load

            // Retoma o desenho do layout
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersTableLayoutPanel.ResumeLayout(false);
            this.filtersTableLayoutPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.GroupBox filtersGroupBox;
        private System.Windows.Forms.TableLayoutPanel filtersTableLayoutPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Label Lbl_TituloCL;
        private System.Windows.Forms.TextBox Txb_TituloCL;
        private System.Windows.Forms.Label Lbl_AutorCL;
        private System.Windows.Forms.TextBox Txt_AutorCL;
        private System.Windows.Forms.Label Lbl_GeneroCL;
        private System.Windows.Forms.ComboBox Cbx_GeneroCL;
        private System.Windows.Forms.Label Lbl_MidiaCL;
        private System.Windows.Forms.ComboBox Cbx_MidiaCL;
        private System.Windows.Forms.Label Lbl_AnoLancamentoCL;
        private System.Windows.Forms.ComboBox Cbx_AnoLancamentoCL;
        private System.Windows.Forms.Label Lbl_StatusLeituraCL;
        private System.Windows.Forms.ComboBox Cbx_StatusLeituraCL;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}