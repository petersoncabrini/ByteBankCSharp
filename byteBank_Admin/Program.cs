using byteBank_Admin.Funcionarios;

Console.WriteLine("Boas vidas, ao ByteBank Administracao");

Funcionario joao = new Funcionario();
joao.Nome = "Joao";
joao.Cpf = "123456789";
joao.Salario = 2000;

Console.WriteLine("Bonificacao: " + joao.getBonificacao());