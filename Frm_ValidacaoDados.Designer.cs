namespace RepositorioLivros
{
    partial class Frm_ValidacaoDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidacaoDados));
            this.Lbl_Vtitulo = new System.Windows.Forms.Label();
            this.Btn_SalvarDados = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Vtitulo
            // 
            this.Lbl_Vtitulo.AutoSize = true;
            this.Lbl_Vtitulo.Location = new System.Drawing.Point(185, 70);
            this.Lbl_Vtitulo.Name = "Lbl_Vtitulo";
            this.Lbl_Vtitulo.Size = new System.Drawing.Size(59, 25);
            this.Lbl_Vtitulo.TabIndex = 0;
            this.Lbl_Vtitulo.Text = "label1";
            this.Lbl_Vtitulo.Click += new System.EventHandler(this.Lbl_Vtitulo_Click);
            // 
            // Btn_SalvarDados
            // 
            this.Btn_SalvarDados.Location = new System.Drawing.Point(277, 355);
            this.Btn_SalvarDados.Name = "Btn_SalvarDados";
            this.Btn_SalvarDados.Size = new System.Drawing.Size(112, 34);
            this.Btn_SalvarDados.TabIndex = 1;
            this.Btn_SalvarDados.Text = "Salvar";
            this.Btn_SalvarDados.UseVisualStyleBackColor = true;
            this.Btn_SalvarDados.Click += new System.EventHandler(this.Btn_SalvarDados_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(676, 355);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(112, 34);
            this.Btn_Voltar.TabIndex = 2;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Frm_ValidacaoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_SalvarDados);
            this.Controls.Add(this.Lbl_Vtitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ValidacaoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ValidacaoDados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_Vtitulo;
        private Button Btn_SalvarDados;
        private Button Btn_Voltar;
    }
}