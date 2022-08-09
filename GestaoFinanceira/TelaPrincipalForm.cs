using GestaoFinanceira.Compartilhado;
using GestaoFinanceira.Compartilhado.IOC;
using GestaoFinanceira.ModuloCliente;
using GestaoFinanceira.ModuloDashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        IServiceLocator ServiceLocator;
        public TelaPrincipalForm(IServiceLocator service)
        {
            InitializeComponent();
            ServiceLocator = service;
            labelTitulo.Text = "";
            btnCadastrar.Text = "";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(ServiceLocator.Get<ControladorDashboard>());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(ServiceLocator.Get<ControladorCliente>());
        }
        public void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            this.controlador = controlador;

            ConfigurarToolbox();

            ConfigurarListagem();
        }
        private void ConfigurarToolbox()
        {
            ConfigurarToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                labelTitulo.Text = configuracao.NomeTela;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }
        private void ConfigurarBotoes(ConfigurarToolboxBase configuracao)
        {
            btnCadastrar.Enabled = configuracao.BotaoCadastrarHabilitado;
        }

        private void ConfigurarTooltips(ConfigurarToolboxBase configuracao)
        {
            btnCadastrar.Text = configuracao.BotaoCadastrarText;
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemDados();

            panelConteudo.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelConteudo.Controls.Add(listagemControl);
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }
    }
}
