
namespace WindowsFormsT5
{
    partial class Refrigerante
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
            this.labNome = new System.Windows.Forms.Label();
            this.TxBNome = new System.Windows.Forms.TextBox();
            this.TxbMarca = new System.Windows.Forms.TextBox();
            this.labMarca = new System.Windows.Forms.Label();
            this.TxbSabor = new System.Windows.Forms.TextBox();
            this.labSabor = new System.Windows.Forms.Label();
            this.ButSalvar = new System.Windows.Forms.Button();
            this.ButListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabCadastro
            // 
            this.LabCadastro.AutoSize = true;
            this.LabCadastro.Location = new System.Drawing.Point(139, 18);
            this.LabCadastro.Name = "LabCadastro";
            this.LabCadastro.Size = new System.Drawing.Size(49, 13);
            this.LabCadastro.TabIndex = 0;
            this.LabCadastro.Text = "Cadastro";
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Location = new System.Drawing.Point(19, 79);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(41, 13);
            this.labNome.TabIndex = 1;
            this.labNome.Text = "Nome :";
            // 
            // TxBNome
            // 
            this.TxBNome.Location = new System.Drawing.Point(66, 79);
            this.TxBNome.Name = "TxBNome";
            this.TxBNome.Size = new System.Drawing.Size(199, 20);
            this.TxBNome.TabIndex = 2;
            // 
            // TxbMarca
            // 
            this.TxbMarca.Location = new System.Drawing.Point(66, 102);
            this.TxbMarca.Name = "TxbMarca";
            this.TxbMarca.Size = new System.Drawing.Size(199, 20);
            this.TxbMarca.TabIndex = 4;
            // 
            // labMarca
            // 
            this.labMarca.AutoSize = true;
            this.labMarca.Location = new System.Drawing.Point(19, 105);
            this.labMarca.Name = "labMarca";
            this.labMarca.Size = new System.Drawing.Size(43, 13);
            this.labMarca.TabIndex = 3;
            this.labMarca.Text = "Marca :";
            // 
            // TxbSabor
            // 
            this.TxbSabor.Location = new System.Drawing.Point(66, 128);
            this.TxbSabor.Name = "TxbSabor";
            this.TxbSabor.Size = new System.Drawing.Size(199, 20);
            this.TxbSabor.TabIndex = 6;
            // 
            // labSabor
            // 
            this.labSabor.AutoSize = true;
            this.labSabor.Location = new System.Drawing.Point(19, 128);
            this.labSabor.Name = "labSabor";
            this.labSabor.Size = new System.Drawing.Size(41, 13);
            this.labSabor.TabIndex = 5;
            this.labSabor.Text = "Sabor :";
            // 
            // ButSalvar
            // 
            this.ButSalvar.Location = new System.Drawing.Point(66, 154);
            this.ButSalvar.Name = "ButSalvar";
            this.ButSalvar.Size = new System.Drawing.Size(75, 23);
            this.ButSalvar.TabIndex = 7;
            this.ButSalvar.Text = "Salvar";
            this.ButSalvar.UseVisualStyleBackColor = true;
            this.ButSalvar.Click += new System.EventHandler(this.ButSalvar_Click);
            // 
            // ButListar
            // 
            this.ButListar.Location = new System.Drawing.Point(190, 154);
            this.ButListar.Name = "ButListar";
            this.ButListar.Size = new System.Drawing.Size(75, 23);
            this.ButListar.TabIndex = 8;
            this.ButListar.Text = "Listar";
            this.ButListar.UseVisualStyleBackColor = true;
            this.ButListar.Click += new System.EventHandler(this.ButListar_Click);
            // 
            // CadastroRefrigerante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 206);
            this.Controls.Add(this.ButListar);
            this.Controls.Add(this.ButSalvar);
            this.Controls.Add(this.TxbSabor);
            this.Controls.Add(this.labSabor);
            this.Controls.Add(this.TxbMarca);
            this.Controls.Add(this.labMarca);
            this.Controls.Add(this.TxBNome);
            this.Controls.Add(this.labNome);
            this.Controls.Add(this.LabCadastro);
            this.Name = "CadastroRefrigerante";
            this.Text = "Refrigerante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabCadastro;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.TextBox TxBNome;
        private System.Windows.Forms.TextBox TxbMarca;
        private System.Windows.Forms.Label labMarca;
        private System.Windows.Forms.TextBox TxbSabor;
        private System.Windows.Forms.Label labSabor;
        private System.Windows.Forms.Button ButSalvar;
        private System.Windows.Forms.Button ButListar;
    }
}

