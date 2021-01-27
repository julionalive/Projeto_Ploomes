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
    public partial class CriarEmpresa : Form
    {
        public CriarEmpresa()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 111, 177);
        }

        private void CriarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void lbl_NomeEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void txt_NomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btt_BotaoCriarCliente2_Click(object sender, EventArgs e)
        {
            if (txt_NomeEmpresa.Text == "")
            {
                label1.Text = "O campo Nome é obrigatorio";
                label1.ForeColor = Color.Red;

            }
            else
            {
                JObject ClienteNovo = new JObject();

                ClienteNovo.Add("Name", txt_NomeEmpresa.Text);
                ClienteNovo.Add("TypeId", 1);
                try
                {
                    ClienteNovo.Add("Telefone");
                    ClienteNovo.Add("CNPJ", txt_CnpjEmpresa.Text);



                }
                catch
                {
                    Console.WriteLine("Erro");
                }



                JArray clienteTeste = RequestHandler.MakePloomesRequest($"Contacts", RestSharp.Method.POST, ClienteNovo);

                label1.Text = "Empresa cadastrada com sucesso";
                label1.ForeColor = Color.Green;
            }
        }
    }
    
}
