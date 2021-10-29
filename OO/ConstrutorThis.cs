namespace CursoCSharp.OO
{
    public class Animal{
        public string Nome { get; set;}

        public Animal(string nome){
            Nome = nome;
        }
    }

    public class Cachorro: Animal{
        public double Altura { get; set;}

        public Cachorro(string nome) : base(nome){
            System.Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome){
            Altura = altura;
        }

        public override string ToString(){
            return $"{Nome} tem {Altura}cm de Altura ";
        }
    }
    public class ConstrutorThis
    {
        public static void Executar(){
            var dom = new Cachorro("Dom");
            var max = new Cachorro("Max", 40.0);

            System.Console.WriteLine(dom);
            System.Console.WriteLine(max);
        }
    }
}