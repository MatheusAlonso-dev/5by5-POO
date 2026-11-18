//criar vetor de contas para criar cada conta individual utilizando um for
ContaCorrente conta1Corrente = new ContaCorrente(1);
ContaPoupanca conta2Poupanca = new ContaPoupanca(2);
ContaSalario conta3Salario = new ContaSalario(3);

void imprimirContas()
{
    Console.WriteLine("-------------------------");
    Console.WriteLine(conta1Corrente.ToString() + "\n");
    Console.WriteLine(conta2Poupanca.ToString() + "\n");
    Console.WriteLine(conta3Salario.ToString() + "\n");
    Console.WriteLine("-------------------------");

}
void depositar(float valorConta1, float valorConta2, float valorConta3)
{
    conta1Corrente.Depositar(valorConta1);
    conta2Poupanca.Depositar(valorConta2);
    conta3Salario.Depositar(valorConta3);
}

depositar(500, 1000, 20);
imprimirContas();
conta3Salario.Transferir(conta1Corrente, 15);
imprimirContas();