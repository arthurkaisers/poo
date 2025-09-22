using System.Runtime.InteropServices;

public class Tela
{
    //
    // propriedades
    //
    private int largura, altura, x, y;
    private ConsoleColor corTexto, corFundo;


    //
    // métodos
    //
    public Tela(int lar, int alt, int col, int lin,
                                ConsoleColor ct, ConsoleColor cf)
    {
        this.largura = lar;
        this.altura = alt;
        this.x = col;
        this.y = lin;
        this.corTexto = ct;
        this.corFundo = cf;
    }


    public void PrepararTela()
    {
        Console.BackgroundColor = this.corFundo;
        Console.ForegroundColor = this.corTexto;
        Console.Clear();
        this.MontarMoldura(
            this.x, this.y, this.x + this.largura, this.y + this.altura);
    }


    public void LimparArea(int colini, int linini, int colfin, int linfin)
    {
        for (int x = colini; x <= colfin; x++)
        {
            for (int y = linini; y <= linfin; y++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" "); 
            }
        }
    }


    public void MontarMoldura(int colini, int linini, int colfin, int linfin)
    {
        for (int coluna = colini; coluna <= colfin; coluna++)
        {
            Console.SetCursorPosition(coluna, linini);
            Console.Write("═");
            Console.SetCursorPosition(coluna, linfin);
            Console.Write("═");
        }

        for (int linha = linini; linha <= linfin; linha++)
        {
            Console.SetCursorPosition(colini, linha);
            Console.Write("║");
            Console.SetCursorPosition(colfin, linha);
            Console.Write("║");
        }

        Console.SetCursorPosition(colini, linini);
        Console.Write("╔");
        Console.SetCursorPosition(colini, linfin);
        Console.Write("╚");
        Console.SetCursorPosition(colfin, linini);
        Console.Write("╗");
        Console.SetCursorPosition(colfin, linfin);
        Console.Write("╝");
    }


    public string MostrarMenu(List<string> menu, int colini, int linini)
    {
        string opcao = "";
        int colfin = colini + menu[0].Length + 1;
        int linfin = linini + menu.Count + 2;
        this.MontarMoldura(colini, linini, colfin, linfin);

        int linha = linini + 1;
        foreach (string op in menu)
        {
            Console.SetCursorPosition(colini + 1, linha);
            Console.Write(op);
            linha++;
        }
        Console.SetCursorPosition(colini + 1, linha);
        Console.Write("Opcao : ");
        opcao = Console.ReadLine();

        return opcao;
    }


    public void MontarTela(List<string> dados)
    {
        this.MontarMoldura(this.x, this.y, this.x + this.largura,
            this.y + this.altura);
        int coluna = this.x + 1;
        int linha = this.y + 1;

        foreach (string pergunta in dados)
        {
            Console.SetCursorPosition(coluna, linha);
            Console.Write(pergunta);
            linha++;
        }
    }


}