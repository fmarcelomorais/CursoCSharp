using System;
namespace CursoCSharp.Fundamentos
{
    public class OperadoresAritimeticos
    {
        public static void Executar(){
            System.Console.Write("Digite um numero para o calculo ");
            int numero = int.Parse(Console.ReadLine());
                        
            int soma = 0;
            int mult = 0;
            double divi = 0;
            int subt = 0;
            double mod = 0;
            string par = "";

                System.Console.WriteLine("----------------SOMAR--------------------");           
            for(int i = 1; i <= 10; i++){
                soma = numero + i; 
                if(soma % 2 == 0){
                    par = "par";
                }else{
                    par = "impar";
                }
                System.Console.WriteLine($"{numero} + {i} = {soma} - {par}");
            }

                System.Console.WriteLine("----------------SUBTRAIR----------------------");             
            for(int i = 1; i <= 10; i++){
                subt = numero - i;   
                System.Console.WriteLine($"{numero} - {i} = {subt}");
            }

                System.Console.WriteLine("----------------MULTIPLICAR---------------------");              
            for(int i = 1; i <= 10; i++){
                mult = numero * i;     
                System.Console.WriteLine($"{numero} * {i} = {mult}");
            }

                System.Console.WriteLine("--------------------DIVIDIR-----------------------");   
            for(int i = 1; i <= 10; i++){
                divi = numero / i;               
                System.Console.WriteLine($"{numero} / {i} = {divi}");
            }
                System.Console.WriteLine("---------------------RESTO DA DIVISÃO----------------------");   

            for(int i = 1; i <= 10; i++){
                mod = numero % i;               
                System.Console.WriteLine($"{numero} / {i} = {mod}");
            }
                System.Console.WriteLine("-------------------------------------------");   
            
        }
    }
}