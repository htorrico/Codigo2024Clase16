using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class FacturadorDIP
    {
        public void RealizarPedido(INotificador notificador)
        {
            Console.WriteLine("Se acaba de realizar el pedido");
            notificador.Notificar();
        }
    }
}
