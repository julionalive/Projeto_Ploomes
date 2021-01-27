using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace TrabalhoPloomes
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 111, 177); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int typeIdCliente = 2;
            SelecionarClienteEmpresa NomeCliente = new SelecionarClienteEmpresa();
            NomeCliente.SelecionarNomeEmpresaCliente(cbx_SelecionarCliente, typeIdCliente);


            
        }

        private void cbx_SelecionarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btt_BotaoAvancar_Click(object sender, EventArgs e)
        {
           
            if (cbx_SelecionarCliente.Text == "")
            {
                label3.Text = "Selecione um cliente para avançar, Caso não tenha crie um ";
                label3.ForeColor = Color.Red;
            }
            else
            {
                NegociosTarefa nta_ChamadaDaClasse = new NegociosTarefa(cbx_SelecionarCliente.Text);                
                nta_ChamadaDaClasse.ShowDialog();
               
            }

                    
            

        }

        private void btt_AtualizarCliente_Click(object sender, EventArgs e)
        {


            
            int typeIdCliente = 2;
            SelecionarClienteEmpresa NomeCliente = new SelecionarClienteEmpresa();
            NomeCliente.SelecionarNomeEmpresaCliente(cbx_SelecionarCliente, typeIdCliente);


            


        }

       

        private void btt_BotaoCriarCliente_Click(object sender, EventArgs e)
        {
            CriarCliente cce_ChamadaDaClasse = new CriarCliente();
            cce_ChamadaDaClasse.ShowDialog();

        }

        private void btt_BotaoCriarEmpresa_Click(object sender, EventArgs e)
        {
            CriarEmpresa cea_ChamadaDaClasse = new CriarEmpresa();
            cea_ChamadaDaClasse.ShowDialog();
        }

        
    }
}
