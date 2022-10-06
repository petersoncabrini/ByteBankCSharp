using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_Admin.Funcionarios
{
    // Diretor herda da classe Funcionario, tendo acesso assim as propriedades da mesma.
    public class Diretor: Funcionario
    {
        public double getBonificacao()
        {
            return Salario;
        }
    }
}
