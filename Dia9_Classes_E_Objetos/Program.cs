namespace Dia9_Classes_E_Objetos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public List<Carro> Carros = new List<Carro>();

        public void AdicionarCarro(Carro carro)
        {
            Carros.Add(carro);
        }
        public void ExibirCarros()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos");
            Console.WriteLine($"Carros de {Nome}:");
            foreach (var carro in Carros)
            {
                Console.WriteLine($"- {carro.Modelo}, {carro.Ano}, {carro.Cor}");
            }
            Console.Write("\n");
        }

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

            Carro uno = new Carro("Fiat Uno", 2010, "Branca");
            Carro palio = new Carro("Fiat Palio", 2014, "Vermelha");
            Carro gol = new Carro("VW Gol GT", 1986, "Preta");
            Carro fiesta = new Carro("Ford Fiesta", 2006, "Prata");

            p1.AdicionarCarro(gol);
            p1.AdicionarCarro(palio);
            p1.AdicionarCarro(uno);

            p2.AdicionarCarro(fiesta);
            p2.AdicionarCarro(uno);

            p1.ExibirCarros();
            p2.ExibirCarros();
        }
    }
}