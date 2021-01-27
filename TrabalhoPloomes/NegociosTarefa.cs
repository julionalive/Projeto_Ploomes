using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoPloomes
{
    public partial class NegociosTarefa : Form
    {
        string NomeCliente;

        public NegociosTarefa()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 111, 177);
        }

        public NegociosTarefa(string valor)
        {
           
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 111, 177);
            NomeCliente = valor;
            lbl_ClienteSelecionado.Text = "Você Selecionou o Cliente : "+  NomeCliente;
            lbl_NegocioCliente.Text = "Negócios do " + NomeCliente;
            lbl_TarefasCliente.Text = "Tarefas do " + NomeCliente;
            
            
            
        }

        

        private void NegociosTarefa_Load(object sender, EventArgs e)
        {
            
            string TipoDeFiltro = "Deals";            
            SelecionarClienteEmpresa FiltroNegocio = new SelecionarClienteEmpresa();
            FiltroNegocio.FiltrarNegociosTarefas(TipoDeFiltro , cbx_NegocioCliente, NomeCliente);


            string TipoDeTarefa = "Tasks";
            SelecionarClienteEmpresa FiltroTarefa = new SelecionarClienteEmpresa();
            FiltroNegocio.FiltrarNegociosTarefas(TipoDeTarefa, cbx_TarefasCliente, NomeCliente);





        }

        private void lbl_ClienteSelecionado_Click(object sender, EventArgs e)
        {
            
        }

        private void btt_CriarNegocioCliente_Click(object sender, EventArgs e)
        {
            CriarNegocio cno_ChamadaDeForms = new CriarNegocio(NomeCliente);
            cno_ChamadaDeForms.ShowDialog();
        }
    }
}
