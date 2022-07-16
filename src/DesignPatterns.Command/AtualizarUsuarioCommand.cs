using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class AtualizarUsuarioCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Eu sou o commando de AtualizarUsuario");
        }
    }
}
