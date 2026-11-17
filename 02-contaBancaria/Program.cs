using _02_contaBancaria;

ContaBancaria conta1 = new("Pessoa 01");

ContaBancaria conta2 = new("Pessoa 02");

Console.WriteLine();
Console.WriteLine(conta1.ToString() + "\n");
Console.WriteLine(conta2.ToString() + "\n");

void sacar(ContaBancaria contaBancaria, double valorASacar)
{
    if (contaBancaria.Sacar(valorASacar))
        Console.WriteLine($"Você sacou R${valorASacar} da conta: {contaBancaria.GetTitular()}");
    else
        Console.WriteLine($"Saldo insuficiente.");
    contaBancaria.ExibirSaldo();
    Console.WriteLine();

}
void depositar(ContaBancaria contaBancaria, double valorADepositar)
{
    if (contaBancaria.Depositar(valorADepositar))
        Console.WriteLine($"Você depositou R${valorADepositar} na conta: {contaBancaria.GetTitular()}");
    else
        Console.WriteLine($"Valor inválido, tente novamente.");
    contaBancaria.ExibirSaldo();
    Console.WriteLine();
}

depositar(conta1, 120);
sacar(conta1, 30);

depositar(conta2, 500);
sacar(conta2, 50);

Console.WriteLine(conta1.ToString() + "\n");
Console.WriteLine(conta2.ToString() + "\n");
