namespace DesignPatterns.Command
{
    public class InserirUsuarioCommand : ICommand
    {
        private string _nome;
        public InserirUsuarioCommand(string nome) => _nome = nome;

        public void Execute()
        {
            Console.WriteLine($"Eu sou o commando de InserirUsuario com nome: {_nome}");
        }
    }
}