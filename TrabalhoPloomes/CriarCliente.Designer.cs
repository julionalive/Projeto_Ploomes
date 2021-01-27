namespace TrabalhoPloomes
{
    partial class CriarCliente
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
            this.lbl_CriarNovocliente = new System.Windows.Forms.Label();
            this.lbl_NomeCliente = new System.Windows.Forms.Label();
            this.lbl_EmpresaCliente = new System.Windows.Forms.Label();
            this.lbl_TelefoneCliente = new System.Windows.Forms.Label();
            this.lbl_EmailCliente = new System.Windows.Forms.Label();
            this.txb_NomeCliente = new System.Windows.Forms.TextBox();
            this.txb_TelefoneCliente = new System.Windows.Forms.TextBox();
            this.txb_EmailCliente = new System.Windows.Forms.TextBox();
            this.btt_BotaoCriarCliente2 = new System.Windows.Forms.Button();
            this.cbx_EmpresaCliente = new System.Windows.Forms.ComboBox();
            this.btt_SelecionarEmpresa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_CriarNovocliente
            // 
            this.lbl_CriarNovocliente.AutoSize = true;
            this.lbl_CriarNovocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CriarNovocliente.Location = new System.Drawing.Point(135, 62);
            this.lbl_CriarNovocliente.Name = "lbl_CriarNovocliente";
            this.lbl_CriarNovocliente.Size = new System.Drawing.Size(209, 24);
            this.lbl_CriarNovocliente.TabIndex = 0;
            this.lbl_CriarNovocliente.Text = "Criar um novo cliente";
            this.lbl_CriarNovocliente.Click += new System.EventHandler(this.lbl_CriarNovocliente_Click);
            // 
            // lbl_NomeCliente
            // 
            this.lbl_NomeCliente.AutoSize = true;
            this.lbl_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeCliente.Location = new System.Drawing.Point(63, 177);
            this.lbl_NomeCliente.Name = "lbl_NomeCliente";
            this.lbl_NomeCliente.Size = new System.Drawing.Size(62, 17);
            this.lbl_NomeCliente.TabIndex = 1;
            this.lbl_NomeCliente.Text = "NOME: *";
            this.lbl_NomeCliente.Click += new System.EventHandler(this.lbl_NomeCliente_Click);
            // 
            // lbl_EmpresaCliente
            // 
            this.lbl_EmpresaCliente.AutoSize = true;
            this.lbl_EmpresaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmpresaCliente.Location = new System.Drawing.Point(63, 216);
            this.lbl_EmpresaCliente.Name = "lbl_EmpresaCliente";
            this.lbl_EmpresaCliente.Size = new System.Drawing.Size(78, 17);
            this.lbl_EmpresaCliente.TabIndex = 2;
            this.lbl_EmpresaCliente.Text = "EMPRESA:";
            // 
            // lbl_TelefoneCliente
            // 
            this.lbl_TelefoneCliente.AutoSize = true;
            this.lbl_TelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelefoneCliente.Location = new System.Drawing.Point(63, 255);
            this.lbl_TelefoneCliente.Name = "lbl_TelefoneCliente";
            this.lbl_TelefoneCliente.Size = new System.Drawing.Size(85, 17);
            this.lbl_TelefoneCliente.TabIndex = 3;
            this.lbl_TelefoneCliente.Text = "TELEFONE:";
            // 
            // lbl_EmailCliente
            // 
            this.lbl_EmailCliente.AutoSize = true;
            this.lbl_EmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailCliente.Location = new System.Drawing.Point(63, 291);
            this.lbl_EmailCliente.Name = "lbl_EmailCliente";
            this.lbl_EmailCliente.Size = new System.Drawing.Size(57, 17);
            this.lbl_EmailCliente.TabIndex = 4;
            this.lbl_EmailCliente.Text = "E-MAIL:";
            // 
            // txb_NomeCliente
            // 
            this.txb_NomeCliente.Location = new System.Drawing.Point(173, 177);
            this.txb_NomeCliente.Name = "txb_NomeCliente";
            this.txb_NomeCliente.Size = new System.Drawing.Size(257, 20);
            this.txb_NomeCliente.TabIndex = 7;
            this.txb_NomeCliente.TextChanged += new System.EventHandler(this.txb_NomeCliente_TextChanged);
            // 
            // txb_TelefoneCliente
            // 
            this.txb_TelefoneCliente.Location = new System.Drawing.Point(173, 252);
            this.txb_TelefoneCliente.Name = "txb_TelefoneCliente";
            this.txb_TelefoneCliente.Size = new System.Drawing.Size(257, 20);
            this.txb_TelefoneCliente.TabIndex = 9;
            // 
            // txb_EmailCliente
            // 
            this.txb_EmailCliente.Location = new System.Drawing.Point(173, 288);
            this.txb_EmailCliente.Name = "txb_EmailCliente";
            this.txb_EmailCliente.Size = new System.Drawing.Size(257, 20);
            this.txb_EmailCliente.TabIndex = 10;
            // 
            // btt_BotaoCriarCliente2
            // 
            this.btt_BotaoCriarCliente2.Location = new System.Drawing.Point(162, 500);
            this.btt_BotaoCriarCliente2.Name = "btt_BotaoCriarCliente2";
            this.btt_BotaoCriarCliente2.Size = new System.Drawing.Size(182, 47);
            this.btt_BotaoCriarCliente2.TabIndex = 13;
            this.btt_BotaoCriarCliente2.Text = "Criar Cliente";
            this.btt_BotaoCriarCliente2.UseVisualStyleBackColor = true;
            this.btt_BotaoCriarCliente2.Click += new System.EventHandler(this.btt_BotaoCriarCliente2_Click);
            // 
            // cbx_EmpresaCliente
            // 
            this.cbx_EmpresaCliente.FormattingEnabled = true;
            this.cbx_EmpresaCliente.Location = new System.Drawing.Point(173, 216);
            this.cbx_EmpresaCliente.Name = "cbx_EmpresaCliente";
            this.cbx_EmpresaCliente.Size = new System.Drawing.Size(236, 21);
            this.cbx_EmpresaCliente.TabIndex = 14;
            // 
            // btt_SelecionarEmpresa
            // 
            this.btt_SelecionarEmpresa.Location = new System.Drawing.Point(416, 216);
            this.btt_SelecionarEmpresa.Name = "btt_SelecionarEmpresa";
            this.btt_SelecionarEmpresa.Size = new System.Drawing.Size(65, 20);
            this.btt_SelecionarEmpresa.TabIndex = 15;
            this.btt_SelecionarEmpresa.Text = "Atualizar";
            this.btt_SelecionarEmpresa.UseVisualStyleBackColor = true;
            this.btt_SelecionarEmpresa.Click += new System.EventHandler(this.btt_SelecionarEmpresa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 16;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CriarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(512, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_SelecionarEmpresa);
            this.Controls.Add(this.cbx_EmpresaCliente);
            this.Controls.Add(this.btt_BotaoCriarCliente2);
            this.Controls.Add(this.txb_EmailCliente);
            this.Controls.Add(this.txb_TelefoneCliente);
            this.Controls.Add(this.txb_NomeCliente);
            this.Controls.Add(this.lbl_EmailCliente);
            this.Controls.Add(this.lbl_TelefoneCliente);
            this.Controls.Add(this.lbl_EmpresaCliente);
            this.Controls.Add(this.lbl_NomeCliente);
            this.Controls.Add(this.lbl_CriarNovocliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CriarCliente";
            this.Text = "CriarCliente";
            this.Load += new System.EventHandler(this.CriarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CriarNovocliente;
        private System.Windows.Forms.Label lbl_NomeCliente;
        private System.Windows.Forms.Label lbl_EmpresaCliente;
        private System.Windows.Forms.Label lbl_TelefoneCliente;
        private System.Windows.Forms.Label lbl_EmailCliente;
        private System.Windows.Forms.TextBox txb_NomeCliente;
        private System.Windows.Forms.TextBox txb_TelefoneCliente;
        private System.Windows.Forms.TextBox txb_EmailCliente;
        private System.Windows.Forms.Button btt_BotaoCriarCliente2;
        private System.Windows.Forms.ComboBox cbx_EmpresaCliente;
        private System.Windows.Forms.Button btt_SelecionarEmpresa;
        private System.Windows.Forms.Label label1;
    }
}