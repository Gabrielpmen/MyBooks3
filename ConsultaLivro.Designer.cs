namespace RepositorioLivros
{
    partial class Frm_ConsultaLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultaLivro));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Ltv_BdLivros = new System.Windows.Forms.ListView();
            this.Cl_Titulo = new System.Windows.Forms.ColumnHeader();
            this.Cl_Genero = new System.Windows.Forms.ColumnHeader();
            this.Cl_Midia = new System.Windows.Forms.ColumnHeader();
            this.Cl_AnoLancamento = new System.Windows.Forms.ColumnHeader();
            this.Cl_StatusLeitura = new System.Windows.Forms.ColumnHeader();
            this.Cl_AnoAquisição = new System.Windows.Forms.ColumnHeader();
            this.Cl_ValorPago = new System.Windows.Forms.ColumnHeader();
            this.Cl_Autor = new System.Windows.Forms.ColumnHeader();
            this.Cl_Emprestado = new System.Windows.Forms.ColumnHeader();
            this.Lbl_TituloCL = new System.Windows.Forms.Label();
            this.Txb_TituloCL = new System.Windows.Forms.TextBox();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Lbl_GeneroCL = new System.Windows.Forms.Label();
            this.Cbx_GeneroCL = new System.Windows.Forms.ComboBox();
            this.Lbl_MidiaCL = new System.Windows.Forms.Label();
            this.Cbx_MidiaCL = new System.Windows.Forms.ComboBox();
            this.Lbl_AnoLancamentoCL = new System.Windows.Forms.Label();
            this.Cbx_AnoLancamentoCL = new System.Windows.Forms.ComboBox();
            this.Lbl_StatusLeituraCL = new System.Windows.Forms.Label();
            this.Cbx_StatusLeituraCL = new System.Windows.Forms.ComboBox();
            this.Lbl_AnoAquisicaoCL = new System.Windows.Forms.Label();
            this.Cbx_AnoAquisicaoCL = new System.Windows.Forms.ComboBox();
            this.Lbl_ValorPagoCL = new System.Windows.Forms.Label();
            this.Msk_ValorLivroCL = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_AutorCL = new System.Windows.Forms.Label();
            this.Txt_AutorCL = new System.Windows.Forms.TextBox();
            this.Lbl_EstaEmprestado = new System.Windows.Forms.Label();
            this.Chkb_SagaSCL = new System.Windows.Forms.CheckBox();
            this.Chkb_SagaNCL = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Ltv_BdLivros
            // 
            this.Ltv_BdLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Ltv_BdLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cl_Titulo,
            this.Cl_Genero,
            this.Cl_Midia,
            this.Cl_AnoLancamento,
            this.Cl_StatusLeitura,
            this.Cl_AnoAquisição,
            this.Cl_ValorPago,
            this.Cl_Autor,
            this.Cl_Emprestado});
            this.Ltv_BdLivros.FullRowSelect = true;
            this.Ltv_BdLivros.GridLines = true;
            this.Ltv_BdLivros.Location = new System.Drawing.Point(70, 417);
            this.Ltv_BdLivros.MultiSelect = false;
            this.Ltv_BdLivros.Name = "Ltv_BdLivros";
            this.Ltv_BdLivros.Size = new System.Drawing.Size(1896, 499);
            this.Ltv_BdLivros.TabIndex = 1;
            this.Ltv_BdLivros.UseCompatibleStateImageBehavior = false;
            this.Ltv_BdLivros.View = System.Windows.Forms.View.Details;
            // 
            // Cl_Titulo
            // 
            this.Cl_Titulo.Text = "Título";
            this.Cl_Titulo.Width = 500;
            // 
            // Cl_Genero
            // 
            this.Cl_Genero.Text = "Gênero";
            this.Cl_Genero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cl_Genero.Width = 200;
            // 
            // Cl_Midia
            // 
            this.Cl_Midia.Text = "Mídia";
            this.Cl_Midia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cl_AnoLancamento
            // 
            this.Cl_AnoLancamento.Text = "Ano de Lanç.";
            this.Cl_AnoLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cl_AnoLancamento.Width = 150;
            // 
            // Cl_StatusLeitura
            // 
            this.Cl_StatusLeitura.Text = "Status da Leitura";
            this.Cl_StatusLeitura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cl_StatusLeitura.Width = 200;
            // 
            // Cl_AnoAquisição
            // 
            this.Cl_AnoAquisição.Text = "Ano de Aquisição";
            this.Cl_AnoAquisição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cl_AnoAquisição.Width = 160;
            // 
            // Cl_ValorPago
            // 
            this.Cl_ValorPago.Text = "Valor";
            this.Cl_ValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cl_ValorPago.Width = 100;
            // 
            // Cl_Autor
            // 
            this.Cl_Autor.Text = "Autor";
            this.Cl_Autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cl_Autor.Width = 400;
            // 
            // Cl_Emprestado
            // 
            this.Cl_Emprestado.Text = "Emprestado?";
            this.Cl_Emprestado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cl_Emprestado.Width = 120;
            // 
            // Lbl_TituloCL
            // 
            this.Lbl_TituloCL.AutoSize = true;
            this.Lbl_TituloCL.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TituloCL.Location = new System.Drawing.Point(460, 60);
            this.Lbl_TituloCL.Name = "Lbl_TituloCL";
            this.Lbl_TituloCL.Size = new System.Drawing.Size(78, 30);
            this.Lbl_TituloCL.TabIndex = 2;
            this.Lbl_TituloCL.Text = "Título :";
            // 
            // Txb_TituloCL
            // 
            this.Txb_TituloCL.Location = new System.Drawing.Point(565, 60);
            this.Txb_TituloCL.Name = "Txb_TituloCL";
            this.Txb_TituloCL.Size = new System.Drawing.Size(914, 31);
            this.Txb_TituloCL.TabIndex = 3;
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Location = new System.Drawing.Point(1522, 60);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(112, 34);
            this.Btn_Pesquisar.TabIndex = 4;
            this.Btn_Pesquisar.Text = "Pesquisar";
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // Lbl_GeneroCL
            // 
            this.Lbl_GeneroCL.AutoSize = true;
            this.Lbl_GeneroCL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_GeneroCL.Location = new System.Drawing.Point(254, 154);
            this.Lbl_GeneroCL.Name = "Lbl_GeneroCL";
            this.Lbl_GeneroCL.Size = new System.Drawing.Size(85, 28);
            this.Lbl_GeneroCL.TabIndex = 5;
            this.Lbl_GeneroCL.Text = "Gênero :";
            // 
            // Cbx_GeneroCL
            // 
            this.Cbx_GeneroCL.FormattingEnabled = true;
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
            this.Cbx_GeneroCL.Location = new System.Drawing.Point(205, 185);
            this.Cbx_GeneroCL.Name = "Cbx_GeneroCL";
            this.Cbx_GeneroCL.Size = new System.Drawing.Size(182, 33);
            this.Cbx_GeneroCL.TabIndex = 25;
            // 
            // Lbl_MidiaCL
            // 
            this.Lbl_MidiaCL.AutoSize = true;
            this.Lbl_MidiaCL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_MidiaCL.Location = new System.Drawing.Point(485, 154);
            this.Lbl_MidiaCL.Name = "Lbl_MidiaCL";
            this.Lbl_MidiaCL.Size = new System.Drawing.Size(71, 28);
            this.Lbl_MidiaCL.TabIndex = 26;
            this.Lbl_MidiaCL.Text = "Mídia :";
            // 
            // Cbx_MidiaCL
            // 
            this.Cbx_MidiaCL.FormattingEnabled = true;
            this.Cbx_MidiaCL.Items.AddRange(new object[] {
            "Física",
            "Digital"});
            this.Cbx_MidiaCL.Location = new System.Drawing.Point(429, 185);
            this.Cbx_MidiaCL.Name = "Cbx_MidiaCL";
            this.Cbx_MidiaCL.Size = new System.Drawing.Size(182, 33);
            this.Cbx_MidiaCL.TabIndex = 27;
            // 
            // Lbl_AnoLancamentoCL
            // 
            this.Lbl_AnoLancamentoCL.AutoSize = true;
            this.Lbl_AnoLancamentoCL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AnoLancamentoCL.Location = new System.Drawing.Point(656, 154);
            this.Lbl_AnoLancamentoCL.Name = "Lbl_AnoLancamentoCL";
            this.Lbl_AnoLancamentoCL.Size = new System.Drawing.Size(195, 28);
            this.Lbl_AnoLancamentoCL.TabIndex = 28;
            this.Lbl_AnoLancamentoCL.Text = "Ano de Lançamento :";
            // 
            // Cbx_AnoLancamentoCL
            // 
            this.Cbx_AnoLancamentoCL.FormattingEnabled = true;
            this.Cbx_AnoLancamentoCL.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.Cbx_AnoLancamentoCL.Location = new System.Drawing.Point(656, 185);
            this.Cbx_AnoLancamentoCL.Name = "Cbx_AnoLancamentoCL";
            this.Cbx_AnoLancamentoCL.Size = new System.Drawing.Size(182, 33);
            this.Cbx_AnoLancamentoCL.TabIndex = 29;
            // 
            // Lbl_StatusLeituraCL
            // 
            this.Lbl_StatusLeituraCL.AutoSize = true;
            this.Lbl_StatusLeituraCL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_StatusLeituraCL.Location = new System.Drawing.Point(898, 154);
            this.Lbl_StatusLeituraCL.Name = "Lbl_StatusLeituraCL";
            this.Lbl_StatusLeituraCL.Size = new System.Drawing.Size(165, 28);
            this.Lbl_StatusLeituraCL.TabIndex = 30;
            this.Lbl_StatusLeituraCL.Text = "Status da Leitura :";
            // 
            // Cbx_StatusLeituraCL
            // 
            this.Cbx_StatusLeituraCL.FormattingEnabled = true;
            this.Cbx_StatusLeituraCL.Items.AddRange(new object[] {
            "Não Iniciada",
            "Em Andamento",
            "Concluído"});
            this.Cbx_StatusLeituraCL.Location = new System.Drawing.Point(898, 185);
            this.Cbx_StatusLeituraCL.Name = "Cbx_StatusLeituraCL";
            this.Cbx_StatusLeituraCL.Size = new System.Drawing.Size(182, 33);
            this.Cbx_StatusLeituraCL.TabIndex = 31;
            // 
            // Lbl_AnoAquisicaoCL
            // 
            this.Lbl_AnoAquisicaoCL.AutoSize = true;
            this.Lbl_AnoAquisicaoCL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AnoAquisicaoCL.Location = new System.Drawing.Point(1129, 154);
            this.Lbl_AnoAquisicaoCL.Name = "Lbl_AnoAquisicaoCL";
            this.Lbl_AnoAquisicaoCL.Size = new System.Drawing.Size(174, 28);
            this.Lbl_AnoAquisicaoCL.TabIndex = 32;
            this.Lbl_AnoAquisicaoCL.Text = "Ano de Aquisição :";
            // 
            // Cbx_AnoAquisicaoCL
            // 
            this.Cbx_AnoAquisicaoCL.FormattingEnabled = true;
            this.Cbx_AnoAquisicaoCL.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.Cbx_AnoAquisicaoCL.Location = new System.Drawing.Point(1129, 185);
            this.Cbx_AnoAquisicaoCL.Name = "Cbx_AnoAquisicaoCL";
            this.Cbx_AnoAquisicaoCL.Size = new System.Drawing.Size(182, 33);
            this.Cbx_AnoAquisicaoCL.TabIndex = 33;
            // 
            // Lbl_ValorPagoCL
            // 
            this.Lbl_ValorPagoCL.AutoSize = true;
            this.Lbl_ValorPagoCL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ValorPagoCL.Location = new System.Drawing.Point(1378, 154);
            this.Lbl_ValorPagoCL.Name = "Lbl_ValorPagoCL";
            this.Lbl_ValorPagoCL.Size = new System.Drawing.Size(115, 28);
            this.Lbl_ValorPagoCL.TabIndex = 34;
            this.Lbl_ValorPagoCL.Text = "Valor Pago :";
            // 
            // Msk_ValorLivroCL
            // 
            this.Msk_ValorLivroCL.Location = new System.Drawing.Point(1499, 154);
            this.Msk_ValorLivroCL.Mask = "000,00";
            this.Msk_ValorLivroCL.Name = "Msk_ValorLivroCL";
            this.Msk_ValorLivroCL.Size = new System.Drawing.Size(73, 31);
            this.Msk_ValorLivroCL.TabIndex = 35;
            // 
            // Lbl_AutorCL
            // 
            this.Lbl_AutorCL.AutoSize = true;
            this.Lbl_AutorCL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AutorCL.Location = new System.Drawing.Point(476, 112);
            this.Lbl_AutorCL.Name = "Lbl_AutorCL";
            this.Lbl_AutorCL.Size = new System.Drawing.Size(71, 28);
            this.Lbl_AutorCL.TabIndex = 36;
            this.Lbl_AutorCL.Text = "Autor :";
            // 
            // Txt_AutorCL
            // 
            this.Txt_AutorCL.Location = new System.Drawing.Point(565, 109);
            this.Txt_AutorCL.Name = "Txt_AutorCL";
            this.Txt_AutorCL.Size = new System.Drawing.Size(914, 31);
            this.Txt_AutorCL.TabIndex = 37;
            // 
            // Lbl_EstaEmprestado
            // 
            this.Lbl_EstaEmprestado.AutoSize = true;
            this.Lbl_EstaEmprestado.Location = new System.Drawing.Point(1621, 160);
            this.Lbl_EstaEmprestado.Name = "Lbl_EstaEmprestado";
            this.Lbl_EstaEmprestado.Size = new System.Drawing.Size(153, 25);
            this.Lbl_EstaEmprestado.TabIndex = 38;
            this.Lbl_EstaEmprestado.Text = "Está emprestado?";
            // 
            // Chkb_SagaSCL
            // 
            this.Chkb_SagaSCL.AutoSize = true;
            this.Chkb_SagaSCL.Location = new System.Drawing.Point(1621, 188);
            this.Chkb_SagaSCL.Name = "Chkb_SagaSCL";
            this.Chkb_SagaSCL.Size = new System.Drawing.Size(68, 29);
            this.Chkb_SagaSCL.TabIndex = 39;
            this.Chkb_SagaSCL.Text = "Sim";
            this.Chkb_SagaSCL.UseVisualStyleBackColor = true;
            // 
            // Chkb_SagaNCL
            // 
            this.Chkb_SagaNCL.AutoSize = true;
            this.Chkb_SagaNCL.Location = new System.Drawing.Point(1703, 189);
            this.Chkb_SagaNCL.Name = "Chkb_SagaNCL";
            this.Chkb_SagaNCL.Size = new System.Drawing.Size(71, 29);
            this.Chkb_SagaNCL.TabIndex = 40;
            this.Chkb_SagaNCL.Text = "Não";
            this.Chkb_SagaNCL.UseVisualStyleBackColor = true;
            // 
            // Frm_ConsultaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2027, 978);
            this.Controls.Add(this.Chkb_SagaNCL);
            this.Controls.Add(this.Chkb_SagaSCL);
            this.Controls.Add(this.Lbl_EstaEmprestado);
            this.Controls.Add(this.Txt_AutorCL);
            this.Controls.Add(this.Lbl_AutorCL);
            this.Controls.Add(this.Msk_ValorLivroCL);
            this.Controls.Add(this.Lbl_ValorPagoCL);
            this.Controls.Add(this.Cbx_AnoAquisicaoCL);
            this.Controls.Add(this.Lbl_AnoAquisicaoCL);
            this.Controls.Add(this.Cbx_StatusLeituraCL);
            this.Controls.Add(this.Lbl_StatusLeituraCL);
            this.Controls.Add(this.Cbx_AnoLancamentoCL);
            this.Controls.Add(this.Lbl_AnoLancamentoCL);
            this.Controls.Add(this.Cbx_MidiaCL);
            this.Controls.Add(this.Lbl_MidiaCL);
            this.Controls.Add(this.Cbx_GeneroCL);
            this.Controls.Add(this.Lbl_GeneroCL);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Txb_TituloCL);
            this.Controls.Add(this.Lbl_TituloCL);
            this.Controls.Add(this.Ltv_BdLivros);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ConsultaLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Livros";
            this.Load += new System.EventHandler(this.ConsultaLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ListView Ltv_BdLivros;
        private ColumnHeader Cl_Titulo;
        private ColumnHeader Cl_Genero;
        private ColumnHeader Cl_Midia;
        private ColumnHeader Cl_AnoLancamento;
        private ColumnHeader Cl_StatusLeitura;
        private ColumnHeader Cl_AnoAquisição;
        private ColumnHeader Cl_ValorPago;
        private ColumnHeader Cl_Autor;
        private ColumnHeader Cl_Emprestado;
        private Label Lbl_TituloCL;
        private TextBox Txb_TituloCL;
        private Button Btn_Pesquisar;
        private Label Lbl_GeneroCL;
        private ComboBox Cbx_GeneroCL;
        private Label Lbl_MidiaCL;
        private ComboBox Cbx_MidiaCL;
        private Label Lbl_AnoLancamentoCL;
        internal ComboBox Cbx_AnoLancamentoCL;
        private Label Lbl_StatusLeituraCL;
        internal ComboBox Cbx_StatusLeituraCL;
        private Label Lbl_AnoAquisicaoCL;
        internal ComboBox Cbx_AnoAquisicaoCL;
        private Label Lbl_ValorPagoCL;
        private MaskedTextBox Msk_ValorLivroCL;
        private Label Lbl_AutorCL;
        private TextBox Txt_AutorCL;
        private Label Lbl_EstaEmprestado;
        private CheckBox Chkb_SagaSCL;
        private CheckBox Chkb_SagaNCL;
    }
}