
namespace WindowsFormsT5
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabCadastro = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabCadastro
            // 
            this.LabCadastro.AutoSize = true;
            this.LabCadastro.Location = new System.Drawing.Point(311, 34);
            this.LabCadastro.Name = "LabCadastro";
            this.LabCadastro.Size = new System.Drawing.Size(49, 13);
            this.LabCadastro.TabIndex = 0;
            this.LabCadastro.Text = "Cadastro";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(83, 82);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(35, 13);
            this.lab.TabIndex = 1;
            this.lab.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.LabCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabCadastro;
        private System.Windows.Forms.Label lab;
    }
}

