using _03_livros;

string tituloLivro;
string autor;
int paginas;

bool validarPaginas(int paginas)
{
    if (paginas > 0)
        return true;
    else
        return false;
}
bool ValidarCadastroLivro(string pTLivro, string pAutor, int pPaginas)
{
    if (paginas > 0)
    {
        tituloLivro = pTLivro;
        autor = pAutor;
        paginas = pPaginas;
        return true;
    }
    else
        return false;
}

tituloLivro = "Titulo Livro 01";
autor = "Autor 01";
paginas = 120;

if (ValidarCadastroLivro(tituloLivro,autor,paginas))
{
    Livro livro1 = new(tituloLivro, autor, paginas);
    Console.WriteLine();
    Console.WriteLine(livro1.ToString() + "\n");
}

tituloLivro = "Titulo Livro 02";
autor = "Autor 02";
paginas = 590;

if (ValidarCadastroLivro(tituloLivro, autor, paginas))
{
    Livro livro2 = new(tituloLivro, autor, paginas);
    Console.WriteLine();
    Console.WriteLine(livro2.ToString() + "\n");
}


