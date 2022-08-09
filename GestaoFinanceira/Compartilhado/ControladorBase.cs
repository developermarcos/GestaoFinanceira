using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void Filtrar() { }

        public virtual void Visualizar() { }

        public abstract UserControl ObtemDados();

        public abstract ConfigurarToolboxBase ObtemConfiguracaoToolbox();
    }
}
