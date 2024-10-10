using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Facturador
    {

        private Email email = new Email();
        private SMS sms = new SMS();
        private Push push = new Push();


        public void RealizarPedido(int tipo)
        {
            Console.WriteLine("Se acaba de realizar el pedido");

            if (tipo==1)
            {
                email.Notificar();
            }
            if (tipo==2)
            {
                sms.Notificar();
            }
            if (tipo==3)
            {
                push.Notificar();

            }

        }
    }
}
