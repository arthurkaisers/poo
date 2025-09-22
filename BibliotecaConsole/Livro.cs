public class Livro
{
    // propriedades
    public string isbn;
    public string titulo;
    public string autor;
    public int paginas;


    // métodos
    public Livro(string cod="", string tit="", string aut="", int pag=0)
    {
        isbn = cod;
        titulo = tit;
        autor = aut;
        paginas = pag;
    }

    public void ImprimirLivro(int linha)
    {
        Console.SetCursorPosition(0, linha);
        Console.Write(isbn);
        Console.SetCursorPosition(19, linha);
        Console.Write(titulo);
        Console.SetCursorPosition(49, linha);
        Console.Write(autor);
        Console.SetCursorPosition(65, linha);
        Console.Write(paginas);
    }
}