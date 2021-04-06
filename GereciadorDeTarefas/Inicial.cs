using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereciadorDeTarefas
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTEntrar_Click(object sender, EventArgs e)
        {
            FPrincipal tela = new FPrincipal();
            this.Visible = false;
            tela.Show();
        }

        private void BTFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
