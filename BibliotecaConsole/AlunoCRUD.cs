public class AlunoCRUD
{
    //
    // Propriedades
    //
    private int colini, linini, linper;
    private List<string> dados;
    private List<Aluno> biblioteca;
    private Aluno aluno;
    private int indice;


    //
    // Métodos
    //
    public AlunoCRUD(int col, int lin)
    {
        this.colini = col;
        this.linini = lin;

        this.dados = new List<string>();
        this.dados.Add("Matricula    : ");
        this.dados.Add("Nome         : ");
        this.dados.Add("Email        : ");
        this.dados.Add("Telefone     : ");
        this.linper = linini + this.dados.Count + 1;

        this.biblioteca = new List<Aluno>();
        this.aluno = new Aluno();
        this.indice = -1;
    }

    public void ExecutarCRUD()
    {
        string resp;
        bool achou;
        Tela tela = new Tela(40, 6, this.colini, this.linini, ConsoleColor.Yellow, ConsoleColor.Black);
        tela.MontarTela(dados);

        this.EntrarDados(1);
        achou = this.BuscarRegistro();
        if (!achou)
        {
            resp = tela.Perguntar(
                this.colini + 1,
                this.linper,
                "Não encontrado. Cadastrar (S/N) : ");



            if (resp.ToLower() == "s")
            {
                this.EntrarDados(2);
                resp = tela.Perguntar(this.colini + 1, this.linper, "Confirma cadastro (S/N) : ");
                if (resp.ToLower() == "s")
                {
                    this.biblioteca.Add(
                        new Aluno(this.aluno.matricula, this.aluno.nome,
                            this.aluno.email, this.aluno.telefone
                        ));
                }
            }
        }
        else
        {
            this.MostrarDados();
            Console.ReadKey();
        }
    }


    public void EntrarDados(int qual)
    {
        int coluna = this.colini + this.dados[0].Length + 1;
        int linha = this.linini + 1;
        if (qual == 2) linha++;

        if (qual == 1)
        {
            Console.SetCursorPosition(coluna, linha);
            this.aluno.matricula = Console.ReadLine();
        }
        else
        {
            Console.SetCursorPosition(coluna, linha);
            this.aluno.nome = Console.ReadLine();
            linha++;
            Console.SetCursorPosition(coluna, linha);
            this.aluno.email = Console.ReadLine();
            linha++;
            Console.SetCursorPosition(coluna, linha);
            this.aluno.telefone = Console.ReadLine();
        }
    }


    public bool BuscarRegistro()
    {
        bool encontrei = false;

        for (int i = 0; i < this.biblioteca.Count; i++)
        {
            if (this.biblioteca[i].matricula == this.aluno.matricula)
            {
                this.indice = i;
                encontrei = true;
                break;
            }
        }

        return encontrei;
    }


    public void MostrarDados()
    {
        int coluna = this.colini + this.dados[0].Length + 1;
        int linha = this.linini;
        Console.SetCursorPosition(coluna, linha+2);
        Console.Write(this.biblioteca[this.indice].nome);
        Console.SetCursorPosition(coluna, linha+3);
        Console.Write(this.biblioteca[this.indice].email);
        Console.SetCursorPosition(coluna, linha+4);
        Console.Write(this.biblioteca[this.indice].telefone);
    }



}