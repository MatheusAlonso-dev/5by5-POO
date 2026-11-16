using _01___carros;
int qtdCarros = 4;

Carro[] carros = new Carro[qtdCarros];
void PopularVetor(Carro[] vetorCarros)
{
    Carro carro1 = new("Carro 1", "modelo carro 1", 2020, 2021, 110);
    Carro carro2 = new("Carro 2", "modelo carro 2", 2020, 2021, 120);
    Carro carro3 = new("Carro 3", "modelo carro 3", 2020, 2021, 130);
    Carro carro4 = new("Carro 4", "modelo carro 4", 2020, 2021, 140);

    vetorCarros[0] = carro1;
    vetorCarros[1] = carro2;
    vetorCarros[2] = carro3;
    vetorCarros[3] = carro4;
}

void imprimirVetor(Carro[] vetorCarros)
{
    for(int i = 0; i < qtdCarros; i++)
    {
        Console.WriteLine($"{vetorCarros[i].ToString()}\n");
    }
}

PopularVetor(carros);
imprimirVetor(carros);







