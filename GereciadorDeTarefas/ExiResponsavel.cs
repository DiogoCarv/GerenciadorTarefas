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
    public partial class ExiResponsavel : Form
    {
        public ExiResponsavel()
        {
            InitializeComponent();
        }

        private void responsavelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemagtBDDataSet);

        }

        private void ExiResponsavel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemagtBDDataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.sistemagtBDDataSet.Responsavel);
            this.responsavelBindingSource.AddNew();
        }

        private void BTAtualizar_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.sistemagtBDDataSet);
        }
    }
}
