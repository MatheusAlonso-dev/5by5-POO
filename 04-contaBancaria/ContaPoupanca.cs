
using System.ComponentModel;

public class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(int num) : base(num) { }
    public override bool Sacar(float valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor*(float)(1.05);
            return true;
        }
        else
            return false;
    }

    public override string ToString()
    {
        return $"""
            Numero da conta: {Numero}
            Tipo de conta: Poupança
            Saldo atual: {Saldo}
            """;
    }

}

