
namespace SistemaZoologico
{
    
    public class Animal
    {
        
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

       
        public virtual void Emitir()
        {
            Console.WriteLine("O animal emite um som.");
        }
    }

    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade) { }

        public override void Emitir()
        {
            Console.WriteLine("O cachorro está latindo: Au au!");
        }
    }
    public class Gato : Animal
    {
        public Gato(string nome, int idade) : base(nome, idade) { }

        public override void Emitir()
        {
            Console.WriteLine("O gato está miando: Miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE ANIMAIS ===");

   
            List<Animal> animais = new List<Animal>
            {
                new Cachorro("Rex", 3),
                new Gato("Mimi", 2)
            };

          
            foreach (Animal animal in animais)
            {
                Console.WriteLine($"Animal: {animal.Nome}");
                Console.WriteLine($"Idade: {animal.Idade} anos");
                Console.Write("Som: ");
                animal.EmitirSom();
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
