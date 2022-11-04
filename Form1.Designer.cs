namespace RepositorioLivros
{
    partial class MyBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBook));
            this.Btn_CadastroLivro = new System.Windows.Forms.Button();
            this.Btn_ConsultaLivros = new System.Windows.Forms.Button();
            this.Lbl_MeusLivros = new System.Windows.Forms.Label();
            this.Btn_EmprestarLivro = new System.Windows.Forms.Button();
            this.Btn_DevolucaoLivro = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_ListaDesejos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_CadastroLivro
            // 
            resources.ApplyResources(this.Btn_CadastroLivro, "Btn_CadastroLivro");
            this.Btn_CadastroLivro.Name = "Btn_CadastroLivro";
            this.Btn_CadastroLivro.UseVisualStyleBackColor = true;
            this.Btn_CadastroLivro.Click += new System.EventHandler(this.Btn_CadastroLivro_Click);
            // 
            // Btn_ConsultaLivros
            // 
            resources.ApplyResources(this.Btn_ConsultaLivros, "Btn_ConsultaLivros");
            this.Btn_ConsultaLivros.Name = "Btn_ConsultaLivros";
            this.Btn_ConsultaLivros.UseVisualStyleBackColor = true;
            this.Btn_ConsultaLivros.Click += new System.EventHandler(this.Btn_ConsultaLivros_Click);
            // 
            // Lbl_MeusLivros
            // 
            resources.ApplyResources(this.Lbl_MeusLivros, "Lbl_MeusLivros");
            this.Lbl_MeusLivros.Name = "Lbl_MeusLivros";
            // 
            // Btn_EmprestarLivro
            // 
            resources.ApplyResources(this.Btn_EmprestarLivro, "Btn_EmprestarLivro");
            this.Btn_EmprestarLivro.Name = "Btn_EmprestarLivro";
            this.Btn_EmprestarLivro.UseVisualStyleBackColor = true;
            // 
            // Btn_DevolucaoLivro
            // 
            resources.ApplyResources(this.Btn_DevolucaoLivro, "Btn_DevolucaoLivro");
            this.Btn_DevolucaoLivro.Name = "Btn_DevolucaoLivro";
            this.Btn_DevolucaoLivro.UseVisualStyleBackColor = true;
            // 
            // Btn_Sair
            // 
            resources.ApplyResources(this.Btn_Sair, "Btn_Sair");
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_ListaDesejos
            // 
            resources.ApplyResources(this.Btn_ListaDesejos, "Btn_ListaDesejos");
            this.Btn_ListaDesejos.Name = "Btn_ListaDesejos";
            this.Btn_ListaDesejos.UseVisualStyleBackColor = true;
            // 
            // MyBook
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.Btn_ListaDesejos);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_DevolucaoLivro);
            this.Controls.Add(this.Btn_EmprestarLivro);
            this.Controls.Add(this.Lbl_MeusLivros);
            this.Controls.Add(this.Btn_ConsultaLivros);
            this.Controls.Add(this.Btn_CadastroLivro);
            this.Name = "MyBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_CadastroLivro;
        private Button Btn_ConsultaLivros;
        private Label Lbl_MeusLivros;
        private Button Btn_EmprestarLivro;
        private Button Btn_DevolucaoLivro;
        private Button Btn_Sair;
        private Button Btn_ListaDesejos;
    }
}