namespace RepositorioLivros
{
    partial class MyBook
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
            this.Lbl_AppTitle = new System.Windows.Forms.Label();
            this.Btn_CadastroLivro = new System.Windows.Forms.Button();
            this.Btn_ConsultaLivros = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.Lbl_AppTitle, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.Btn_CadastroLivro, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.Btn_ConsultaLivros, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.Btn_Sair, 0, 4);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 6;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(582, 553);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // Lbl_AppTitle
            // 
            this.Lbl_AppTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_AppTitle.AutoSize = true;
            this.Lbl_AppTitle.Location = new System.Drawing.Point(191, 126);
            this.Lbl_AppTitle.Name = "Lbl_AppTitle";
            this.Lbl_AppTitle.Size = new System.Drawing.Size(200, 50);
            this.Lbl_AppTitle.TabIndex = 0;
            this.Lbl_AppTitle.Text = "MyBooks";
            // 
            // Btn_CadastroLivro
            // 
            this.Btn_CadastroLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_CadastroLivro.Location = new System.Drawing.Point(166, 206);
            this.Btn_CadastroLivro.Margin = new System.Windows.Forms.Padding(10);
            this.Btn_CadastroLivro.Name = "Btn_CadastroLivro";
            this.Btn_CadastroLivro.Size = new System.Drawing.Size(250, 50);
            this.Btn_CadastroLivro.TabIndex = 1;
            this.Btn_CadastroLivro.Text = "Adicionar Novo Livro";
            this.Btn_CadastroLivro.UseVisualStyleBackColor = true;
            this.Btn_CadastroLivro.Click += new System.EventHandler(this.Btn_CadastroLivro_Click);
            // 
            // Btn_ConsultaLivros
            // 
            this.Btn_ConsultaLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_ConsultaLivros.Location = new System.Drawing.Point(166, 276);
            this.Btn_ConsultaLivros.Margin = new System.Windows.Forms.Padding(10);
            this.Btn_ConsultaLivros.Name = "Btn_ConsultaLivros";
            this.Btn_ConsultaLivros.Size = new System.Drawing.Size(250, 50);
            this.Btn_ConsultaLivros.TabIndex = 2;
            this.Btn_ConsultaLivros.Text = "Consultar Meus Livros";
            this.Btn_ConsultaLivros.UseVisualStyleBackColor = true;
            this.Btn_ConsultaLivros.Click += new System.EventHandler(this.Btn_ConsultaLivros_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Sair.Location = new System.Drawing.Point(166, 346);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(10);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(250, 50);
            this.Btn_Sair.TabIndex = 3;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // MyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "MyBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBooks - Seu Repositório de Livros";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label Lbl_AppTitle;
        private System.Windows.Forms.Button Btn_CadastroLivro;
        private System.Windows.Forms.Button Btn_ConsultaLivros;
        private System.Windows.Forms.Button Btn_Sair;
    }
}