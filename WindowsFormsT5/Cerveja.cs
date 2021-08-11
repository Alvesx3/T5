using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarData.Repository;

namespace WindowsFormsT5
{
    public partial class Cerveja : Form
    {
        public CervejaRepository repo { get; set; }
        public Cerveja()
        {
            repo = new CervejaRepository();
            InitializeComponent();
        }

        private void ButListar_Click(object sender, EventArgs e)
        {
            TabelaCerveja tela = new TabelaCerveja();
            tela.Show();
        }

        private void ButSalvar_Click(object sender, EventArgs e)
        {
            BarData.Models.Cerveja model = new BarData.Models.Cerveja();
            model.Nome = TxBNome.Text;
            model.Marca = TxbMarca.Text;
            model.Estilo = TxbEstilo.Text;
            repo.Create(model);
            TxBNome.Text = string.Empty;
            TxbMarca.Text = string.Empty;
            TxbEstilo.Text = string.Empty;
        }
    }
}
