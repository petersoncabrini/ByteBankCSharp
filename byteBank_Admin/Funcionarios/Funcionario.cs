using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_Admin.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        // Adicionando o virtual, o metodo getBonificacao() pode ser redefinido na classe derivada (Diretor)
        public virtual double getBonificacao()
        {
                return Salario * 0.1;
        }
    }
}
