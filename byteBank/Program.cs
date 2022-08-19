using byteBank;

Console.WriteLine("Bem vindo(a) ao seu banco, ByteBank!");

//Criando um objeto do tipo ContaCorrente
ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Usuario";
conta1.conta = "10123-X";
conta1.numeroAgencia = 23;
conta1.nomeAgencia = "Agencia Central";
conta1.saldo = 100;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Numero da Agencia: " + conta1.numeroAgencia);
Console.WriteLine("Nome da Agencia: " + conta1.nomeAgencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.ReadKey();