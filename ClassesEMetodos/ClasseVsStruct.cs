namespace CursoCSharp.ClassesEMetodos
{

    public struct SPonto{
        public int X;
        public int Y;
    }
    public class CPonto{
        public int X;
        public int Y;
    }

    public class ClasseVsStruct
    {
        public static void Executar(){
            SPonto ponto1 = new SPonto {X = 1, Y = 3};
            SPonto copiaPonto1 = ponto1; // Atribuição por Valor
            ponto1.X = 3;

            System.Console.WriteLine("Ponto1 X = {0}", ponto1.X);
            System.Console.WriteLine("Copia Ponto1 X = {0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto {X = 2, Y = 4};
            CPonto copiaCPonto2 = ponto2; // Atribuicao por Referencia
            ponto2.X = 4;
            System.Console.WriteLine("Ponto2 X = {0}", ponto2.X);
            System.Console.WriteLine("Copia Ponto2 X = {0}", copiaCPonto2.X);

        }
    }
}