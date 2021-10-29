namespace CursoCSharp.ClassesEMetodos
{
    public class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 1){
            return a + b;
        }
        public static void Executar(){
            System.Console.WriteLine(Somar(10, 23));
            System.Console.WriteLine(Somar(10));
            System.Console.WriteLine(Somar());
            System.Console.WriteLine(Somar(b: 7));

        }
    }
}