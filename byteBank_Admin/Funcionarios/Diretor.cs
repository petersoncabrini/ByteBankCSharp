using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_Admin.Funcionarios
{
    // Diretor (derivada ou subclasse) herda da classe Funcionario (superclasse), tendo acesso assim as propriedades e metodos da mesma.
    public class Diretor: Funcionario
    {
        // Adicionando override, eu estou redefinindo o metodo na classe derivada
        public override double getBonificacao()
        {
            return Salario + base.getBonificacao();
        }
    }
}
