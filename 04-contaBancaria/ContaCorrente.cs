
public class ContaCorrente : ContaBancaria
{
    public float Limite { get; set; }
    public ContaCorrente(int num) : base(num) { }

    //jeito alternativo de fazer sem precissar sobrescrever o método do pai
    public bool Depositar(float valor)
    {
        if (base.Depositar(valor))
        {
            if (Saldo > 0)
                Limite = 3 * Saldo;
            else
                Limite = 0;
            
            return true;
        }
        else
            return false;
    }

    public override bool Sacar(float valor)
    {
        if (valor <= Saldo+Limite)
        {
            Saldo -= valor;

            if (Saldo > 0)
                Limite = 3 * Saldo;
            else
                Limite = 0;

            return true;
        }
        else
            return false;

    }

    public override bool Pagar(float valor)
    {
        if (valor <= Saldo+Limite)
        {
            Saldo -= valor;

            if (Saldo > 0)
                Limite = 3 * Saldo;
            else
                Limite = 0;

            return true;
        }
        else
            return false;
    }

    
    public override string ToString()
    {
        return $"""
            Numero da conta: {Numero}
            Tipo de conta: Corrente
            Saldo atual: {Saldo}
            Limite: {Limite}
            """;
    }

}

