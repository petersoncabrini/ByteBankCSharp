using byteBank.Titular;

namespace byteBank
{
    //A classe é um modelo para criar um objeto
    public class ContaCorrente
    {
        //Campos são variáveis definidas em uma classe
        //Propriedades autoimplementadas
        public Cliente Titular { get; set; }

        private string _conta;

        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        //underscore para referenciar um campo
        private int _numero_agencia;

        public int Numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }


        public string Nome_Agencia { get; set; }

        //private: o saldo torna-se visivel somente dentro dos metodos da classe ContaCorrente
        private double saldo;

        //Metodo ExibirDadosDaConta
        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Conta :" + Conta);
            Console.WriteLine("Número Agência :" + Numero_agencia);
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
        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }

        //Propriedade da classe e nao do objeto (static)
        public static int TotalDeContasCriadas { get; set; }
    }
}