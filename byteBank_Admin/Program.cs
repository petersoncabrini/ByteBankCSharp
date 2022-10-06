using byteBank_Admin.Funcionarios;
using byteBank_Admin.Utilitario;

Console.WriteLine("Boas vidas, ao ByteBank Administracao");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario joao = new Funcionario();
joao.Nome = "Joao";
joao.Cpf = "123456789";
joao.Salario = 2000;
joao.getBonificacao();

Diretor rafael = new Diretor();
rafael.Nome = "Rafael";
rafael.Cpf = "987612345";
rafael.Salario = 5000;
rafael.getBonificacao();

Funcionario paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "987654321";
paula.Salario = 3000;
paula.getBonificacao();

gerenciador.Registrar(joao);
gerenciador.Registrar(paula);
gerenciador.Registrar(rafael);

Console.WriteLine("Total de Bonificacao:" + gerenciador.getBonificacao());