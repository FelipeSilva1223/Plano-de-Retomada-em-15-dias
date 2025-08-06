namespace Dia9_Classes_E_Objetos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos!");
        }
    }

    class Carro
    {
        public string Modelo;
        public int Ano;
        public string Cor;

        public Carro(string modelo, int ano, string cor)
        {
            this.Modelo = modelo;
            this.Ano = ano;
            this.Cor = cor;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Este carro do modelo {Modelo}, é da cor {Cor} e foi fabricado no ano {Ano}");
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Pessoa p1 = new Pessoa("Felipe", 26);
            Pessoa p2 = new Pessoa("Fulano", 17);

            Carro c1 = new Carro("Fiat Uno", 2010, "Branca");
            Carro c2 = new Carro("Fiat Palio", 2014, "Vermelha");
            Carro c3 = new Carro("VW Gol GT", 1986, "Preta");
            Carro c4 = new Carro("Ford Fiesta", 2006, "Prata");

            c1.ExibirInformacoes();
            c2.ExibirInformacoes();
            c3.ExibirInformacoes();
            c4.ExibirInformacoes();
        }
    }
}