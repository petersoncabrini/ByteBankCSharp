using byteBank;
using byteBank.Titular;

Console.WriteLine("Bem vindo(a) ao seu banco, ByteBank!");

ContaCorrente conta5 = new ContaCorrente(2535, "125358-X");

ContaCorrente conta6 = new ContaCorrente(365, "957256-X");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Cliente cliente1 = new Cliente("Joao", "12345678-9", "Dev");
Cliente cliente2 = new Cliente("Maria", "98765432-1", "Jornalista");
Cliente cliente3 = new Cliente("Pedro", "14823052-3", "Professor");

Console.WriteLine(Cliente.TotalDeClientesCadastrados);

Console.ReadKey();

