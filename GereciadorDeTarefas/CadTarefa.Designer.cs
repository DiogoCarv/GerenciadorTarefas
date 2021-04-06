
namespace GereciadorDeTarefas
{
    partial class CadTarefa
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
            System.Windows.Forms.Label idTarefaLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label fKResponsavelLabel;
            System.Windows.Forms.Label fKStatusLabel;
            this.sistemagtBDDataSet = new GereciadorDeTarefas.SistemagtBDDataSet();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaTableAdapter = new GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.TarefaTableAdapter();
            this.tableAdapterManager = new GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.TableAdapterManager();
            this.idTarefaLabel1 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.BTFechar = new System.Windows.Forms.Button();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.StatusTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelTableAdapter = new GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.ResponsavelTableAdapter();
            this.BTSalvar = new System.Windows.Forms.Button();
            idTarefaLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            fKResponsavelLabel = new System.Windows.Forms.Label();
            fKStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemagtBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idTarefaLabel
            // 
            idTarefaLabel.AutoSize = true;
            idTarefaLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idTarefaLabel.Location = new System.Drawing.Point(62, 94);
            idTarefaLabel.Name = "idTarefaLabel";
            idTarefaLabel.Size = new System.Drawing.Size(80, 16);
            idTarefaLabel.TabIndex = 1;
            idTarefaLabel.Text = "Id Tarefa:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(57, 135);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(85, 16);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descricao:";
            // 
            // fKResponsavelLabel
            // 
            fKResponsavelLabel.AutoSize = true;
            fKResponsavelLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fKResponsavelLabel.Location = new System.Drawing.Point(455, 85);
            fKResponsavelLabel.Name = "fKResponsavelLabel";
            fKResponsavelLabel.Size = new System.Drawing.Size(127, 16);
            fKResponsavelLabel.TabIndex = 5;
            fKResponsavelLabel.Text = "FKResponsavel:";
            // 
            // fKStatusLabel
            // 
            fKStatusLabel.AutoSize = true;
            fKStatusLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fKStatusLabel.Location = new System.Drawing.Point(314, 85);
            fKStatusLabel.Name = "fKStatusLabel";
            fKStatusLabel.Size = new System.Drawing.Size(80, 16);
            fKStatusLabel.TabIndex = 7;
            fKStatusLabel.Text = "FKStatus:";
            // 
            // sistemagtBDDataSet
            // 
            this.sistemagtBDDataSet.DataSetName = "SistemagtBDDataSet";
            this.sistemagtBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataMember = "Tarefa";
            this.tarefaBindingSource.DataSource = this.sistemagtBDDataSet;
            // 
            // tarefaTableAdapter
            // 
            this.tarefaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroTableAdapter = null;
            this.tableAdapterManager.ResponsavelTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TarefaTableAdapter = this.tarefaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTarefaLabel1
            // 
            this.idTarefaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "IdTarefa", true));
            this.idTarefaLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTarefaLabel1.Location = new System.Drawing.Point(148, 94);
            this.idTarefaLabel1.Name = "idTarefaLabel1";
            this.idTarefaLabel1.Size = new System.Drawing.Size(100, 23);
            this.idTarefaLabel1.TabIndex = 2;
            this.idTarefaLabel1.Text = "label1";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(150, 132);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(115, 26);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // BTFechar
            // 
            this.BTFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTFechar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTFechar.Location = new System.Drawing.Point(12, 234);
            this.BTFechar.Name = "BTFechar";
            this.BTFechar.Size = new System.Drawing.Size(90, 37);
            this.BTFechar.TabIndex = 10;
            this.BTFechar.Text = "Fechar";
            this.BTFechar.UseVisualStyleBackColor = true;
            this.BTFechar.Click += new System.EventHandler(this.BTFechar_Click);
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.Location = new System.Drawing.Point(216, 9);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(178, 20);
            this.LBTitulo.TabIndex = 11;
            this.LBTitulo.Text = "Cadastro de Tarefas";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.sistemagtBDDataSet;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FKStatus", true));
            this.listBox1.DataSource = this.statusBindingSource1;
            this.listBox1.DisplayMember = "Descricao";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(317, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 14;
            this.listBox1.ValueMember = "IdStatus";
            // 
            // statusBindingSource1
            // 
            this.statusBindingSource1.DataMember = "Status";
            this.statusBindingSource1.DataSource = this.sistemagtBDDataSet;
            // 
            // listBox2
            // 
            this.listBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FKResponsavel", true));
            this.listBox2.DataSource = this.responsavelBindingSource;
            this.listBox2.DisplayMember = "Nome";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(458, 107);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 15;
            this.listBox2.ValueMember = "IdResponsavel";
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataMember = "Responsavel";
            this.responsavelBindingSource.DataSource = this.sistemagtBDDataSet;
            // 
            // responsavelTableAdapter
            // 
            this.responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // BTSalvar
            // 
            this.BTSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTSalvar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSalvar.Location = new System.Drawing.Point(498, 234);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(90, 37);
            this.BTSalvar.TabIndex = 16;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // CadTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 283);
            this.Controls.Add(this.BTSalvar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.BTFechar);
            this.Controls.Add(idTarefaLabel);
            this.Controls.Add(this.idTarefaLabel1);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(fKResponsavelLabel);
            this.Controls.Add(fKStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tarefas";
            this.Load += new System.EventHandler(this.CadTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemagtBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemagtBDDataSet sistemagtBDDataSet;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private SistemagtBDDataSetTableAdapters.TarefaTableAdapter tarefaTableAdapter;
        private SistemagtBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idTarefaLabel1;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button BTFechar;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private SistemagtBDDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource statusBindingSource1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private SistemagtBDDataSetTableAdapters.ResponsavelTableAdapter responsavelTableAdapter;
        private System.Windows.Forms.Button BTSalvar;
    }
}