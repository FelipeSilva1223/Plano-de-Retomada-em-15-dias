namespace Dia9_Classes_E_Objetos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos!");
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Felipe";
            p1.Idade = 26;
            p1.Apresentar();

            Pessoa p2 = new Pessoa
            {
                Nome = "Fulano",
                Idade = 25
            };
            p2.Apresentar();
        }
    }
}