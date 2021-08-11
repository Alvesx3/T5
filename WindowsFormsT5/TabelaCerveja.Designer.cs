
namespace WindowsFormsT5
{
    partial class TabelaCerveja
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cervejasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barDbDataSet1 = new WindowsFormsT5.BarDbDataSet();
            this.cervejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barDbDataSet = new WindowsFormsT5.BarDbDataSet();
            this.cervejasTableAdapter = new WindowsFormsT5.BarDbDataSetTableAdapters.CervejasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cervejasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cervejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.estiloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cervejasBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // cervejasBindingSource1
            // 
            this.cervejasBindingSource1.DataMember = "Cervejas";
            this.cervejasBindingSource1.DataSource = this.barDbDataSet1;
            // 
            // barDbDataSet1
            // 
            this.barDbDataSet1.DataSetName = "BarDbDataSet";
            this.barDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cervejasBindingSource
            // 
            this.cervejasBindingSource.DataMember = "Cervejas";
            this.cervejasBindingSource.DataSource = this.barDbDataSet;
            // 
            // barDbDataSet
            // 
            this.barDbDataSet.DataSetName = "BarDbDataSet";
            this.barDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cervejasTableAdapter
            // 
            this.cervejasTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // estiloDataGridViewTextBoxColumn
            // 
            this.estiloDataGridViewTextBoxColumn.DataPropertyName = "Estilo";
            this.estiloDataGridViewTextBoxColumn.HeaderText = "Estilo";
            this.estiloDataGridViewTextBoxColumn.Name = "estiloDataGridViewTextBoxColumn";
            // 
            // TabelaCerveja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 379);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TabelaCerveja";
            this.Text = "TabelaCerveja";
            this.Load += new System.EventHandler(this.TabelaCerveja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cervejasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cervejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BarDbDataSet barDbDataSet;
        private System.Windows.Forms.BindingSource cervejasBindingSource;
        private BarDbDataSetTableAdapters.CervejasTableAdapter cervejasTableAdapter;
        private BarDbDataSet barDbDataSet1;
        private System.Windows.Forms.BindingSource cervejasBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estiloDataGridViewTextBoxColumn;
    }
}