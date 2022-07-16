using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factorymethod
{
    public class Navio : IMeioDeTransporte
    {
        public string EnviarPedido() => "Eu sou um envio marítimo";
    }
}
