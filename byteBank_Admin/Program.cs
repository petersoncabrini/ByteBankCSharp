using byteBank_Admin.Funcionarios;

Console.WriteLine("Boas vidas, ao ByteBank Administracao");

Funcionario joao = new Funcionario(1);
joao.Nome = "Joao";
joao.Cpf = "123456789";
joao.Salario = 2000;

Console.WriteLine("Nome: " + joao.Nome);
Console.WriteLine("CPF: " + joao.Cpf);
Console.WriteLine("Salario: " + joao.Salario);
Console.WriteLine("Bonificacao: " + joao.getBonificacao());