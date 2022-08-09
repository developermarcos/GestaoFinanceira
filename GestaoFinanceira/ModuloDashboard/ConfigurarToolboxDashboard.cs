using GestaoFinanceira.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.ModuloDashboard
{
    public class ConfigurarToolboxDashboard : ConfigurarToolboxBase
    {
        public override string NomeTela => "Dashboard";

        public override string BotaoCadastrarText => "Dashboard";

        public override bool BotaoCadastrarHabilitado => false;
    }
}
