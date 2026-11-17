using _02_contaBancaria;

ContaBancaria conta1 = new("Pessoa 01");

ContaBancaria conta2 = new("Pessoa 02");

Console.WriteLine(conta1.ToString());
Console.WriteLine(conta2.ToString());


void sacar(ContaBancaria contaBancaria, double valorASacar)
{
    if (contaBancaria.Sacar(valorASacar))
        Console.WriteLine($"Você sacou R${valorASacar}");
    else
        Console.WriteLine($"Saldo Insuficiente.");

}
