
namespace WindowsFormsT5
{
    partial class Cerveja
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
            this.ButListar = new System.Windows.Forms.Button();
            this.ButSalvar = new System.Windows.Forms.Button();
            this.TxbEstilo = new System.Windows.Forms.TextBox();
            this.labEstiloC = new System.Windows.Forms.Label();
            this.TxbMarca = new System.Windows.Forms.TextBox();
            this.labMarca = new System.Windows.Forms.Label();
            this.TxBNome = new System.Windows.Forms.TextBox();
            this.labNome = new System.Windows.Forms.Label();
            this.LabCadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButListar
            // 
            this.ButListar.Location = new System.Drawing.Point(190, 154);
            this.ButListar.Name = "ButListar";
            this.ButListar.Size = new System.Drawing.Size(75, 23);
            this.ButListar.TabIndex = 17;
            this.ButListar.Text = "Listar";
            this.ButListar.UseVisualStyleBackColor = true;
            this.ButListar.Click += new System.EventHandler(this.ButListar_Click);
            // 
            // ButSalvar
            // 
            this.ButSalvar.Location = new System.Drawing.Point(66, 154);
            this.ButSalvar.Name = "ButSalvar";
            this.ButSalvar.Size = new System.Drawing.Size(75, 23);
            this.ButSalvar.TabIndex = 16;
            this.ButSalvar.Text = "Salvar";
            this.ButSalvar.UseVisualStyleBackColor = true;
            this.ButSalvar.Click += new System.EventHandler(this.ButSalvar_Click);
            // 
            // TxbEstilo
            // 
            this.TxbEstilo.Location = new System.Drawing.Point(66, 128);
            this.TxbEstilo.Name = "TxbEstilo";
            this.TxbEstilo.Size = new System.Drawing.Size(199, 20);
            this.TxbEstilo.TabIndex = 15;
            // 
            // labEstiloC
            // 
            this.labEstiloC.AutoSize = true;
            this.labEstiloC.Location = new System.Drawing.Point(19, 128);
            this.labEstiloC.Name = "labEstiloC";
            this.labEstiloC.Size = new System.Drawing.Size(38, 13);
            this.labEstiloC.TabIndex = 14;
            this.labEstiloC.Text = "Estilo :";
            // 
            // TxbMarca
            // 
            this.TxbMarca.Location = new System.Drawing.Point(66, 102);
            this.TxbMarca.Name = "TxbMarca";
            this.TxbMarca.Size = new System.Drawing.Size(199, 20);
            this.TxbMarca.TabIndex = 13;
            // 
            // labMarca
            // 
            this.labMarca.AutoSize = true;
            this.labMarca.Location = new System.Drawing.Point(19, 105);
            this.labMarca.Name = "labMarca";
            this.labMarca.Size = new System.Drawing.Size(43, 13);
            this.labMarca.TabIndex = 12;
            this.labMarca.Text = "Marca :";
            // 
            // TxBNome
            // 
            this.TxBNome.Location = new System.Drawing.Point(66, 79);
            this.TxBNome.Name = "TxBNome";
            this.TxBNome.Size = new System.Drawing.Size(199, 20);
            this.TxBNome.TabIndex = 11;
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Location = new System.Drawing.Point(19, 79);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(41, 13);
            this.labNome.TabIndex = 10;
            this.labNome.Text = "Nome :";
            // 
            // LabCadastro
            // 
            this.LabCadastro.AutoSize = true;
            this.LabCadastro.Location = new System.Drawing.Point(139, 18);
            this.LabCadastro.Name = "LabCadastro";
            this.LabCadastro.Size = new System.Drawing.Size(49, 13);
            this.LabCadastro.TabIndex = 9;
            this.LabCadastro.Text = "Cadastro";
            // 
            // Cerveja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 207);
            this.Controls.Add(this.ButListar);
            this.Controls.Add(this.ButSalvar);
            this.Controls.Add(this.TxbEstilo);
            this.Controls.Add(this.labEstiloC);
            this.Controls.Add(this.TxbMarca);
            this.Controls.Add(this.labMarca);
            this.Controls.Add(this.TxBNome);
            this.Controls.Add(this.labNome);
            this.Controls.Add(this.LabCadastro);
            this.Name = "Cerveja";
            this.Text = "Cerveja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButListar;
        private System.Windows.Forms.Button ButSalvar;
        private System.Windows.Forms.TextBox TxbEstilo;
        private System.Windows.Forms.Label labEstiloC;
        private System.Windows.Forms.TextBox TxbMarca;
        private System.Windows.Forms.Label labMarca;
        private System.Windows.Forms.TextBox TxBNome;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label LabCadastro;
    }
}