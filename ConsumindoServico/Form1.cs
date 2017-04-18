using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumindoServico.PassagensService;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var servico = new ClienteServiceClient();
                var nome = txtNome.Text;
                var cpf = txtCpf.Text;
                var cliente = new Cliente()
                {
                    Nome = nome,
                    Cpf = cpf
                };
                servico.Add(cliente);
                MessageBox.Show("Cliente Salvo com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel salvar o cliente");
                throw;
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            try
            {
                var service = new ClienteServiceClient();
                var cliente = service.Buscar(nome);
                txtCpf.Text = cliente.Cpf;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao buscar o cliente");
                throw;
            }
        }
    }
}
