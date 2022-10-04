using System;

namespace CursoFoop_Solid_Exercicio2
{
    public class Pedido
    {
        //private ConsoleLogger log = new ConsoleLogger();
        private ILogger log;

        public Pedido(ILogger _log)
        {
            log = _log;
        }

        public virtual void AdicionarPedido()
        {
            try
            {
                //código para validar e incluir pedido
                log.Registrar($"Pedido Incluido em :  {DateTime.Now}");
            }
            catch (Exception ex)
            {
                log.Registrar($"{ex} - {DateTime.Now}");
            }
        }
    }
}
