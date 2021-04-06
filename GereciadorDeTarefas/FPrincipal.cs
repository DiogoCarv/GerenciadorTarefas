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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadStatus CadastroStatus = new CadStatus();
            CadastroStatus.ShowDialog();
            this.tarefaTableAdapter.Fill(this.sistemagtBDDataSet.Tarefa);
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemagtBDDataSet);

        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemagtBDDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.sistemagtBDDataSet.Tarefa);

        }

        private void BTFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exibirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExiStatus ExibirStatus = new ExiStatus();
            ExibirStatus.ShowDialog();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadResponsavel CadastroResponsavel = new CadResponsavel();
            CadastroResponsavel.ShowDialog();
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExiResponsavel ExibirResponsavel = new ExiResponsavel();
            ExibirResponsavel.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadTarefa CadastroTarefa = new CadTarefa();
            CadastroTarefa.ShowDialog();
        }
    }
}
