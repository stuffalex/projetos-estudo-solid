using System;

namespace CursoFoop_Solid_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger meuLogArquivo = new FileLogger();
            ILogger meuLogConsole = new ConsoleLogger();


            Pedido pedido = new Pedido(meuLogArquivo);
            pedido.AdicionarPedido();

            Console.ReadLine();
        }
    }
}
