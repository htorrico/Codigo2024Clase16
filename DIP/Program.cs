

using DIP;

void SinSolid()
{
    Facturador facturador = new Facturador();

    facturador.RealizarPedido(1);

    facturador.RealizarPedido(2);

    facturador.RealizarPedido(3);

}
void ConSolid()
{
    Console.WriteLine("Usando Principios SOLID");

    FacturadorDIP facturadorDIP = new FacturadorDIP();

    //Realizar Pedidos
    facturadorDIP.RealizarPedido(new Email());

    facturadorDIP.RealizarPedido(new Push());

    facturadorDIP.RealizarPedido(new SMS());

    //Cancelando Pedidos
    facturadorDIP.CancelarPedido(new Email());

    facturadorDIP.CancelarPedido(new Push());

    facturadorDIP.CancelarPedido(new SMS());

    //Reservar Pedidos
    facturadorDIP.ReservarPedido(new Email());

    facturadorDIP.ReservarPedido(new Push());

    facturadorDIP.ReservarPedido(new SMS());
}



//FacturadorFInal facturadorFInal = new FacturadorFInal();

//facturadorFInal.ReservarPedido();
//facturadorFInal.RealizarPedido();
//facturadorFInal.CancelarPedido();


//Inyeccion de Dependecias
FacturadorFInal facturadorSMS = new FacturadorFInal(new SMS());
facturadorSMS.Cliente = new Cliente { Apellidos = "Torrico" };

facturadorSMS.ReservarPedido();
facturadorSMS.RealizarPedido();
facturadorSMS.CancelarPedido();


FacturadorFInal facturadorPUSH = new FacturadorFInal(new Push());
facturadorPUSH.ReservarPedido();
facturadorPUSH.RealizarPedido();
facturadorPUSH.CancelarPedido();


FacturadorFInal facturadorEmail = new FacturadorFInal(new Email());
facturadorEmail.ReservarPedido();
facturadorEmail.RealizarPedido();
facturadorEmail.CancelarPedido();




Console.Read();