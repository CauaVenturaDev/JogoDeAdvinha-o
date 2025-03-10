namespace ProjetoAdvinhacao;

public class Jogador
{
    public int ValorMaximo()
    {
        Console.WriteLine("Digite o valor máximo que poderá ser escolhido pelo algoritimo");
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
}
