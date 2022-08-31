using byteBank;
using byteBank.Titular;


Cliente cliente1 = new Cliente("Joao", "12345678-9", "Dev");

Console.WriteLine("Bem vindo(a) ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente(cliente1, "Central", 456, "367892-X");

conta1.ExibirDadosDaConta();



Console.ReadKey();

