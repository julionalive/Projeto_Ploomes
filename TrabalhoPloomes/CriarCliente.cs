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

namespace TrabalhoPloomes
{
    public partial class CriarCliente : Form
    {

        string NomeNovoCliente;

        public CriarCliente()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 111, 177);
        }

        private void CriarCliente_Load(object sender, EventArgs e)
        {
            int typeIdEmpresa = 1;
            SelecionarClienteEmpresa NomeEmpresa = new SelecionarClienteEmpresa();
            NomeEmpresa.SelecionarNomeEmpresaCliente(cbx_EmpresaCliente, typeIdEmpresa);
        }

        private void lbl_NomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void btt_SelecionarEmpresa_Click(object sender, EventArgs e)
        {
            int typeIdEmpresa = 1;
            SelecionarClienteEmpresa NomeEmpresa = new SelecionarClienteEmpresa();
            NomeEmpresa.SelecionarNomeEmpresaCliente(cbx_EmpresaCliente, typeIdEmpresa);
        }

        private void txb_NomeCliente_TextChanged(object sender, EventArgs e)
        {
             NomeNovoCliente = txb_NomeCliente.Text;
        }

        private void btt_BotaoCriarCliente2_Click(object sender, EventArgs e)
        {
            if(txb_NomeCliente.Text == "" )
            {
                label1.Text = "O campo Nome é obrigatorio";
                label1.ForeColor = Color.Red;

            }
            else
            {
                JObject ClienteNovo = new JObject();

                ClienteNovo.Add("Name", txb_NomeCliente.Text);
                ClienteNovo.Add("TypeId", 2);
                try
                {
                    ClienteNovo.Add("Telefone");
                    ClienteNovo.Add("Email", txb_EmailCliente.Text);                              
                    
                    

                }
                catch
                {
                    Console.WriteLine("Erro");
                }
                
               

                JArray clienteTeste = RequestHandler.MakePloomesRequest($"Contacts", RestSharp.Method.POST, ClienteNovo);

                label1.Text = "Cliente cadastrado com sucesso";
                label1.ForeColor = Color.Green;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CriarNovocliente_Click(object sender, EventArgs e)
        {

        }
    }
}
