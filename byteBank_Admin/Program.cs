using byteBank_Admin.Funcionarios;
using byteBank_Admin.Utilitario;

Console.WriteLine("Boas vidas, ao ByteBank Administracao");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario joao = new Funcionario();
joao.Nome = "Joao";
joao.Cpf = "123456789";
joao.Salario = 2000;

Funcionario paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "987654321";
paula.Salario = 5000;
paula.getBonificacao();

gerenciador.Registrar(joao);
gerenciador.Registrar(paula);
Console.WriteLine("Total de Bonificacao:" + gerenciador.getBonificacao());