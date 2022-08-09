using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Compartilhado
{
    public abstract class ConfigurarToolboxBase
    {
        public abstract string NomeTela { get; }
        public abstract string BotaoCadastrarText { get; }
        public abstract bool BotaoCadastrarHabilitado { get; }
    }
}
