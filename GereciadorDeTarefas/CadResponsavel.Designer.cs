
namespace GereciadorDeTarefas
{
    partial class CadResponsavel
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
            System.Windows.Forms.Label idResponsavelLabel;
            System.Windows.Forms.Label nomeLabel;
            this.sistemagtBDDataSet = new GereciadorDeTarefas.SistemagtBDDataSet();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelTableAdapter = new GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.ResponsavelTableAdapter();
            this.tableAdapterManager = new GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.TableAdapterManager();
            this.idResponsavelLabel1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.BTLimpar = new System.Windows.Forms.Button();
            this.BTFechar = new System.Windows.Forms.Button();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.BTSalvar = new System.Windows.Forms.Button();
            idResponsavelLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemagtBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idResponsavelLabel
            // 
            idResponsavelLabel.AutoSize = true;
            idResponsavelLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idResponsavelLabel.Location = new System.Drawing.Point(159, 90);
            idResponsavelLabel.Name = "idResponsavelLabel";
            idResponsavelLabel.Size = new System.Drawing.Size(66, 16);
            idResponsavelLabel.TabIndex = 1;
            idResponsavelLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(166, 131);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(56, 16);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // sistemagtBDDataSet
            // 
            this.sistemagtBDDataSet.DataSetName = "SistemagtBDDataSet";
            this.sistemagtBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroTableAdapter = null;
            this.tableAdapterManager.ResponsavelTableAdapter = this.responsavelTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GereciadorDeTarefas.SistemagtBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idResponsavelLabel1
            // 
            this.idResponsavelLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsavelBindingSource, "IdResponsavel", true));
            this.idResponsavelLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idResponsavelLabel1.Location = new System.Drawing.Point(231, 90);
            this.idResponsavelLabel1.Name = "idResponsavelLabel1";
            this.idResponsavelLabel1.Size = new System.Drawing.Size(100, 23);
            this.idResponsavelLabel1.TabIndex = 2;
            this.idResponsavelLabel1.Text = "label1";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsavelBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(234, 121);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(143, 26);
            this.nomeTextBox.TabIndex = 4;
            // 
            // BTLimpar
            // 
            this.BTLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTLimpar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLimpar.Location = new System.Drawing.Point(12, 199);
            this.BTLimpar.Name = "BTLimpar";
            this.BTLimpar.Size = new System.Drawing.Size(90, 37);
            this.BTLimpar.TabIndex = 14;
            this.BTLimpar.Text = "Limpar";
            this.BTLimpar.UseVisualStyleBackColor = true;
            this.BTLimpar.Click += new System.EventHandler(this.BTLimpar_Click);
            // 
            // BTFechar
            // 
            this.BTFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTFechar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTFechar.Location = new System.Drawing.Point(108, 199);
            this.BTFechar.Name = "BTFechar";
            this.BTFechar.Size = new System.Drawing.Size(90, 37);
            this.BTFechar.TabIndex = 15;
            this.BTFechar.Text = "Fechar";
            this.BTFechar.UseVisualStyleBackColor = true;
            this.BTFechar.Click += new System.EventHandler(this.BTFechar_Click);
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.Location = new System.Drawing.Point(144, 9);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(223, 20);
            this.LBTitulo.TabIndex = 16;
            this.LBTitulo.Text = "Cadastro de Responsável";
            // 
            // BTSalvar
            // 
            this.BTSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTSalvar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSalvar.Location = new System.Drawing.Point(391, 199);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(90, 37);
            this.BTSalvar.TabIndex = 17;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // CadResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 248);
            this.Controls.Add(this.BTSalvar);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.BTFechar);
            this.Controls.Add(this.BTLimpar);
            this.Controls.Add(idResponsavelLabel);
            this.Controls.Add(this.idResponsavelLabel1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadResponsavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Responsável";
            this.Load += new System.EventHandler(this.CadResponsavel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemagtBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SistemagtBDDataSet sistemagtBDDataSet;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private SistemagtBDDataSetTableAdapters.ResponsavelTableAdapter responsavelTableAdapter;
        private SistemagtBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idResponsavelLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button BTLimpar;
        private System.Windows.Forms.Button BTFechar;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.Button BTSalvar;
    }
}