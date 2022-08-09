using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Compartilhado.IOC
{
    public interface IServiceLocator
    {
        public T Get<T>() where T : ControladorBase;
        void InicializarControladores();
    }
}
