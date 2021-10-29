namespace CursoCSharp.EstruturaDeControle
{
    public class UsandoContinue
    {
        public static void Executar(){
            int intervalo = 50;

            System.Console.WriteLine("numeros Pares entre 1 e {0}", intervalo);
            for(int i = 1; i <= intervalo; i++){
                if(i % 2 == 1){
                   continue; 
                }
                System.Console.Write(i + " ");
            }
        }
    }
}