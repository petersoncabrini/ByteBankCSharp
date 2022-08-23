using byteBank.Titular;

namespace byteBank
{
    //A classe é um modelo para criar um objeto
    public class ContaCorrente
    {
        //Campos são variáveis definidas em uma classe
        public Cliente titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        //private => o saldo torna-se visivel somente dentro dos metodos da classe ContaCorrente
        private double saldo;

        //Metodo ExibirDadosDaConta
        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Conta :" + conta);
            Console.WriteLine("Número Agência :" + numeroAgencia);
            Console.WriteLine("Nome Agência :" + nomeAgencia);
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

        //Metodo DefinirSaldo, para manipular o campo privado
        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo = saldo + valor;
            }
        }
    }
}