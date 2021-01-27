namespace TrabalhoPloomes
{
    partial class CriarNegocio
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
            this.lbl_CriarNovoNegocio = new System.Windows.Forms.Label();
            this.txb_ValorNegocio = new System.Windows.Forms.TextBox();
            this.txb_TituloNegocio = new System.Windows.Forms.TextBox();
            this.lbl_ValorNegocio = new System.Windows.Forms.Label();
            this.lbl_TituloNegocio = new System.Windows.Forms.Label();
            this.btt_BotaoCriarNegocio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_CriarNovoNegocio
            // 
            this.lbl_CriarNovoNegocio.AutoSize = true;
            this.lbl_CriarNovoNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CriarNovoNegocio.Location = new System.Drawing.Point(139, 71);
            this.lbl_CriarNovoNegocio.Name = "lbl_CriarNovoNegocio";
            this.lbl_CriarNovoNegocio.Size = new System.Drawing.Size(226, 24);
            this.lbl_CriarNovoNegocio.TabIndex = 1;
            this.lbl_CriarNovoNegocio.Text = "Criar um novo Negócio";
            // 
            // txb_ValorNegocio
            // 
            this.txb_ValorNegocio.Location = new System.Drawing.Point(183, 214);
            this.txb_ValorNegocio.Name = "txb_ValorNegocio";
            this.txb_ValorNegocio.Size = new System.Drawing.Size(257, 20);
            this.txb_ValorNegocio.TabIndex = 14;
            // 
            // txb_TituloNegocio
            // 
            this.txb_TituloNegocio.Location = new System.Drawing.Point(183, 162);
            this.txb_TituloNegocio.Name = "txb_TituloNegocio";
            this.txb_TituloNegocio.Size = new System.Drawing.Size(257, 20);
            this.txb_TituloNegocio.TabIndex = 13;
            // 
            // lbl_ValorNegocio
            // 
            this.lbl_ValorNegocio.AutoSize = true;
            this.lbl_ValorNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorNegocio.Location = new System.Drawing.Point(73, 217);
            this.lbl_ValorNegocio.Name = "lbl_ValorNegocio";
            this.lbl_ValorNegocio.Size = new System.Drawing.Size(45, 17);
            this.lbl_ValorNegocio.TabIndex = 12;
            this.lbl_ValorNegocio.Text = "Valor:";
            // 
            // lbl_TituloNegocio
            // 
            this.lbl_TituloNegocio.AutoSize = true;
            this.lbl_TituloNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloNegocio.Location = new System.Drawing.Point(73, 162);
            this.lbl_TituloNegocio.Name = "lbl_TituloNegocio";
            this.lbl_TituloNegocio.Size = new System.Drawing.Size(56, 17);
            this.lbl_TituloNegocio.TabIndex = 11;
            this.lbl_TituloNegocio.Text = "Titulo: *";
            // 
            // btt_BotaoCriarNegocio
            // 
            this.btt_BotaoCriarNegocio.Location = new System.Drawing.Point(143, 508);
            this.btt_BotaoCriarNegocio.Name = "btt_BotaoCriarNegocio";
            this.btt_BotaoCriarNegocio.Size = new System.Drawing.Size(182, 47);
            this.btt_BotaoCriarNegocio.TabIndex = 15;
            this.btt_BotaoCriarNegocio.Text = "Criar Cliente";
            this.btt_BotaoCriarNegocio.UseVisualStyleBackColor = true;
            this.btt_BotaoCriarNegocio.Click += new System.EventHandler(this.btt_BotaoCriarNegocio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 16;
            // 
            // CriarNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(512, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_BotaoCriarNegocio);
            this.Controls.Add(this.txb_ValorNegocio);
            this.Controls.Add(this.txb_TituloNegocio);
            this.Controls.Add(this.lbl_ValorNegocio);
            this.Controls.Add(this.lbl_TituloNegocio);
            this.Controls.Add(this.lbl_CriarNovoNegocio);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CriarNegocio";
            this.Text = "CriarNegocio";
            this.Load += new System.EventHandler(this.CriarNegocio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CriarNovoNegocio;
        private System.Windows.Forms.TextBox txb_ValorNegocio;
        private System.Windows.Forms.TextBox txb_TituloNegocio;
        private System.Windows.Forms.Label lbl_ValorNegocio;
        private System.Windows.Forms.Label lbl_TituloNegocio;
        private System.Windows.Forms.Button btt_BotaoCriarNegocio;
        private System.Windows.Forms.Label label1;
    }
}