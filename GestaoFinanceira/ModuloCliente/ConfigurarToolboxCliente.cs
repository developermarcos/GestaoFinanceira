using GestaoFinanceira.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.ModuloCliente
{
    public class ConfigurarToolboxCliente : ConfigurarToolboxBase
    {
        public override string NomeTela => "Clientes";

        public override string BotaoCadastrarText => "Cadastrar Cliente";

        public override bool BotaoCadastrarHabilitado => true;
    }
}
