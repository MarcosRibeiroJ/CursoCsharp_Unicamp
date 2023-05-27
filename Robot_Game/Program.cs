namespace Robot_Game
{
    public class Program
    {
        public static void Main()
        {
        /*Campo cp = new Campo();
        cp.setTipo(TipoCampo.JOIA);
        Console.WriteLine(cp.getTipo());
        Console.WriteLine(cp.desenhar());
        int[] posicao = cp.informarPosicao();
            Console.Write(posicao[0] + ", " + posicao[1]);*/
        Map m = new Map();
        m.gerarMapa();
        }
    }
}
