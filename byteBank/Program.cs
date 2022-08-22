using byteBank;
using byteBank.Titular;

Console.WriteLine("Bem vindo(a) ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.conta = "110123-X";
conta1.numeroAgencia = 123;
conta1.nomeAgencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.conta = "10106-X";
conta2.numeroAgencia = 321;
conta2.nomeAgencia = "Agência Central";
conta2.saldo = 100;

Cliente cliente = new Cliente();
cliente.nome = "Andre Silva";
cliente.cpf = "10253541263";
cliente.profissao = "Professor";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = cliente;
conta3.conta = "24506-X";
conta3.numeroAgencia = 35;
conta3.nomeAgencia = "Agência Central";
conta3.saldo = 100;

Console.WriteLine(cliente.nome);
Console.WriteLine(conta3.titular.nome);

Console.ReadKey();