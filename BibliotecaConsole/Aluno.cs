public class Aluno
{
    public string matricula;
    public string nome;
    public string telefone;
    public string email;


    //metodos

    public Aluno(string mat = "", string nom = "", string eml = "", string tel = "")
    {
        matricula = mat;
        nome = nom;
        telefone = tel;
        email = eml;
    }

    public void ImprimirAluno(int linha)
    {
        Console.SetCursorPosition(0, linha);
        Console.Write(matricula);
        Console.SetCursorPosition(19, linha);
        Console.Write(nome);
        Console.SetCursorPosition(49, linha);
        Console.Write(telefone);
        Console.SetCursorPosition(65, linha);
        Console.Write(email);
    }
}