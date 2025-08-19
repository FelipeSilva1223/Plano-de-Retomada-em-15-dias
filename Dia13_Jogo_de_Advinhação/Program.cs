namespace Dia13_Jogo_de_Advinhação
{
    class Program
    {
        public static bool Continuar()
        {
            bool decisao;
            while (true)
            {
                Console.WriteLine("Deseja iniciar um novo jogo?(s/n):");
                string entrada = Console.ReadLine();
                if (entrada == "s")
                {
                    decisao = false;
                    break;
                } else if (entrada == "n")
                {
                    decisao = true;
                    break;
                } else
                {
                    Console.WriteLine("Resposta inválida!");
                }
            } return decisao;
        }
        static void Main(String[] args)
        {
            Random random = new();

            int numeroPensado = random.Next(1, 101);

            int tentativas = 1;

            Console.WriteLine("=== JOGO DE ADVINHAÇÃO ===");
            Console.WriteLine("Estou pensando em um número entre 1 e 100...");
            Console.WriteLine("Você tem 5 tentativas! Qual número estou pensando?:");
            do
            {
                Console.WriteLine($"Tentativa {tentativas}:");

                string escolhastr = Console.ReadLine();

                Console.WriteLine(numeroPensado);

                if (int.TryParse(escolhastr, out int escolhaint))
                {
                    if (escolhaint == numeroPensado)
                    {
                        Console.WriteLine($"Parabens! Você acertou o número em {tentativas} tentantivas!");
                        
                    }
                    else if (escolhaint < numeroPensado)
                    {
                        Console.WriteLine("O número é MAIOR!");
                        tentativas += 1;
                    }
                    else if (escolhaint > numeroPensado)
                    {
                        Console.WriteLine("O número é MENOR!");
                        tentativas += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Escolha um NÚMERO!");
                }
            } while (tentativas <= 5);
            Continuar();
        }
    }
}