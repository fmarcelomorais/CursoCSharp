namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaForEach
    {
        public static void Executar(){
            string palavra = "Marcelo";

            foreach(var letra in palavra){
                System.Console.WriteLine(letra);
            }

            var alunos = new string[] {"Ana", "Bia", "Carlos"};

            foreach(string aluno in alunos){
                System.Console.WriteLine(aluno);
            }
        }
    }
}