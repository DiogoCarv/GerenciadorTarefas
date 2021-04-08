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
    public partial class CadResponsavel : Form
    {
        public CadResponsavel()
        {
            InitializeComponent();
        }

        private void CadResponsavel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemagtBDDataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.sistemagtBDDataSet.Responsavel);
            this.responsavelBindingSource.AddNew();

        }

        private void BTFechar_Click(object sender, EventArgs e)
        {
            this.responsavelBindingSource.CancelEdit();
            this.Close();
        }

        private void BTLimpar_Click(object sender, EventArgs e)
        {
            nomeTextBox.Text = String.Empty;
        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.responsavelBindingSource.EndEdit();
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
