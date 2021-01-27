namespace TrabalhoPloomes
{
    partial class NegociosTarefa
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
            this.lbl_ClienteSelecionado = new System.Windows.Forms.Label();
            this.lbl_NegocioCliente = new System.Windows.Forms.Label();
            this.lbl_TarefasCliente = new System.Windows.Forms.Label();
            this.cbx_NegocioCliente = new System.Windows.Forms.ComboBox();
            this.cbx_TarefasCliente = new System.Windows.Forms.ComboBox();
            this.btt_NegocioCliente = new System.Windows.Forms.Button();
            this.btt_TarefasCliente = new System.Windows.Forms.Button();
            this.btt_CriarNegocioCliente = new System.Windows.Forms.Button();
            this.btt_CriarTarefasCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ClienteSelecionado
            // 
            this.lbl_ClienteSelecionado.AutoSize = true;
            this.lbl_ClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClienteSelecionado.Location = new System.Drawing.Point(51, 56);
            this.lbl_ClienteSelecionado.Name = "lbl_ClienteSelecionado";
            this.lbl_ClienteSelecionado.Size = new System.Drawing.Size(219, 20);
            this.lbl_ClienteSelecionado.TabIndex = 1;
            this.lbl_ClienteSelecionado.Text = "Você selecionou o cliente ";
            this.lbl_ClienteSelecionado.Click += new System.EventHandler(this.lbl_ClienteSelecionado_Click);
            // 
            // lbl_NegocioCliente
            // 
            this.lbl_NegocioCliente.AutoSize = true;
            this.lbl_NegocioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NegocioCliente.Location = new System.Drawing.Point(51, 133);
            this.lbl_NegocioCliente.Name = "lbl_NegocioCliente";
            this.lbl_NegocioCliente.Size = new System.Drawing.Size(108, 20);
            this.lbl_NegocioCliente.TabIndex = 2;
            this.lbl_NegocioCliente.Text = "Negocios do";
            // 
            // lbl_TarefasCliente
            // 
            this.lbl_TarefasCliente.AutoSize = true;
            this.lbl_TarefasCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TarefasCliente.Location = new System.Drawing.Point(51, 313);
            this.lbl_TarefasCliente.Name = "lbl_TarefasCliente";
            this.lbl_TarefasCliente.Size = new System.Drawing.Size(95, 20);
            this.lbl_TarefasCliente.TabIndex = 3;
            this.lbl_TarefasCliente.Text = "Tarefas do";
            // 
            // cbx_NegocioCliente
            // 
            this.cbx_NegocioCliente.FormattingEnabled = true;
            this.cbx_NegocioCliente.Location = new System.Drawing.Point(55, 171);
            this.cbx_NegocioCliente.Name = "cbx_NegocioCliente";
            this.cbx_NegocioCliente.Size = new System.Drawing.Size(393, 21);
            this.cbx_NegocioCliente.TabIndex = 4;
            // 
            // cbx_TarefasCliente
            // 
            this.cbx_TarefasCliente.FormattingEnabled = true;
            this.cbx_TarefasCliente.Location = new System.Drawing.Point(55, 353);
            this.cbx_TarefasCliente.Name = "cbx_TarefasCliente";
            this.cbx_TarefasCliente.Size = new System.Drawing.Size(393, 21);
            this.cbx_TarefasCliente.TabIndex = 5;
            // 
            // btt_NegocioCliente
            // 
            this.btt_NegocioCliente.Location = new System.Drawing.Point(55, 219);
            this.btt_NegocioCliente.Name = "btt_NegocioCliente";
            this.btt_NegocioCliente.Size = new System.Drawing.Size(393, 36);
            this.btt_NegocioCliente.TabIndex = 6;
            this.btt_NegocioCliente.Text = "Atualizar Dados do negócio selecionado ";
            this.btt_NegocioCliente.UseVisualStyleBackColor = true;
            // 
            // btt_TarefasCliente
            // 
            this.btt_TarefasCliente.Location = new System.Drawing.Point(55, 403);
            this.btt_TarefasCliente.Name = "btt_TarefasCliente";
            this.btt_TarefasCliente.Size = new System.Drawing.Size(393, 36);
            this.btt_TarefasCliente.TabIndex = 7;
            this.btt_TarefasCliente.Text = "Atualizar Dados da tarefa selecionada ";
            this.btt_TarefasCliente.UseVisualStyleBackColor = true;
            // 
            // btt_CriarNegocioCliente
            // 
            this.btt_CriarNegocioCliente.Location = new System.Drawing.Point(55, 518);
            this.btt_CriarNegocioCliente.Name = "btt_CriarNegocioCliente";
            this.btt_CriarNegocioCliente.Size = new System.Drawing.Size(163, 42);
            this.btt_CriarNegocioCliente.TabIndex = 8;
            this.btt_CriarNegocioCliente.Text = "+ Criar Negócio";
            this.btt_CriarNegocioCliente.UseVisualStyleBackColor = true;
            this.btt_CriarNegocioCliente.Click += new System.EventHandler(this.btt_CriarNegocioCliente_Click);
            // 
            // btt_CriarTarefasCliente
            // 
            this.btt_CriarTarefasCliente.Location = new System.Drawing.Point(285, 518);
            this.btt_CriarTarefasCliente.Name = "btt_CriarTarefasCliente";
            this.btt_CriarTarefasCliente.Size = new System.Drawing.Size(163, 42);
            this.btt_CriarTarefasCliente.TabIndex = 9;
            this.btt_CriarTarefasCliente.Text = "+ Criar Tarefa";
            this.btt_CriarTarefasCliente.UseVisualStyleBackColor = true;
            // 
            // NegociosTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(512, 604);
            this.Controls.Add(this.btt_CriarTarefasCliente);
            this.Controls.Add(this.btt_CriarNegocioCliente);
            this.Controls.Add(this.btt_TarefasCliente);
            this.Controls.Add(this.btt_NegocioCliente);
            this.Controls.Add(this.cbx_TarefasCliente);
            this.Controls.Add(this.cbx_NegocioCliente);
            this.Controls.Add(this.lbl_TarefasCliente);
            this.Controls.Add(this.lbl_NegocioCliente);
            this.Controls.Add(this.lbl_ClienteSelecionado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NegociosTarefa";
            this.Text = "NegociosTarefa";
            this.Load += new System.EventHandler(this.NegociosTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_ClienteSelecionado;
        public System.Windows.Forms.Label lbl_NegocioCliente;
        public System.Windows.Forms.Label lbl_TarefasCliente;
        private System.Windows.Forms.ComboBox cbx_NegocioCliente;
        private System.Windows.Forms.ComboBox cbx_TarefasCliente;
        private System.Windows.Forms.Button btt_NegocioCliente;
        private System.Windows.Forms.Button btt_TarefasCliente;
        private System.Windows.Forms.Button btt_CriarNegocioCliente;
        private System.Windows.Forms.Button btt_CriarTarefasCliente;
    }
}