namespace Dia13_Jogo_de_Advinhação
{
    class Program
    {
        public static bool Continuar()
        {
            while (true)
            {
                Console.WriteLine("Deseja iniciar um novo jogo?(s/n):");
                string entrada = Console.ReadLine();
                if (entrada == "s") return true;

                if (entrada == "n") return false;

                Console.WriteLine("Resposta inválida!");
            }
        }
        static void Main(String[] args)
        {
            Random random = new();


            Console.WriteLine("=== JOGO DE ADVINHAÇÃO ===");
            Console.WriteLine("Estou pensando em um número entre 1 e 100...");
            Console.WriteLine("Você tem 5 tentativas! Qual número estou pensando?:");

            do
            {
                int numeroPensado = random.Next(1, 101);

                bool acertou = false;

                Console.WriteLine(numeroPensado);

                for (int tentativas = 1; tentativas <= 5; tentativas++)
                {
                    Console.WriteLine($"Tentativa {tentativas} de 5:");

                    string escolhastr = Console.ReadLine();

                    if(int.TryParse(escolhastr, out int escolhaint))
                    {
                        if (escolhaint == numeroPensado)
                        {
                            Console.WriteLine($"Parabens! Você acertou o número em {tentativas} tentantiva{(tentativas > 1 ? "s":"")}!"); // (condição) - ? funciona como if/else, primeiro caso ("s") se for true, segundo ("") se for false
                            acertou = true;
                            break;
                        }
                        else if (escolhaint > numeroPensado)
                        {
                            Console.WriteLine("O número é MENOR!");
                        } 
                        else if (escolhaint < numeroPensado)
                        {
                            Console.WriteLine("O número é MAIOR!");
                        }
                    } else
                    {
                        Console.WriteLine("Escolha um número!");
                        tentativas--;
                    }
                } if (!acertou)
                {
                    Console.WriteLine($"Você perdeu... O número era {numeroPensado}.");
                }
            } while (Continuar());
        }
    }
}