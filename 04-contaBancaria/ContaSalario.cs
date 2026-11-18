
using System.ComponentModel;

public class ContaSalario : ContaBancaria
{
    public ContaSalario(int num) : base(num) { }
    public override string ToString()
    {
        return $"""
            Numero da conta: {Numero}
            Tipo de conta: Salario
            Saldo atual: {Saldo}
            """;
    }
}

