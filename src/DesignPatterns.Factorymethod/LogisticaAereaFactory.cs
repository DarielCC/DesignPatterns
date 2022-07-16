using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factorymethod
{
    public class LogisticaAereaFactory : LogisticaFactory
    {
        public override IMeioDeTransporte CriarMeioDeTransporte()
        {
            return new Aviao();
        }
    }
}
