namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaFor
    {
        public static void Executar(){
            int i = 1;

            while(i <= 10){
                System.Console.WriteLine(i);
                i++;
            }

            for(i = 0; i <= 10; i++){
                System.Console.WriteLine(i);
            }
        }
    }
}