
namespace GereciadorDeTarefas
{
    partial class CadStatus
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
            System.Windows.Forms.Label idStatusLabel;
            System.Windows.Forms.Label descricaoLabel;
            this.sistemagtBDDataSet = new GereciadorDeTarefas.SistemagtBDDataSet();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.BTLimpar = new System.Windows.Forms.Button();
            this.BTFechar = new System.Windows.Forms.Button();
            this.BTSalvar = new System.Windows.Forms.Button();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.StatusTableAdapter();
            this.tableAdapterManager = new GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.TableAdapterManager();
            this.idStatusLabel1 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            idStatusLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemagtBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemagtBDDataSet
            // 
            this.sistemagtBDDataSet.DataSetName = "SistemagtBDDataSet";
            this.sistemagtBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.Location = new System.Drawing.Point(184, 43);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(168, 20);
            this.LBTitulo.TabIndex = 12;
            this.LBTitulo.Text = "Cadastro de Status";
            // 
            // BTLimpar
            // 
            this.BTLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTLimpar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLimpar.Location = new System.Drawing.Point(12, 199);
            this.BTLimpar.Name = "BTLimpar";
            this.BTLimpar.Size = new System.Drawing.Size(90, 37);
            this.BTLimpar.TabIndex = 13;
            this.BTLimpar.Text = "Limpar";
            this.BTLimpar.UseVisualStyleBackColor = true;
            this.BTLimpar.Click += new System.EventHandler(this.BTLimpar_Click);
            // 
            // BTFechar
            // 
            this.BTFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTFechar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTFechar.Location = new System.Drawing.Point(122, 199);
            this.BTFechar.Name = "BTFechar";
            this.BTFechar.Size = new System.Drawing.Size(90, 37);
            this.BTFechar.TabIndex = 14;
            this.BTFechar.Text = "Fechar";
            this.BTFechar.UseVisualStyleBackColor = true;
            this.BTFechar.Click += new System.EventHandler(this.BTFechar_Click);
            // 
            // BTSalvar
            // 
            this.BTSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTSalvar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSalvar.Location = new System.Drawing.Point(449, 199);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(90, 37);
            this.BTSalvar.TabIndex = 15;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroTableAdapter = null;
            this.tableAdapterManager.ResponsavelTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.TarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idStatusLabel
            // 
            idStatusLabel.AutoSize = true;
            idStatusLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idStatusLabel.Location = new System.Drawing.Point(208, 101);
            idStatusLabel.Name = "idStatusLabel";
            idStatusLabel.Size = new System.Drawing.Size(77, 16);
            idStatusLabel.TabIndex = 16;
            idStatusLabel.Text = "Id Status:";
            // 
            // idStatusLabel1
            // 
            this.idStatusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "IdStatus", true));
            this.idStatusLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idStatusLabel1.Location = new System.Drawing.Point(304, 101);
            this.idStatusLabel1.Name = "idStatusLabel1";
            this.idStatusLabel1.Size = new System.Drawing.Size(100, 23);
            this.idStatusLabel1.TabIndex = 17;
            this.idStatusLabel1.Text = "label1";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(208, 130);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(85, 16);
            descricaoLabel.TabIndex = 18;
            descricaoLabel.Text = "Descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(304, 127);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 26);
            this.descricaoTextBox.TabIndex = 19;
            // 
            // CadStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 256);
            this.Controls.Add(idStatusLabel);
            this.Controls.Add(this.idStatusLabel1);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.BTSalvar);
            this.Controls.Add(this.BTFechar);
            this.Controls.Add(this.BTLimpar);
            this.Controls.Add(this.LBTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadatro de Status";
            this.Load += new System.EventHandler(this.CadStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemagtBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemagtBDDataSet sistemagtBDDataSet;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.Button BTLimpar;
        private System.Windows.Forms.Button BTFechar;
        private System.Windows.Forms.Button BTSalvar;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private SistemagtBDDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private SistemagtBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idStatusLabel1;
        private System.Windows.Forms.TextBox descricaoTextBox;
    }
}