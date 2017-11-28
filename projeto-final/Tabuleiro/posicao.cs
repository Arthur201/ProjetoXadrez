

namespace Tabuleiro
{
    class posicao
    {
        int linha { get; set; }
        int coluna { get; set; }
    }
    
    public posicao(int linha, int coluna)
    {
        this.linha = linha;
        this.coluna = coluna;
    }

    public override string Tostring()
    {
        return linha
            + ", "
            + coluna;
    }
}
