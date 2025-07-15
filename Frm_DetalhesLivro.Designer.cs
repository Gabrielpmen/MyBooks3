namespace RepositorioLivros
{
    partial class Frm_DetalhesLivro
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloDesc = new System.Windows.Forms.Label();
            this.lblTituloData = new System.Windows.Forms.Label();
            this.lblAutorDesc = new System.Windows.Forms.Label();
            this.lblAutorData = new System.Windows.Forms.Label();
            this.lblGeneroDesc = new System.Windows.Forms.Label();
            this.lblGeneroData = new System.Windows.Forms.Label();
            this.lblMidiaDesc = new System.Windows.Forms.Label();
            this.lblMidiaData = new System.Windows.Forms.Label();
            this.lblAnoLancamentoDesc = new System.Windows.Forms.Label();
            this.lblAnoLancamentoData = new System.Windows.Forms.Label();
            this.lblStatusDesc = new System.Windows.Forms.Label();
            this.lblStatusData = new System.Windows.Forms.Label();
            this.lblAnoCompraDesc = new System.Windows.Forms.Label();
            this.lblAnoCompraData = new System.Windows.Forms.Label();
            this.lblValorPagoDesc = new System.Windows.Forms.Label();
            this.lblValorPagoData = new System.Windows.Forms.Label();
            this.lblSagaDesc = new System.Windows.Forms.Label();
            this.lblSagaData = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.lblTituloDesc, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.lblTituloData, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.lblAutorDesc, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.lblAutorData, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.lblGeneroDesc, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.lblGeneroData, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.lblMidiaDesc, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.lblMidiaData, 1, 3);
            this.mainTableLayoutPanel.Controls.Add(this.lblAnoLancamentoDesc, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.lblAnoLancamentoData, 1, 4);
            this.mainTableLayoutPanel.Controls.Add(this.lblStatusDesc, 0, 5);
            this.mainTableLayoutPanel.Controls.Add(this.lblStatusData, 1, 5);
            this.mainTableLayoutPanel.Controls.Add(this.lblAnoCompraDesc, 0, 6);
            this.mainTableLayoutPanel.Controls.Add(this.lblAnoCompraData, 1, 6);
            this.mainTableLayoutPanel.Controls.Add(this.lblValorPagoDesc, 0, 7);
            this.mainTableLayoutPanel.Controls.Add(this.lblValorPagoData, 1, 7);
            this.mainTableLayoutPanel.Controls.Add(this.lblSagaDesc, 0, 8);
            this.mainTableLayoutPanel.Controls.Add(this.lblSagaData, 1, 8);
            this.mainTableLayoutPanel.Controls.Add(this.Btn_Fechar, 1, 9);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainTableLayoutPanel.RowCount = 10;
            for (int i = 0; i < 10; i++) this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));

            // Labels de Descrição (coluna da esquerda)
            var descLabels = new[] { lblTituloDesc, lblAutorDesc, lblGeneroDesc, lblMidiaDesc, lblAnoLancamentoDesc, lblStatusDesc, lblAnoCompraDesc, lblValorPagoDesc, lblSagaDesc };
            foreach (var lbl in descLabels)
            {
                lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
                lbl.AutoSize = true;
            }
            lblTituloDesc.Text = "Título:";
            lblAutorDesc.Text = "Autor:";
            lblGeneroDesc.Text = "Gênero:";
            lblMidiaDesc.Text = "Mídia:";
            lblAnoLancamentoDesc.Text = "Ano de Lançamento:";
            lblStatusDesc.Text = "Status da Leitura:";
            lblAnoCompraDesc.Text = "Ano de Compra:";
            lblValorPagoDesc.Text = "Valor Pago:";
            lblSagaDesc.Text = "Faz parte de Saga:";

            // Labels de Dados (coluna da direita)
            var dataLabels = new[] { lblTituloData, lblAutorData, lblGeneroData, lblMidiaData, lblAnoLancamentoData, lblStatusData, lblAnoCompraData, lblValorPagoData, lblSagaData };
            foreach (var lbl in dataLabels)
            {
                lbl.Font = new System.Drawing.Font("Segoe UI", 10F);
                lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
                lbl.AutoSize = true;
            }

            // Botão Fechar
            this.Btn_Fechar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(120, 35);
            this.Btn_Fechar.Text = "Fechar";

            // 
            // Frm_DetalhesLivro
            // 
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DetalhesLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes do Livro";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label lblTituloDesc;
        private System.Windows.Forms.Label lblTituloData;
        private System.Windows.Forms.Label lblAutorDesc;
        private System.Windows.Forms.Label lblAutorData;
        private System.Windows.Forms.Label lblGeneroDesc;
        private System.Windows.Forms.Label lblGeneroData;
        private System.Windows.Forms.Label lblMidiaDesc;
        private System.Windows.Forms.Label lblMidiaData;
        private System.Windows.Forms.Label lblAnoLancamentoDesc;
        private System.Windows.Forms.Label lblAnoLancamentoData;
        private System.Windows.Forms.Label lblStatusDesc;
        private System.Windows.Forms.Label lblStatusData;
        private System.Windows.Forms.Label lblAnoCompraDesc;
        private System.Windows.Forms.Label lblAnoCompraData;
        private System.Windows.Forms.Label lblValorPagoDesc;
        private System.Windows.Forms.Label lblValorPagoData;
        private System.Windows.Forms.Label lblSagaDesc;
        private System.Windows.Forms.Label lblSagaData;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}