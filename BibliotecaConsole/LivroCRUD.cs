public class LivroCRUD
{
    //
    // Propriedades
    //
    private int ci, li;
    private List<string> dados;
    private List<Livro> biblioteca;
    private Livro livro;
    private int indice;

    //
    // Métodos
    //
    public LivroCRUD(int col, int lin)
    {
        this.ci = col;
        this.li = lin;

        this.dados = new List<string>();
        this.dados.Add("ISBN    : ");
        this.dados.Add("Título  : ");
        this.dados.Add("Autor   : ");
        this.dados.Add("Páginas : ");

        this.biblioteca = new List<Livro>();
        this.livro = new Livro();
        this.indice = -1;
    }

    public void ExecutarCRUD()
    {
        Tela tela = new Tela(40, 6, this.ci, this.li, ConsoleColor.Yellow, ConsoleColor.Black);
        tela.MontarTela(dados);

        this.EntrarDados(1);


    }
    public void EntrarDados(int qual)
    {
        int coluna = this.ci + this.dados[0].Length + 1;
        int linha = this.li + 1;
        if (qual == 2) linha++;

        if (qual == 1)
        {
            Console.SetCursorPosition(coluna, linha);
            this.livro.isbn = Console.ReadLine();
        }
        else
        {
            Console.SetCursorPosition(coluna, linha);
            this.livro.titulo = Console.ReadLine();
            linha++;
            Console.SetCursorPosition(coluna, linha);
            this.livro.autor = Console.ReadLine();
            linha++;
            Console.SetCursorPosition(coluna, linha);
            this.livro.paginas = int.Parse(Console.ReadLine());
        }
        
    }
}