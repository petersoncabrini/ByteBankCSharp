namespace byteBank
{   
    //A classe e um modelo para criar um objeto
    public class ContaCorrente
    {
        //Campos sao variaveis definidas em uma classe
        public string titular; 
        public string conta;   
        public int numeroAgencia; 
        public string nomeAgencia;
        public double saldo;  

        public bool Sacar (double valor)
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
    }
}