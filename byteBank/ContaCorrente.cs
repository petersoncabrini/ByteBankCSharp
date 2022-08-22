using byteBank.Titular;

namespace byteBank
{
    //A classe e um modelo para criar um objeto
    public class ContaCorrente
    {
        //Campos sao variaveis definidas em uma classe
        public Cliente titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo;

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Conta :" + conta);
            Console.WriteLine("Número Agência :" + numeroAgencia);
            Console.WriteLine("Nome Agência :" + nomeAgencia);
            Console.WriteLine("Saldo: " + saldo);
        }

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

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

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
    }
}