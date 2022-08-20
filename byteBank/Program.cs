using byteBank;

Console.WriteLine("Bem vindo(a) ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "110123-X";
conta1.numeroAgencia = 123;
conta1.nomeAgencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Nogueira";
conta2.conta = "10106-X";
conta2.numeroAgencia = 321;
conta2.nomeAgencia = "Agência Central";
conta2.saldo = 100;

Console.ReadKey();