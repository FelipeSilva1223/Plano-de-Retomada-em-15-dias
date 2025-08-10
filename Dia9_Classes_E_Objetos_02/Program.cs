namespace Dia9_Classes_E_Objetos_02
{
    public class ContaBancaria
    {
        public string NumeroConta { get; set; }

        public string Titular { get; set; }

        private double saldo { get; set; }

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

            p1.ExibirExtrato();
        }
    }
}