
namespace GereciadorDeTarefas
{
    partial class Inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTEntrar = new System.Windows.Forms.Button();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.LBSubtitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTEntrar
            // 
            this.BTEntrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTEntrar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEntrar.Location = new System.Drawing.Point(259, 136);
            this.BTEntrar.Name = "BTEntrar";
            this.BTEntrar.Size = new System.Drawing.Size(102, 44);
            this.BTEntrar.TabIndex = 4;
            this.BTEntrar.Text = "Entrar";
            this.BTEntrar.UseVisualStyleBackColor = false;
            this.BTEntrar.Click += new System.EventHandler(this.BTEntrar_Click);
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.Location = new System.Drawing.Point(127, 47);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(361, 23);
            this.LBTitulo.TabIndex = 5;
            this.LBTitulo.Text = "Sistema de Gerenciamento de Tarefas";
            // 
            // LBSubtitulo
            // 
            this.LBSubtitulo.AutoSize = true;
            this.LBSubtitulo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSubtitulo.Location = new System.Drawing.Point(272, 79);
            this.LBSubtitulo.Name = "LBSubtitulo";
            this.LBSubtitulo.Size = new System.Drawing.Size(69, 23);
            this.LBSubtitulo.TabIndex = 6;
            this.LBSubtitulo.Text = "(SGT)";
            // 
            // label1
            // 
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(615, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBSubtitulo);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.BTEntrar);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTEntrar;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.Label LBSubtitulo;
        private System.Windows.Forms.Label label1;
    }
}

