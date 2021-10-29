namespace CursoCSharp.ClassesEMetodos
{
    public class DesafioAtributo
    {
        int a = 10;

        public static void Executar(){
            // acessar variavel 'a' dentro do metodo executar
            DesafioAtributo a = new DesafioAtributo();
            
            System.Console.WriteLine(a.a);
        }
    }
}