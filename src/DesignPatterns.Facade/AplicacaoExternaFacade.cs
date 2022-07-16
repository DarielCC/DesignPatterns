using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class AplicacaoExternaFacade
    {
        private AplicacaoExterna _aplicacaoExterna;

        public AplicacaoExternaFacade() => _aplicacaoExterna = new AplicacaoExterna();

        public IEnumerable<string> PedidosPorNome(string nome) 
            => _aplicacaoExterna.PedidosPorNome(nome);
    }
}
