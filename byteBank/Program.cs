using byteBank;
using byteBank.Titular;

Console.WriteLine("Bem vindo(a) ao seu banco, ByteBank!");

ContaCorrente conta5 = new ContaCorrente(2535, "125358-X");

ContaCorrente conta6 = new ContaCorrente(365, "957256-X");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();

