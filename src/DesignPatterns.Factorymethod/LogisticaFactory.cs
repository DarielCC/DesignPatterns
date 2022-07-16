using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factorymethod
{
    public abstract class LogisticaFactory
    {
        public abstract IMeioDeTransporte CriarMeioDeTransporte();
    }
}
