using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsT5
{
    public partial class TabelaCerveja : Form
    {
        public TabelaCerveja()
        {
            InitializeComponent();
        }

        private void TabelaCerveja_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'barDbDataSet1.Cervejas'. Você pode movê-la ou removê-la conforme necessário.
            this.cervejasTableAdapter.Fill(this.barDbDataSet1.Cervejas);
            // TODO: esta linha de código carrega dados na tabela 'barDbDataSet.Cervejas'. Você pode movê-la ou removê-la conforme necessário.
            this.cervejasTableAdapter.Fill(this.barDbDataSet.Cervejas);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cervejasTableAdapter.FillBy(this.barDbDataSet.Cervejas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cervejasToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cervejasTableAdapter.Cervejas(this.barDbDataSet.Cervejas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
