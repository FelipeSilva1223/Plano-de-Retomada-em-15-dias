namespace Dia9_Classes_E_Objetos_02
{
    public class ContaBancaria (string numeroConta, string titular)
    {
        public string NumeroDaConta = numeroConta;

        public string Titular = titular;

        private double _saldo;

        private string _caminhoDoExtrato = @$"D:\Pessoal\Estudos\Programação\C#\Plano de Retomada em 15 dias\Dia9_Classes_E_Objetos_02\ExtratoConta_{numeroConta}.txt";

        public void ExibirExtrato()
        {
            try
            {
                if (File.Exists(_caminhoDoExtrato))
                {
                    string extrato = File.ReadAllText(_caminhoDoExtrato);
                    Console.WriteLine("- Numero da conta: " + NumeroDaConta);
                    Console.WriteLine($"- Titular da conta: {Titular}");
                    Console.WriteLine($"O seu saldo atual é de R$ {extrato} reais.");
                } else
                {
                    File.Create(_caminhoDoExtrato).Close();
                    File.WriteAllText(_caminhoDoExtrato, "0");
                    Console.WriteLine("Ainda não ha extratos sobre esta conta.");
                }
            } catch (IOException ex)
            {
                Console.WriteLine("Erro na leitura dos dados de extrato." + ex.Message);
            }
        }
        public void Depositar(double valor)
        {
            _saldo += valor;
            File.WriteAllText(_caminhoDoExtrato, $"{_saldo}");
            Console.WriteLine($"Depósito de {valor} realizado com sucesso!");
        }
        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                Console.WriteLine("Você não possui saldo o suficiente.");
            } else
            {
                _saldo -= valor;
                File.WriteAllText(_caminhoDoExtrato, $"{_saldo}");
                Console.WriteLine($"Saque de {valor} realizado com sucesso!");
            }
        }
    }
    class Program
    {
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

            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int opcao))
            {
                return opcao;
            }
            else
            {
                return 0;
            }
        }

        public bool ChecarArquivo(string arquivo)
        {
            return File.Exists(arquivo);
        }

        public bool Sair()
        {
            bool sair;
            while (true)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("O que deseja fazer a seguir?");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Voltar ao inicio");
                Console.WriteLine("------------------------------");
                int resposta = int.Parse(Console.ReadLine());
                if (resposta == 0)
                {
                    sair = false;
                    break;
                }
                else if (resposta == 1)
                {
                    sair = true;
                    break;
                }
                else Console.WriteLine("Resposta inválida");
            }
            return sair;
        }

        static void Main(String[] args)
        {
            ContaBancaria conta1 = new ContaBancaria("123", "Fulano");
            ContaBancaria conta2 = new ContaBancaria("321", "bertano");
            conta2.ExibirExtrato();
        }
    }
}