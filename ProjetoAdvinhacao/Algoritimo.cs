namespace ProjetoAdvinhacao;

public class Algoritimo
{
    public int Randomizer()
    { var jogador = new Jogador();
      var randon = new Random();
      int valorAlgoritimo = jogador.ValorMaximo();
      int aleatorio = randon.Next(valorAlgoritimo);
      return aleatorio;
    }

    
}
