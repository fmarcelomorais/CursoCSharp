namespace CursoCSharp.ClassesEMetodos
{
    public class ParametroNomeado
    {
        public static void Formatar(int dia, int mes, int ano){
            System.Console.WriteLine("{0:D2} / {1:d2} / {2}", dia, mes, ano);
        }
        public static void Executar(){
            Formatar(mes: 1, dia: 6, ano: 1996);
        }
    }
}