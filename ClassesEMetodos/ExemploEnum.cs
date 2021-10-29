namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero{ Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme{
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    public class ExemploEnum
    {
        public static void Executar(){
            int id = (int)Genero.Animacao;
            System.Console.WriteLine(id);

            var filmeFamilia = new Filme();
            filmeFamilia.Titulo = "Heide";
            filmeFamilia.GeneroDoFilme = Genero.Comedia;

            System.Console.WriteLine($"Titulo do Filme: {filmeFamilia.Titulo} | Genero: {filmeFamilia.GeneroDoFilme}");
        }
    }
}