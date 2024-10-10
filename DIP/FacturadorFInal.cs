using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class FacturadorFInal
    {

        //public INotificador _notificador { get; set; }

        public Cliente Cliente { get; set; }

        //Inyeccion de Dependecias
        private INotificador _notificador;

        public FacturadorFInal(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void RealizarPedido()
        {
            Console.WriteLine("Se acaba de realizar el pedido");
            _notificador.Notificar();
        }
        public void CancelarPedido()
        {
            Console.WriteLine("Se acaba de cancelar el pedido");
            _notificador.Notificar();
        }

        public void ReservarPedido()
        {
            Console.WriteLine("Se acaba de reservar el pedido");
            _notificador.Notificar();
        }
    }
}
