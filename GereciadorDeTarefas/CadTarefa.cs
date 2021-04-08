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
    public partial class CadTarefa : Form
    {
        public CadTarefa()
        {
            InitializeComponent();
        }

        private void CadTarefa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemagtBDDataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.sistemagtBDDataSet.Responsavel);
            // TODO: esta linha de código carrega dados na tabela 'sistemagtBDDataSet.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.sistemagtBDDataSet.Status);
            // TODO: esta linha de código carrega dados na tabela 'sistemagtBDDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.sistemagtBDDataSet.Tarefa);
            this.tarefaBindingSource.AddNew();
        }

        private void BTFechar_Click(object sender, EventArgs e)
        {
            this.tarefaBindingSource.CancelEdit();
            this.Close();
        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.tarefaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sistemagtBDDataSet);
                this.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
