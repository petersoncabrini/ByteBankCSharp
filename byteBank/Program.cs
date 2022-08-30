using byteBank;
using byteBank.Titular;

Console.WriteLine("Bem vindo(a) ao seu banco, ByteBank!");

ContaCorrente conta4 = new ContaCorrente(2535, "125358-X");
conta4.Saldo = 150;
Console.WriteLine(conta4.Saldo);

Console.ReadKey();

Console.ReadKey();