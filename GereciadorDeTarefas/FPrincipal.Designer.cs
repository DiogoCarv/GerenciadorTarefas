
namespace GereciadorDeTarefas
{
    partial class FPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MITarefa = new System.Windows.Forms.ToolStripMenuItem();
            this.MICadastrarTarefa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.responsávelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MIStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.MICadastrarStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MIExibirStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.MIResponsavel = new System.Windows.Forms.ToolStripMenuItem();
            this.MICadastrarResp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MIExibirResp = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exibirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTFechar = new System.Windows.Forms.Button();
            this.sistemagtBDDataSet = new GereciadorDeTarefas.SistemagtBDDataSet();
            this.selectQueryDadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectQueryDadosTableAdapter = new GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.SelectQueryDadosTableAdapter();
            this.tableAdapterManager = new GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.TableAdapterManager();
            this.selectQueryDadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTAtualizar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemagtBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryDadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryDadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MITarefa,
            this.responsávelToolStripMenuItem,
            this.MIStatus,
            this.MIResponsavel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MITarefa
            // 
            this.MITarefa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MICadastrarTarefa,
            this.toolStripSeparator1});
            this.MITarefa.Name = "MITarefa";
            this.MITarefa.Size = new System.Drawing.Size(50, 20);
            this.MITarefa.Text = "Tarefa";
            // 
            // MICadastrarTarefa
            // 
            this.MICadastrarTarefa.Name = "MICadastrarTarefa";
            this.MICadastrarTarefa.Size = new System.Drawing.Size(124, 22);
            this.MICadastrarTarefa.Text = "Cadastrar";
            this.MICadastrarTarefa.Click += new System.EventHandler(this.MICadastrarTarefa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // responsávelToolStripMenuItem
            // 
            this.responsávelToolStripMenuItem.Name = "responsávelToolStripMenuItem";
            this.responsávelToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // MIStatus
            // 
            this.MIStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MICadastrarStatus,
            this.toolStripSeparator3,
            this.MIExibirStatus});
            this.MIStatus.Name = "MIStatus";
            this.MIStatus.Size = new System.Drawing.Size(51, 20);
            this.MIStatus.Text = "Status";
            // 
            // MICadastrarStatus
            // 
            this.MICadastrarStatus.Name = "MICadastrarStatus";
            this.MICadastrarStatus.Size = new System.Drawing.Size(180, 22);
            this.MICadastrarStatus.Text = "Cadastrar";
            this.MICadastrarStatus.Click += new System.EventHandler(this.MICadastrarStatus_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // MIExibirStatus
            // 
            this.MIExibirStatus.Name = "MIExibirStatus";
            this.MIExibirStatus.Size = new System.Drawing.Size(180, 22);
            this.MIExibirStatus.Text = "Exibir";
            this.MIExibirStatus.Click += new System.EventHandler(this.MIExibirStatus_Click);
            // 
            // MIResponsavel
            // 
            this.MIResponsavel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MICadastrarResp,
            this.toolStripSeparator4,
            this.MIExibirResp});
            this.MIResponsavel.Name = "MIResponsavel";
            this.MIResponsavel.Size = new System.Drawing.Size(84, 20);
            this.MIResponsavel.Text = "Responsavel";
            // 
            // MICadastrarResp
            // 
            this.MICadastrarResp.Name = "MICadastrarResp";
            this.MICadastrarResp.Size = new System.Drawing.Size(180, 22);
            this.MICadastrarResp.Text = "Cadastrar";
            this.MICadastrarResp.Click += new System.EventHandler(this.MICadastrarResp_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(121, 6);
            // 
            // MIExibirResp
            // 
            this.MIExibirResp.Name = "MIExibirResp";
            this.MIExibirResp.Size = new System.Drawing.Size(180, 22);
            this.MIExibirResp.Text = "Exibir";
            this.MIExibirResp.Click += new System.EventHandler(this.MIExibirResp_Click);
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // exibirToolStripMenuItem1
            // 
            this.exibirToolStripMenuItem1.Name = "exibirToolStripMenuItem1";
            this.exibirToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.exibirToolStripMenuItem1.Text = "Exibir";
            // 
            // BTFechar
            // 
            this.BTFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTFechar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTFechar.Location = new System.Drawing.Point(620, 326);
            this.BTFechar.Name = "BTFechar";
            this.BTFechar.Size = new System.Drawing.Size(102, 44);
            this.BTFechar.TabIndex = 9;
            this.BTFechar.Text = "Fechar";
            this.BTFechar.UseVisualStyleBackColor = false;
            this.BTFechar.Click += new System.EventHandler(this.BTFechar_Click);
            // 
            // sistemagtBDDataSet
            // 
            this.sistemagtBDDataSet.DataSetName = "SistemagtBDDataSet";
            this.sistemagtBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectQueryDadosBindingSource
            // 
            this.selectQueryDadosBindingSource.DataMember = "SelectQueryDados";
            this.selectQueryDadosBindingSource.DataSource = this.sistemagtBDDataSet;
            // 
            // selectQueryDadosTableAdapter
            // 
            this.selectQueryDadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ResponsavelTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // selectQueryDadosDataGridView
            // 
            this.selectQueryDadosDataGridView.AllowUserToAddRows = false;
            this.selectQueryDadosDataGridView.AllowUserToDeleteRows = false;
            this.selectQueryDadosDataGridView.AllowUserToOrderColumns = true;
            this.selectQueryDadosDataGridView.AutoGenerateColumns = false;
            this.selectQueryDadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectQueryDadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.selectQueryDadosDataGridView.DataSource = this.selectQueryDadosBindingSource;
            this.selectQueryDadosDataGridView.Location = new System.Drawing.Point(191, 64);
            this.selectQueryDadosDataGridView.Name = "selectQueryDadosDataGridView";
            this.selectQueryDadosDataGridView.ReadOnly = true;
            this.selectQueryDadosDataGridView.Size = new System.Drawing.Size(344, 220);
            this.selectQueryDadosDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descrição";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn2.HeaderText = "Status";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Responsável";
            this.dataGridViewTextBoxColumn3.HeaderText = "Responsável";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // BTAtualizar
            // 
            this.BTAtualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTAtualizar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAtualizar.Location = new System.Drawing.Point(12, 326);
            this.BTAtualizar.Name = "BTAtualizar";
            this.BTAtualizar.Size = new System.Drawing.Size(102, 44);
            this.BTAtualizar.TabIndex = 11;
            this.BTAtualizar.Text = "Atualizar";
            this.BTAtualizar.UseVisualStyleBackColor = false;
            this.BTAtualizar.Click += new System.EventHandler(this.BTAtualizar_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 382);
            this.Controls.Add(this.BTAtualizar);
            this.Controls.Add(this.selectQueryDadosDataGridView);
            this.Controls.Add(this.BTFechar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Tarefas";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemagtBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryDadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryDadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MITarefa;
        private System.Windows.Forms.ToolStripMenuItem responsávelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MIStatus;
        private System.Windows.Forms.ToolStripMenuItem MIResponsavel;
        private System.Windows.Forms.ToolStripMenuItem MICadastrarStatus;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MICadastrarTarefa;
        private System.Windows.Forms.Button BTFechar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MIExibirStatus;
        private System.Windows.Forms.ToolStripMenuItem MICadastrarResp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MIExibirResp;
        private SistemagtBDDataSet sistemagtBDDataSet;
        private System.Windows.Forms.BindingSource selectQueryDadosBindingSource;
        private SistemagtBDDataSetTableAdapters.SelectQueryDadosTableAdapter selectQueryDadosTableAdapter;
        private SistemagtBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView selectQueryDadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button BTAtualizar;
    }
}