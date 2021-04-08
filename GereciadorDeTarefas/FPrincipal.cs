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

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.sistemagtBDDataSet);
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            this.selectQueryDadosTableAdapter.Fill(this.sistemagtBDDataSet.SelectQueryDados);
            // TODO: esta linha de código carrega dados na tabela 'sistemagtBDDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.selectQueryDadosBindingSource.AddNew();
        }

        private void BTFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTAtualizar_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.sistemagtBDDataSet);
        }

        private void MICadastrarTarefa_Click(object sender, EventArgs e)
        {
            CadTarefa CadastrarTarefa = new CadTarefa();
            CadastrarTarefa.ShowDialog();
        }

        private void MICadastrarStatus_Click(object sender, EventArgs e)
        {
            CadStatus CadastroStatus = new CadStatus();
            CadastroStatus.ShowDialog();
        }

        private void MIExibirStatus_Click(object sender, EventArgs e)
        {
            ExiStatus ExibirStatus = new ExiStatus();
            ExibirStatus.ShowDialog();
        }

        private void MICadastrarResp_Click(object sender, EventArgs e)
        {
            CadResponsavel CadastroResponsavel = new CadResponsavel();
            CadastroResponsavel.ShowDialog();
        }

        private void MIExibirResp_Click(object sender, EventArgs e)
        {
            ExiResponsavel ExibirResponsavel = new ExiResponsavel();
            ExibirResponsavel.ShowDialog();
        }
    }
}
