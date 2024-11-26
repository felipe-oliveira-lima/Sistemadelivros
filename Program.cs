using System;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public bool Disponivel { get; set; }

    public Livro(string titulo, string autor, string isbn, string genero)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        Genero = genero;

    }
}

public class Usuario
{
    public string Nome { get; set; }
}