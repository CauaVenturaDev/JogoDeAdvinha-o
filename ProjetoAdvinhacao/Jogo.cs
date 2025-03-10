namespace ProjetoAdvinhacao;

public class Jogo
{
    int i = 1;

    public void CertoErrado()
    {
        Algoritimo algoritimo = new();
        int valorAleatorio = algoritimo.Randomizer();
        Console.WriteLine($"Digite a sua {i} tentativa");
        int valorDigitado = Convert.ToInt32(Console.ReadLine());
        if (valorAleatorio > valorDigitado)
        {
            Console.WriteLine("O número aleatorio é maior");
            i++;
        }
        else if (valorAleatorio < valorDigitado)
        {
            Console.WriteLine("O número aleatorio é menor");
            i++;
        }else
            {
                Console.WriteLine("Você venceu o jogo e acertou o número");
            Environment.Exit(0);
            }


        do
        {
            Console.WriteLine($"Digite a sua {i} tentativa");
            int valueDigitado = Convert.ToInt32(Console.ReadLine());

            if (valorAleatorio > valueDigitado) 
            {
                Console.WriteLine("O número aleatorio é maior");
                i++;
            }else if(valorAleatorio < valueDigitado) 
            {
                Console.WriteLine("O número aleatorio é menor");
                i++;
            }else
            {
                Console.WriteLine($"Você venceu o jogo e acertou o número em apenas {i} tentativas");
                Console.WriteLine("Digite 1 para jogar novamente ou qualquer outra tecla para sair!");
                int JogarNovamente = Convert.ToInt32(Console.ReadLine());
                if (JogarNovamente == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Vamos jogar denovo então :)");
                    CertoErrado();
                }
                else
                {
                    Console.WriteLine("Tchau Tchau :(");
                    break;
                }
            }

        }while (valorAleatorio != valorDigitado);
        
        

    }

}