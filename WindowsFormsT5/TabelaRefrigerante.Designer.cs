
namespace WindowsFormsT5
{
    partial class TabelaRefrigerante
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
            this.barDbDataSet = new WindowsFormsT5.BarDbDataSet();
            this.barDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barDbDataSet1 = new WindowsFormsT5.BarDbDataSet1();
            this.refrigerantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refrigerantesTableAdapter = new WindowsFormsT5.BarDbDataSet1TableAdapters.RefrigerantesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigerantesBindingSource)).BeginInit();
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
            this.saborDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.refrigerantesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // barDbDataSet
            // 
            this.barDbDataSet.DataSetName = "BarDbDataSet";
            this.barDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barDbDataSetBindingSource
            // 
            this.barDbDataSetBindingSource.DataSource = this.barDbDataSet;
            this.barDbDataSetBindingSource.Position = 0;
            // 
            // barDbDataSet1
            // 
            this.barDbDataSet1.DataSetName = "BarDbDataSet1";
            this.barDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refrigerantesBindingSource
            // 
            this.refrigerantesBindingSource.DataMember = "Refrigerantes";
            this.refrigerantesBindingSource.DataSource = this.barDbDataSet1;
            // 
            // refrigerantesTableAdapter
            // 
            this.refrigerantesTableAdapter.ClearBeforeFill = true;
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
            // saborDataGridViewTextBoxColumn
            // 
            this.saborDataGridViewTextBoxColumn.DataPropertyName = "Sabor";
            this.saborDataGridViewTextBoxColumn.HeaderText = "Sabor";
            this.saborDataGridViewTextBoxColumn.Name = "saborDataGridViewTextBoxColumn";
            // 
            // TabelaRefrigerante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 312);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TabelaRefrigerante";
            this.Text = "TabelaRefrigerante";
            this.Load += new System.EventHandler(this.TabelaRefrigerante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigerantesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource barDbDataSetBindingSource;
        private BarDbDataSet barDbDataSet;
        private BarDbDataSet1 barDbDataSet1;
        private System.Windows.Forms.BindingSource refrigerantesBindingSource;
        private BarDbDataSet1TableAdapters.RefrigerantesTableAdapter refrigerantesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saborDataGridViewTextBoxColumn;
    }
}