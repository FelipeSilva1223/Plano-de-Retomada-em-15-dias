namespace Dia9_Classes_E_Objetos_02
{
    public class ContaBancaria
    {
        public string NumeroDaConta;

        public string Titular;

        private double _saldo;

        private string _caminhoDoExtrato;

        public ContaBancaria(string numero, string titular)
        {
            NumeroDaConta = numero;
            Titular = titular;
            _caminhoDoExtrato = @$"D:\Pessoal\Estudos\Programação\C#\Plano de Retomada em 15 dias\Dia9_Classes_E_Objetos_02\ExtratoConta_{NumeroDaConta}.txt";
            if (File.Exists(_caminhoDoExtrato))
            {
                string saldoAtual = File.ReadAllText(_caminhoDoExtrato);

                if (double.TryParse(saldoAtual, out double novoSaldo))
                {
                    _saldo = novoSaldo;
                } else
                {
                    _saldo = 0;
                    File.WriteAllText(_caminhoDoExtrato, $"{_saldo}");
                }
            } else
            {
                File.WriteAllText(_caminhoDoExtrato, "0");
            }
        }

        public void ExibirExtrato()
        {
            Console.WriteLine("- Numero da conta: " + NumeroDaConta);
            Console.WriteLine($"- Titular da conta: {Titular}");
            Console.WriteLine($"O seu saldo atual é de R$ {_saldo} reais.");
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
            conta1.Depositar(50);
            conta2.Depositar(91);
            conta1.ExibirExtrato();
            conta2.ExibirExtrato();
        }
    }
}