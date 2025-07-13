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
            // Inicialização de todos os componentes que você usa
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultaLivro));
            this.Txb_TituloCL = new System.Windows.Forms.TextBox();
            this.Lbl_TituloCL = new System.Windows.Forms.Label();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Lbl_GeneroCL = new System.Windows.Forms.Label();
            this.Cbx_GeneroCL = new System.Windows.Forms.ComboBox();
            this.Lbl_AutorCL = new System.Windows.Forms.Label();
            this.Txt_AutorCL = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            // === NOVOS PAINÉIS DE LAYOUT ===
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.filtersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.filtersGroupBox.SuspendLayout();
            this.filtersTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // mainTableLayoutPanel (Painel principal que organiza a tela)
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.filtersGroupBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.dataGridView1, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(800, 600);
            
            // 
            // filtersGroupBox (Caixa para agrupar os filtros)
            // 
            this.filtersGroupBox.Controls.Add(this.filtersTableLayoutPanel);
            this.filtersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersGroupBox.Text = "Filtros de Pesquisa";
            this.filtersGroupBox.Padding = new System.Windows.Forms.Padding(10);

            // 
            // filtersTableLayoutPanel (Painel que organiza os filtros em uma grade)
            // 
            this.filtersTableLayoutPanel.ColumnCount = 5;
            this.filtersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle()); // AutoSize for Label
            this.filtersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle()); // AutoSize for Label
            this.filtersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filtersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle()); // AutoSize for Button
            this.filtersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersTableLayoutPanel.RowCount = 2;
            this.filtersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle()); // AutoSize
            this.filtersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle()); // AutoSize
            
            // --- Adicionando controles de filtro ao painel de filtros ---
            
            // Linha 1
            this.filtersTableLayoutPanel.Controls.Add(this.Lbl_TituloCL, 0, 0);
            this.filtersTableLayoutPanel.Controls.Add(this.Txb_TituloCL, 1, 0);
            this.filtersTableLayoutPanel.SetColumnSpan(this.Txb_TituloCL, 3); // Ocupa 3 colunas
            this.filtersTableLayoutPanel.Controls.Add(this.Btn_Pesquisar, 4, 0);
            this.filtersTableLayoutPanel.SetRowSpan(this.Btn_Pesquisar, 2); // Ocupa 2 linhas
            
            // Linha 2
            this.filtersTableLayoutPanel.Controls.Add(this.Lbl_GeneroCL, 0, 1);
            this.filtersTableLayoutPanel.Controls.Add(this.Cbx_GeneroCL, 1, 1);
            this.filtersTableLayoutPanel.Controls.Add(this.Lbl_AutorCL, 2, 1);
            this.filtersTableLayoutPanel.Controls.Add(this.Txt_AutorCL, 3, 1);

            // Configuração individual dos controles
            this.Lbl_TituloCL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_TituloCL.AutoSize = true;
            this.Txb_TituloCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Pesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_GeneroCL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Cbx_GeneroCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_AutorCL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Txt_AutorCL.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // 
            // dataGridView1 (Grid de dados)
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            
            // 
            // Frm_ConsultaLivro (Configuração final do formulário)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainTableLayoutPanel); // Adiciona o painel principal ao formulário
            this.Name = "Frm_ConsultaLivro";
            this.Text = "Consultar Livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(700, 500);

            // Finaliza o processo de design
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersTableLayoutPanel.ResumeLayout(false);
            this.filtersTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Declaração de todos os componentes
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.GroupBox filtersGroupBox;
        private System.Windows.Forms.TableLayoutPanel filtersTableLayoutPanel;
        private System.Windows.Forms.Label Lbl_TituloCL;
        private System.Windows.Forms.TextBox Txb_TituloCL;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.Label Lbl_GeneroCL;
        private System.Windows.Forms.ComboBox Cbx_GeneroCL;
        private System.Windows.Forms.Label Lbl_AutorCL;
        private System.Windows.Forms.TextBox Txt_AutorCL;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}