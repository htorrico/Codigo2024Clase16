



using DIP;

Facturador facturador = new Facturador();

facturador.RealizarPedido(1);

facturador.RealizarPedido(2);

facturador.RealizarPedido(3);

Console.WriteLine("Usando Principios SOLID");

FacturadorDIP facturadorDIP = new FacturadorDIP();

facturadorDIP.RealizarPedido(new Email());

facturadorDIP.RealizarPedido(new Push());

facturadorDIP.RealizarPedido(new SMS());

Console.Read();