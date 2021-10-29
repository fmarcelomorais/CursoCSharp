namespace CursoCSharp.ClassesEMetodos
{
    public class Params
    {
        public static void Recepcionar(params string[] pessoas){
               // System.Console.WriteLine("Olá!, {0}", pessoa[0].ToUpper());
            foreach(var pessoa in pessoas){
                System.Console.WriteLine("Olá!, {0}", pessoa);
            }
        }
        public static void Executar(){
            Recepcionar("Pedro", "Maria", "Marcelo", "Esther", "Elisa");
        }
    }
}