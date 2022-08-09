using GestaoFinanceira.ModuloCliente;
using GestaoFinanceira.ModuloDashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Compartilhado.IOC
{
    public class ServiceLocatorManual : IServiceLocator
    {
        private Dictionary<string, ControladorBase> controladores;

        public T Get<T>() where T : ControladorBase
        {
            var tipo = typeof(T);

            var nomeControlador = tipo.Name;

            return (T)controladores[nomeControlador];
        }

        public void InicializarControladores()
        {
            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("ControladorDashboard", new ControladorDashboard());

            controladores.Add("ControladorCliente", new ControladorCliente());

            //var configuracao = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("ConfiguracaoAplicacao.json")
            //     .Build();

            //var connectionString = configuracao.GetConnectionString("SqlServer");


            //IRepositorioCliente repositorioCliente = new RepositorioClienteEmBancoDeDados();
            //ServiceCliente serviceCliente = new ServiceCliente(repositorioCliente);
            //controladores.Add("ControladorCliente", new ControladorCliente(serviceCliente));
        }
    }
}
