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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Refrigerante tela = new Refrigerante();
            tela.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cerveja tela = new Cerveja();
            tela.Show();
            //teste
        }
    }
}
