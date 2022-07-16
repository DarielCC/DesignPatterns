// See https://aka.ms/new-console-template for more information
using DesignPatterns.Command;
using DesignPatterns.Facade;
using DesignPatterns.Factorymethod;

/*Console.Write("Digite o tipo de envio que precisa ser preparado");
var tipoDeEnvio = Console.ReadLine().Trim();

Console.WriteLine("Hello, World! Sem Factory Method");

if(tipoDeEnvio == "maritimo")
{
    var navioSemfactory = new Navio();
    Console.WriteLine(navioSemfactory.EnviarPedido());
}
else if (tipoDeEnvio == "terrestre")
{
    var caminhaoSemfactory = new Caminhao();
    Console.WriteLine(caminhaoSemfactory.EnviarPedido());
}
else if (tipoDeEnvio == "aereo")
{
    var aviaoSemfactory = new Aviao();
    Console.WriteLine(aviaoSemfactory.EnviarPedido());
}

Console.WriteLine("Hello, World! Aplicando o Factory Method");

LogisticaFactory logistica;

logistica = tipoDeEnvio switch
{
    "terrestre" => new LogisticaTerrestreFactory(),
    "aereo" => new LogisticaAereaFactory(),
    _ => new LogisticaMaritimaFactory(),
};

var meioDeTransaporte = logistica.CriarMeioDeTransporte();
Console.WriteLine(meioDeTransaporte.EnviarPedido());


Console.WriteLine("Hello, World! Aplicando o Facade");
Console.Write("Digite o nome do pedido");
var nomeDoPedido = Console.ReadLine().Trim();
var aplicacaoExternaFacade = new AplicacaoExternaFacade();
var pedidos = aplicacaoExternaFacade.PedidosPorNome(nomeDoPedido);

foreach(var pedido in pedidos)
    Console.WriteLine(pedido);

*/
Console.WriteLine("Hello, World! Aplicando o Command");


Console.Write("Digite a ação a ser realizada");
var acao = Console.ReadLine().Trim();
ICommand command;

command = acao switch
{
    "inserir" => new InserirUsuarioCommand(Console.ReadLine().Trim()),
    _ => new AtualizarUsuarioCommand()
};

command.Execute();