namespace Dia9_Classes_E_Objetos_02
{
    public class ContaBancaria
    {
        public string NumeroConta { get; set; }

        public string Titular { get; set; }

        private double saldo { get; set; }

        public int ExibirMenu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bem vindo ao sistema bancário!\n");
            Console.WriteLine("Qual serviço deseja utilizar?\n");
            Console.WriteLine("1 - Ver extrato");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("------------------------------");

            int opcao = int.Parse(Console.ReadLine());

            return opcao;
        }

        public void ExibirExtrato()
        {
            Console.WriteLine("Numero da conta: " + NumeroConta);
            Console.WriteLine($"Titular da conta: {Titular}");
            Console.WriteLine($"O seu saldo atual é de R$ {saldo} reais.");
        }
        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso!");
        }
        public void Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Você não possui saldo o suficiente.");
            } else
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso!");
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            ContaBancaria p1 = new ContaBancaria();
            p1.NumeroConta = "123";
            p1.Titular = "Fulano";

            int opcao;
            do
            {
                opcao = p1.ExibirMenu();
                switch (opcao)
                {
                    case 1:
                        {
                            p1.ExibirExtrato();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Quanto deseja depositar?");
                            double valor = double.Parse(Console.ReadLine());
                            p1.Depositar(valor);
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Quanto deseja sacar?");
                            double valor = double.Parse(Console.ReadLine());
                            p1.Sacar(valor);
                        }
                        break;

                    case 0:
                        {
                            Console.WriteLine("Obrigado por usar nosso sistema bancário!");
                            break;
                        }
                }
            } while (opcao != 0);
        }
    }
}