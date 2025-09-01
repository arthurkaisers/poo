public class Tela
{
    //
    //propriedades
    //
    private int largura;
    private int altura;
    private Coordenada coordenada;
    private ConsoleColor corTexto;
    private ConsoleColor corFundo;


    //
    // método
    //
    public Tela(int lar, int alt, Coordenada coord, ConsoleColor ct, ConsoleColor cf)
    {
        this.largura = lar;
        this.altura = alt;
        this.coordenada = coord;
        this.corTexto = ct;
        this.corFundo = cf;
    }


    public void MontarMoldura(Coordenada cse, Coordenada cid)
    {
        int linha, coluna;
        Coordenada csd, cie;
        csd = new Coordenada(cid.x, cse.y);
        cie = new Coordenada(cse.x, cid.y);
    }
}