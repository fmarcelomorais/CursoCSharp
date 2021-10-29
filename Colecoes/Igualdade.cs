namespace CursoCSharp.Colecoes
{
    public class Igualdade
    {
        public static void Executar(){
            var p1 = new Produto("Caneta", 1.99);
            var p2 = new Produto("Caneta", 1.99);

            System.Console.WriteLine(p1 == p2);
        }
    }
}