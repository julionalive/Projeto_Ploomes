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
    public partial class CriarNegocio : Form
    {
        string NomeCliente;

        public CriarNegocio()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 111, 177);
        }


        public CriarNegocio(string valor)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(120, 111, 177);
            NomeCliente = valor;
        }


        private void CriarNegocio_Load(object sender, EventArgs e)
        {

        }

        private void btt_BotaoCriarNegocio_Click(object sender, EventArgs e)
        {
            if (txb_TituloNegocio.Text == "")
            {
                label1.Text = "O campo Nome é obrigatorio";
                label1.ForeColor = Color.Red;

            }
            else
            {
                JObject ClienteNovo = new JObject();

                MessageBox.Show(NomeCliente);
                ClienteNovo.Add("Title", txb_TituloNegocio.Text);
                ClienteNovo.Add("ContactName", NomeCliente);

                try
                {
                    ClienteNovo.Add("Amount", txb_ValorNegocio.Text);



                }
                catch
                {
                    Console.WriteLine("Erro");
                }


                               
                JArray NegocioNovoCliente = RequestHandler.MakePloomesRequest($"Deals", RestSharp.Method.POST, ClienteNovo);

                label1.Text = "Cliente cadastrado com sucesso";
                label1.ForeColor = Color.Green;
            }
        }
    }
}