using byteBank.Titular;

namespace byteBank
{
    //A classe é um modelo para criar um objeto
    public class ContaCorrente
    {
        //Campos são variáveis definidas em uma classe
        //Propriedades autoimplementadas
        public Cliente Titular { get; set; }
        public string Conta { get; set; }
        public int Numero_Agencia { get; set; }
        public string Nome_Agencia { get; set; }

        //private: o saldo torna-se visivel somente dentro dos metodos da classe ContaCorrente
        private double saldo;

        //Metodo ExibirDadosDaConta
        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Conta :" + Conta);
            Console.WriteLine("Número Agência :" + Numero_Agencia);
            Console.WriteLine("Nome Agência :" + Nome_Agencia);
            Console.WriteLine("Saldo: " + saldo);
        }

        //Metodo Sacar
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        //Metodo Depositar
        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        //Metodo Transferir
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        //Propriedade Saldo
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }
    }
}