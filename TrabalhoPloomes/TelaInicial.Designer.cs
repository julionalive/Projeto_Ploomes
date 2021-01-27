namespace TrabalhoPloomes
{
    partial class TelaInicial
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
            this.lbl_SelecioneCliente = new System.Windows.Forms.Label();
            this.btt_BotaoAvancar = new System.Windows.Forms.Button();
            this.btt_BotaoCriarCliente = new System.Windows.Forms.Button();
            this.btt_BotaoCriarEmpresa = new System.Windows.Forms.Button();
            this.cbx_SelecionarCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btt_AtualizarClienteEmpresa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_SelecioneCliente
            // 
            this.lbl_SelecioneCliente.AutoSize = true;
            this.lbl_SelecioneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelecioneCliente.Location = new System.Drawing.Point(25, 90);
            this.lbl_SelecioneCliente.Name = "lbl_SelecioneCliente";
            this.lbl_SelecioneCliente.Size = new System.Drawing.Size(515, 13);
            this.lbl_SelecioneCliente.TabIndex = 0;
            this.lbl_SelecioneCliente.Text = "Seja bem bem vindo, Selecione o cliente e empresa desejado, ou crie nos botoes ab" +
    "aixos\r\n";
            // 
            // btt_BotaoAvancar
            // 
            this.btt_BotaoAvancar.Location = new System.Drawing.Point(377, 371);
            this.btt_BotaoAvancar.Name = "btt_BotaoAvancar";
            this.btt_BotaoAvancar.Size = new System.Drawing.Size(163, 42);
            this.btt_BotaoAvancar.TabIndex = 1;
            this.btt_BotaoAvancar.Text = "Avançar";
            this.btt_BotaoAvancar.UseVisualStyleBackColor = true;
            this.btt_BotaoAvancar.Click += new System.EventHandler(this.btt_BotaoAvancar_Click);
            // 
            // btt_BotaoCriarCliente
            // 
            this.btt_BotaoCriarCliente.Location = new System.Drawing.Point(39, 371);
            this.btt_BotaoCriarCliente.Name = "btt_BotaoCriarCliente";
            this.btt_BotaoCriarCliente.Size = new System.Drawing.Size(163, 42);
            this.btt_BotaoCriarCliente.TabIndex = 3;
            this.btt_BotaoCriarCliente.Text = "+ Criar Cliente";
            this.btt_BotaoCriarCliente.UseVisualStyleBackColor = true;
            this.btt_BotaoCriarCliente.Click += new System.EventHandler(this.btt_BotaoCriarCliente_Click);
            // 
            // btt_BotaoCriarEmpresa
            // 
            this.btt_BotaoCriarEmpresa.Location = new System.Drawing.Point(208, 371);
            this.btt_BotaoCriarEmpresa.Name = "btt_BotaoCriarEmpresa";
            this.btt_BotaoCriarEmpresa.Size = new System.Drawing.Size(163, 42);
            this.btt_BotaoCriarEmpresa.TabIndex = 2;
            this.btt_BotaoCriarEmpresa.Text = "+ Criar Empresa";
            this.btt_BotaoCriarEmpresa.UseVisualStyleBackColor = true;
            this.btt_BotaoCriarEmpresa.Click += new System.EventHandler(this.btt_BotaoCriarEmpresa_Click);
            // 
            // cbx_SelecionarCliente
            // 
            this.cbx_SelecionarCliente.FormattingEnabled = true;
            this.cbx_SelecionarCliente.Location = new System.Drawing.Point(148, 150);
            this.cbx_SelecionarCliente.Name = "cbx_SelecionarCliente";
            this.cbx_SelecionarCliente.Size = new System.Drawing.Size(333, 21);
            this.cbx_SelecionarCliente.TabIndex = 4;
            this.cbx_SelecionarCliente.SelectedIndexChanged += new System.EventHandler(this.cbx_SelecionarCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecionar Cliente:";
            // 
            // btt_AtualizarClienteEmpresa
            // 
            this.btt_AtualizarClienteEmpresa.Location = new System.Drawing.Point(28, 210);
            this.btt_AtualizarClienteEmpresa.Name = "btt_AtualizarClienteEmpresa";
            this.btt_AtualizarClienteEmpresa.Size = new System.Drawing.Size(101, 30);
            this.btt_AtualizarClienteEmpresa.TabIndex = 10;
            this.btt_AtualizarClienteEmpresa.Text = "Atualizar";
            this.btt_AtualizarClienteEmpresa.UseVisualStyleBackColor = true;
            this.btt_AtualizarClienteEmpresa.Click += new System.EventHandler(this.btt_AtualizarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 11;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(578, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btt_AtualizarClienteEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_SelecionarCliente);
            this.Controls.Add(this.btt_BotaoCriarCliente);
            this.Controls.Add(this.btt_BotaoCriarEmpresa);
            this.Controls.Add(this.btt_BotaoAvancar);
            this.Controls.Add(this.lbl_SelecioneCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "Teste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SelecioneCliente;
        private System.Windows.Forms.Button btt_BotaoAvancar;
        private System.Windows.Forms.Button btt_BotaoCriarCliente;
        private System.Windows.Forms.Button btt_BotaoCriarEmpresa;
        private System.Windows.Forms.ComboBox cbx_SelecionarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btt_AtualizarClienteEmpresa;
        private System.Windows.Forms.Label label3;
    }
}

