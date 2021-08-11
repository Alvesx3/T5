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
    public partial class TabelaRefrigerante : Form
    {
        public TabelaRefrigerante()
        {
            InitializeComponent();
        }

        private void TabelaRefrigerante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'barDbDataSet1.Refrigerantes'. Você pode movê-la ou removê-la conforme necessário.
            this.refrigerantesTableAdapter.Fill(this.barDbDataSet1.Refrigerantes);

        }
    }
}
