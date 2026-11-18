
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
}
    