using BarData.Repository;
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
    public partial class Refrigerante : Form
    {
        public RefrigeranteRepository repo { get; set; }
        public Refrigerante()
        {
            repo = new RefrigeranteRepository();
            InitializeComponent();
        }
        private void ButSalvar_Click(object sender, EventArgs e)
        {
            BarData.Models.Refrigerante model = new BarData.Models.Refrigerante();
            model.Nome = TxBNome.Text;
            model.Marca = TxbMarca.Text;
            model.Sabor = TxbSabor.Text;
            repo.Create(model);
            TxBNome.Text = string.Empty;
            TxbMarca.Text = string.Empty;
            TxbSabor.Text = string.Empty;

        }

        private void ButListar_Click(object sender, EventArgs e)
        {
            TabelaRefrigerante tela = new TabelaRefrigerante();
            tela.Show();
        }
    }
}
