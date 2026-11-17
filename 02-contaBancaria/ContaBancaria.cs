namespace _02_contaBancaria
{
    internal class ContaBancaria
    {
        public string Titular;
        public double Saldo;
        public ContaBancaria(string titular)
        {
            this.Titular = titular;
            this.Saldo = 0;
        }
        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo = Saldo + valor;
                return true;
            }
            else
                return false;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo = this.Saldo - valor;
                return true;
            }
            else
                return false;

        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"\nSaldo atual: {GetSaldo()}");
        }
        public override string ToString()
        {
            return $"Titular da conta: {GetTitular()}\nSaldo atual: {GetSaldo()}";
        }
        public string GetTitular()
        {
            return this.Titular;
        }
        public double GetSaldo()
        {
            return this.Saldo;
        }
        public void SetTitular(string titular)
        {
            this.Titular = titular;
        }
        public void SetSaldo(double saldo)
        {
            this.Saldo = saldo;
        }
    }
}
