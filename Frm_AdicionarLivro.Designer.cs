namespace RepositorioLivros
{
    partial class Frm_AdicionarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AdicionarLivro));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Genero = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarNovoLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Midia = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Cbx_Genero = new System.Windows.Forms.ComboBox();
            this.Cbx_Midia = new System.Windows.Forms.ComboBox();
            this.Lbl_AnoLancamento = new System.Windows.Forms.Label();
            this.Cbx_AnoLancamento = new System.Windows.Forms.ComboBox();
            this.Lbl_StatusLeitura = new System.Windows.Forms.Label();
            this.Cbx_StatusLeitura = new System.Windows.Forms.ComboBox();
            this.Lbl_AnoAquisicao = new System.Windows.Forms.Label();
            this.Cbx_AnoAquisicao = new System.Windows.Forms.ComboBox();
            this.Lbl_ValorPago = new System.Windows.Forms.Label();
            this.Msk_ValorLivro = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Autor = new System.Windows.Forms.Label();
            this.Txt_Autor = new System.Windows.Forms.TextBox();
            this.Lbl_FazParteSaga = new System.Windows.Forms.Label();
            this.Chkb_SagaS = new System.Windows.Forms.CheckBox();
            this.Chkb_SagaN = new System.Windows.Forms.CheckBox();
            this.Btn_SalvarLivro = new System.Windows.Forms.Button();
            this.Txt_Titulo2 = new System.Windows.Forms.TextBox();
            this.Btn_Voltaradc = new System.Windows.Forms.Button();
            this.Lbl_cifrao = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Titulo.Location = new System.Drawing.Point(12, 79);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(62, 28);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Título";
            // 
            // Lbl_Genero
            // 
            this.Lbl_Genero.AutoSize = true;
            this.Lbl_Genero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Genero.Location = new System.Drawing.Point(12, 126);
            this.Lbl_Genero.Name = "Lbl_Genero";
            this.Lbl_Genero.Size = new System.Drawing.Size(76, 28);
            this.Lbl_Genero.TabIndex = 2;
            this.Lbl_Genero.Text = "Gênero";
            this.Lbl_Genero.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaToolStripButton,
            this.salvarToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 33);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            this.novaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novaToolStripButton.Image")));
            this.novaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novaToolStripButton.Name = "novaToolStripButton";
            this.novaToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.novaToolStripButton.Text = "&Nova";
            this.novaToolStripButton.Click += new System.EventHandler(this.novaToolStripButton_Click);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarNovoLivroToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // adicionarNovoLivroToolStripMenuItem
            // 
            this.adicionarNovoLivroToolStripMenuItem.Name = "adicionarNovoLivroToolStripMenuItem";
            this.adicionarNovoLivroToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.adicionarNovoLivroToolStripMenuItem.Text = "Adicionar Novo Livro";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Lbl_Midia
            // 
            this.Lbl_Midia.AutoSize = true;
            this.Lbl_Midia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Midia.Location = new System.Drawing.Point(12, 175);
            this.Lbl_Midia.Name = "Lbl_Midia";
            this.Lbl_Midia.Size = new System.Drawing.Size(62, 28);
            this.Lbl_Midia.TabIndex = 22;
            this.Lbl_Midia.Text = "Mídia";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Cbx_Genero
            // 
            this.Cbx_Genero.FormattingEnabled = true;
            this.Cbx_Genero.Items.AddRange(new object[] {
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
            this.Cbx_Genero.Location = new System.Drawing.Point(228, 126);
            this.Cbx_Genero.Name = "Cbx_Genero";
            this.Cbx_Genero.Size = new System.Drawing.Size(182, 33);
            this.Cbx_Genero.TabIndex = 24;
            // 
            // Cbx_Midia
            // 
            this.Cbx_Midia.FormattingEnabled = true;
            this.Cbx_Midia.Items.AddRange(new object[] {
            "Física",
            "Digital"});
            this.Cbx_Midia.Location = new System.Drawing.Point(228, 175);
            this.Cbx_Midia.Name = "Cbx_Midia";
            this.Cbx_Midia.Size = new System.Drawing.Size(182, 33);
            this.Cbx_Midia.TabIndex = 25;
            this.Cbx_Midia.SelectedIndexChanged += new System.EventHandler(this.Cbx_Midia_SelectedIndexChanged);
            // 
            // Lbl_AnoLancamento
            // 
            this.Lbl_AnoLancamento.AutoSize = true;
            this.Lbl_AnoLancamento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AnoLancamento.Location = new System.Drawing.Point(13, 222);
            this.Lbl_AnoLancamento.Name = "Lbl_AnoLancamento";
            this.Lbl_AnoLancamento.Size = new System.Drawing.Size(186, 28);
            this.Lbl_AnoLancamento.TabIndex = 26;
            this.Lbl_AnoLancamento.Text = "Ano de Lançamento";
            // 
            // Cbx_AnoLancamento
            // 
            this.Cbx_AnoLancamento.FormattingEnabled = true;
            this.Cbx_AnoLancamento.Items.AddRange(new object[] {
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
            this.Cbx_AnoLancamento.Location = new System.Drawing.Point(228, 217);
            this.Cbx_AnoLancamento.Name = "Cbx_AnoLancamento";
            this.Cbx_AnoLancamento.Size = new System.Drawing.Size(182, 33);
            this.Cbx_AnoLancamento.TabIndex = 27;
            // 
            // Lbl_StatusLeitura
            // 
            this.Lbl_StatusLeitura.AutoSize = true;
            this.Lbl_StatusLeitura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_StatusLeitura.Location = new System.Drawing.Point(13, 268);
            this.Lbl_StatusLeitura.Name = "Lbl_StatusLeitura";
            this.Lbl_StatusLeitura.Size = new System.Drawing.Size(156, 28);
            this.Lbl_StatusLeitura.TabIndex = 28;
            this.Lbl_StatusLeitura.Text = "Status da Leitura";
            // 
            // Cbx_StatusLeitura
            // 
            this.Cbx_StatusLeitura.FormattingEnabled = true;
            this.Cbx_StatusLeitura.Items.AddRange(new object[] {
            "Não Iniciada",
            "Em Andamento",
            "Concluído"});
            this.Cbx_StatusLeitura.Location = new System.Drawing.Point(228, 263);
            this.Cbx_StatusLeitura.Name = "Cbx_StatusLeitura";
            this.Cbx_StatusLeitura.Size = new System.Drawing.Size(182, 33);
            this.Cbx_StatusLeitura.TabIndex = 29;
            // 
            // Lbl_AnoAquisicao
            // 
            this.Lbl_AnoAquisicao.AutoSize = true;
            this.Lbl_AnoAquisicao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AnoAquisicao.Location = new System.Drawing.Point(13, 317);
            this.Lbl_AnoAquisicao.Name = "Lbl_AnoAquisicao";
            this.Lbl_AnoAquisicao.Size = new System.Drawing.Size(165, 28);
            this.Lbl_AnoAquisicao.TabIndex = 30;
            this.Lbl_AnoAquisicao.Text = "Ano de Aquisição";
            // 
            // Cbx_AnoAquisicao
            // 
            this.Cbx_AnoAquisicao.FormattingEnabled = true;
            this.Cbx_AnoAquisicao.Items.AddRange(new object[] {
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
            this.Cbx_AnoAquisicao.Location = new System.Drawing.Point(228, 312);
            this.Cbx_AnoAquisicao.Name = "Cbx_AnoAquisicao";
            this.Cbx_AnoAquisicao.Size = new System.Drawing.Size(182, 33);
            this.Cbx_AnoAquisicao.TabIndex = 31;
            // 
            // Lbl_ValorPago
            // 
            this.Lbl_ValorPago.AutoSize = true;
            this.Lbl_ValorPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ValorPago.Location = new System.Drawing.Point(13, 363);
            this.Lbl_ValorPago.Name = "Lbl_ValorPago";
            this.Lbl_ValorPago.Size = new System.Drawing.Size(106, 28);
            this.Lbl_ValorPago.TabIndex = 32;
            this.Lbl_ValorPago.Text = "Valor Pago";
            // 
            // Msk_ValorLivro
            // 
            this.Msk_ValorLivro.Location = new System.Drawing.Point(228, 360);
            this.Msk_ValorLivro.Mask = "000,00";
            this.Msk_ValorLivro.Name = "Msk_ValorLivro";
            this.Msk_ValorLivro.Size = new System.Drawing.Size(73, 31);
            this.Msk_ValorLivro.TabIndex = 33;
            // 
            // Lbl_Autor
            // 
            this.Lbl_Autor.AutoSize = true;
            this.Lbl_Autor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Autor.Location = new System.Drawing.Point(13, 407);
            this.Lbl_Autor.Name = "Lbl_Autor";
            this.Lbl_Autor.Size = new System.Drawing.Size(62, 28);
            this.Lbl_Autor.TabIndex = 34;
            this.Lbl_Autor.Text = "Autor";
            // 
            // Txt_Autor
            // 
            this.Txt_Autor.Location = new System.Drawing.Point(227, 404);
            this.Txt_Autor.Name = "Txt_Autor";
            this.Txt_Autor.Size = new System.Drawing.Size(544, 31);
            this.Txt_Autor.TabIndex = 35;
            // 
            // Lbl_FazParteSaga
            // 
            this.Lbl_FazParteSaga.AutoSize = true;
            this.Lbl_FazParteSaga.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_FazParteSaga.Location = new System.Drawing.Point(12, 454);
            this.Lbl_FazParteSaga.Name = "Lbl_FazParteSaga";
            this.Lbl_FazParteSaga.Size = new System.Drawing.Size(215, 28);
            this.Lbl_FazParteSaga.TabIndex = 36;
            this.Lbl_FazParteSaga.Text = "Faz parte de uma saga?";
            // 
            // Chkb_SagaS
            // 
            this.Chkb_SagaS.AutoSize = true;
            this.Chkb_SagaS.Location = new System.Drawing.Point(233, 456);
            this.Chkb_SagaS.Name = "Chkb_SagaS";
            this.Chkb_SagaS.Size = new System.Drawing.Size(68, 29);
            this.Chkb_SagaS.TabIndex = 37;
            this.Chkb_SagaS.Text = "Sim";
            this.Chkb_SagaS.UseVisualStyleBackColor = true;
            // 
            // Chkb_SagaN
            // 
            this.Chkb_SagaN.AutoSize = true;
            this.Chkb_SagaN.Location = new System.Drawing.Point(307, 456);
            this.Chkb_SagaN.Name = "Chkb_SagaN";
            this.Chkb_SagaN.Size = new System.Drawing.Size(71, 29);
            this.Chkb_SagaN.TabIndex = 38;
            this.Chkb_SagaN.Text = "Não";
            this.Chkb_SagaN.UseVisualStyleBackColor = true;
            // 
            // Btn_SalvarLivro
            // 
            this.Btn_SalvarLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SalvarLivro.Location = new System.Drawing.Point(13, 561);
            this.Btn_SalvarLivro.Name = "Btn_SalvarLivro";
            this.Btn_SalvarLivro.Size = new System.Drawing.Size(179, 65);
            this.Btn_SalvarLivro.TabIndex = 39;
            this.Btn_SalvarLivro.Text = "Salvar";
            this.Btn_SalvarLivro.UseVisualStyleBackColor = true;
            this.Btn_SalvarLivro.Click += new System.EventHandler(this.Btn_SalvarLivro_Click);
            // 
            // Txt_Titulo2
            // 
            this.Txt_Titulo2.Location = new System.Drawing.Point(228, 76);
            this.Txt_Titulo2.Name = "Txt_Titulo2";
            this.Txt_Titulo2.Size = new System.Drawing.Size(544, 31);
            this.Txt_Titulo2.TabIndex = 40;
            this.Txt_Titulo2.TextChanged += new System.EventHandler(this.Txt_Titulo2_TextChanged);
            // 
            // Btn_Voltaradc
            // 
            this.Btn_Voltaradc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Voltaradc.Location = new System.Drawing.Point(593, 561);
            this.Btn_Voltaradc.Name = "Btn_Voltaradc";
            this.Btn_Voltaradc.Size = new System.Drawing.Size(179, 65);
            this.Btn_Voltaradc.TabIndex = 41;
            this.Btn_Voltaradc.Text = "Voltar";
            this.Btn_Voltaradc.UseVisualStyleBackColor = true;
            this.Btn_Voltaradc.Click += new System.EventHandler(this.Btn_Voltaradc_Click);
            // 
            // Lbl_cifrao
            // 
            this.Lbl_cifrao.AutoSize = true;
            this.Lbl_cifrao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_cifrao.Location = new System.Drawing.Point(192, 360);
            this.Lbl_cifrao.Name = "Lbl_cifrao";
            this.Lbl_cifrao.Size = new System.Drawing.Size(35, 28);
            this.Lbl_cifrao.TabIndex = 42;
            this.Lbl_cifrao.Text = "R$";
            // 
            // Frm_AdicionarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(850, 715);
            this.Controls.Add(this.Lbl_cifrao);
            this.Controls.Add(this.Btn_Voltaradc);
            this.Controls.Add(this.Txt_Titulo2);
            this.Controls.Add(this.Btn_SalvarLivro);
            this.Controls.Add(this.Chkb_SagaN);
            this.Controls.Add(this.Chkb_SagaS);
            this.Controls.Add(this.Lbl_FazParteSaga);
            this.Controls.Add(this.Txt_Autor);
            this.Controls.Add(this.Lbl_Autor);
            this.Controls.Add(this.Msk_ValorLivro);
            this.Controls.Add(this.Lbl_ValorPago);
            this.Controls.Add(this.Cbx_AnoAquisicao);
            this.Controls.Add(this.Lbl_AnoAquisicao);
            this.Controls.Add(this.Cbx_StatusLeitura);
            this.Controls.Add(this.Lbl_StatusLeitura);
            this.Controls.Add(this.Cbx_AnoLancamento);
            this.Controls.Add(this.Lbl_AnoLancamento);
            this.Controls.Add(this.Cbx_Midia);
            this.Controls.Add(this.Cbx_Genero);
            this.Controls.Add(this.Lbl_Midia);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Lbl_Genero);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_AdicionarLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Livros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_AdicionarLivro_FormClosing);
            this.Load += new System.EventHandler(this.Frm_AdicionarLivro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_Titulo;
        public TextBox Txt_Titulo { get; set; }
        private Label Lbl_Genero;
        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem adicionarNovoLivroToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label Lbl_Midia;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox Cbx_Genero;
        private ComboBox Cbx_Midia;
        private Label Lbl_AnoLancamento;
        internal ComboBox Cbx_AnoLancamento;
        private Label Lbl_StatusLeitura;
        internal ComboBox Cbx_StatusLeitura;
        private Label Lbl_AnoAquisicao;
        internal ComboBox Cbx_AnoAquisicao;
        private Label Lbl_ValorPago;
        private MaskedTextBox Msk_ValorLivro;
        private Label Lbl_Autor;
        private TextBox Txt_Autor;
        private Label Lbl_FazParteSaga;
        private CheckBox Chkb_SagaS;
        private CheckBox Chkb_SagaN;
        private Button Btn_SalvarLivro;
        private TextBox Txt_Titulo2;
        private Button Btn_Voltaradc;
        private Label Lbl_cifrao;
    }
}