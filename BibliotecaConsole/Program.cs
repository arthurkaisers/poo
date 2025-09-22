LivroCRUD livros = new LivroCRUD(19, 5);

List<string> opcoes = new List<string>();
opcoes.Add("1 - Empréstimos");
opcoes.Add("2 - Alunos     ");
opcoes.Add("3 - Livros     ");
opcoes.Add("4 - Relatórios ");
opcoes.Add("0 - Sair       ");

Tela tela = new Tela(80, 25, 0, 0, ConsoleColor.Yellow, ConsoleColor.Black);
string op;

while (true)
{
    tela.PrepararTela();
    op = tela.MostrarMenu(opcoes, 2, 1);

    if (op == "0") break;

    if (op == "3") livros.ExecutarCRUD();
}

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
