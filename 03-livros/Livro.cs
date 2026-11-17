using System;
using System.Collections.Generic;
using System.Text;

namespace _03_livros
{
    internal class Livro
    {
        public string Titulo;
        public string Autor;
        public int Paginas;
        public Livro(string titular, string autor, int paginas)
        {
            this.Titulo = titular;
            this.Autor = autor;
            this.Paginas = paginas;
        }

        public override string ToString()
        {
            return $"Titulo do livro: {GetTitulo()}\nAutor: {GetAutor()}\nPaginas: {GetPaginas()}";
        }
        public string GetTitulo()
        {
            return this.Titulo;
        }
        public string GetAutor()
        {
            return this.Autor;
        }
        public double GetPaginas()
        {
            return this.Paginas;
        }
        public void SetTitulo(string titulo)
        {
            this.Titulo = titulo;
        }
        public void SetAutor(string autor)
        {
            this.Titulo = autor;
        }
        public void SetPaginas(int paginas)
        {
            this.Paginas = paginas;
        }
    }
}
