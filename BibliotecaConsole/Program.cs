Console.Clear();
Console.WriteLine("--===> Sistema de Biblioteca <===--");

//cria dois livros a partir da classe Livro

Livro livro1 = new Livro("53674-32442-3424-3", "O senhor dos papais", "John Estevão", 3200);
Livro livro2 = new Livro("65327237", "A senhora das mamães", "Joana Estévia", 2300);

/*especifica as caracteristicas(valores das propriedades)
// do objeto "livro1"

livro1.isbn = "53674-32442-3424-3";
livro1.titulo = "O senhor dos papais";
livro1.autor = "John Estevão";
livro1.paginas = 3200;

//especifica as caracteristicas do objeto "livro2"

livro2.isbn = "65327237";
livro2.titulo = "A senhora das mamães";
livro2.autor = "Joana Estévia";
livro2.paginas = 2300;
//
//imprime na tela os dados dos livros
*/

//titulo da colunas
Console.SetCursorPosition(0, 1);
Console.Write("Codigo ISBN");
Console.SetCursorPosition(19, 1);
Console.Write("Titulo do Livro");
Console.SetCursorPosition(49, 1);
Console.Write("Autor do Livro");
Console.SetCursorPosition(65, 1);
Console.Write("Núm. de Páginas");


//dados do livro
livro1.ImprimirLivro(2);
livro2.ImprimirLivro(3);


/*objeto livro1
Console.SetCursorPosition(0, 2);
Console.Write(livro1.isbn);
Console.SetCursorPosition(19, 2);
Console.Write(livro1.titulo);
Console.SetCursorPosition(49, 2);
Console.Write(livro1.autor);
Console.SetCursorPosition(65, 2);
Console.Write(livro1.paginas);

//objeto livro2
Console.SetCursorPosition(0, 3);
Console.Write(livro2.isbn);
Console.SetCursorPosition(19, 3);
Console.Write(livro2.titulo);
Console.SetCursorPosition(49, 3);
Console.Write(livro2.autor);
Console.SetCursorPosition(65, 3);
Console.Write(livro2.paginas);*/



Console.ReadKey();