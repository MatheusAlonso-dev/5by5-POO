
public abstract class ContaBancaria
{
    public int Numero { get; set; }
    public float Saldo { get; set; }
    public ContaBancaria(int numero)
    {
        Numero = numero;
    }

    public bool Depositar(float valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            return true;
        }
        else
            return false;
    }

    //virtual pq vai ser sobrescrito
    public virtual bool Sacar(float valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            return true;
        }
        else
            return false;
    }

    //virtual pq vai ser sobrescrito
    public virtual bool Pagar(float valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            return true;
        }
        else
            return false;
    }

    public virtual bool Transferir(ContaCorrente contaCorrente, float valor)
    {
        if (valor <= Saldo)
        {
            
            if (contaCorrente.Depositar(valor))
            {
                Saldo -= valor;
                return true;
            }
            else
                return false;
        }
        else
            return false;
    }

    public virtual bool Transferir(ContaPoupanca contaPoupanca, float valor)
    {
        if (valor <= Saldo)
        {

            if (contaPoupanca.Depositar(valor))
            {
                Saldo -= valor;
                return true;
            }
            else
                return false;
        }
        else
            return false;
    }

    public virtual bool Transferir(ContaSalario contaSalario, float valor)
    {
        if (valor <= Saldo)
        {

            if (contaSalario.Depositar(valor))
            {
                Saldo -= valor;
                return true;
            }
            else
                return false;
        }
        else
            return false;
    }
}
    