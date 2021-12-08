namespace Exercicio_8
{
    internal class Conta
    {
        private int NumeroDaConta { get; set; }
        public string TitularDaConta { get; set; }
        public double Deposito { get; set; }

        public Conta(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
        }

        public Conta(int numeroDaConta, string titularDaConta, double deposito) : this(numeroDaConta, titularDaConta)
        {
            Deposito = deposito;
        }

        public void AdicionarNoDeposito(double valor)
        {
            Deposito = Deposito + valor;
        }

        public void RemoverNoDeposito(double valor)
        {
            Deposito = (Deposito - valor) - 5;
        }

        public override string ToString()
        {
            return "Conta " +
                NumeroDaConta +
                ", Titular: " +
                TitularDaConta +
                ", Saldo: $ " +
                Deposito;
        }
    }
}
