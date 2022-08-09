using GestaoFinanceira.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolboxCliente();
        }

        public override UserControl ObtemDados()
        {
            return new TabelaClienteControl();
        }
    }
}
