namespace CursoCSharp.Colecoes
{
    public class Array
    {
        public static void Executar(){
            string[] alunos = {"Maria", "Joao", "Marta"};
            foreach(string aluno in alunos){
                System.Console.WriteLine($"Nome: {aluno}");
            }
        }
    }
}