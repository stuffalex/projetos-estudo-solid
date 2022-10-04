using System;

namespace cursoFoop_Exercicio_SOLID1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = LocalizaCliente.ProcuraPorNome("Pedro");
            // ?. verifica se o operando esquerdo for null não avalia
            // os demais operandos e não lança NullReferenceException
            //--------------------------------------------------------
            // ?? retorna o valor do operando esquerdo se não for null
            // se for null avalia o operando direito e retorna o seu valor
            Console.WriteLine(cliente?.Nome ?? "Não localizado");
            Console.ReadLine();
        }
    }
}
