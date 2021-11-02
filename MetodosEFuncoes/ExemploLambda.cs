using System;

namespace CursoCSharp.MetodosEFuncoes
{
    public class ExemploLambda
    {
        public static void Executar(){

            // ACTION NÃO TEM RETORNO - VOID
            Action algoNoConsole  = () => {
                System.Console.WriteLine("Lambda Com C#");
            };

            algoNoConsole();
            
            // ACTION COM PARAMETRO
            Action<string> saudacao = (nome) => {
                 System.Console.WriteLine($"Ola, {nome}, Como vai?");
            };

            saudacao("Marcelo");    

            // Função<Retorno> NomeDaFuncao
            Func<int> JogarDado = () => {
                Random randon = new Random();
                return  randon.Next(1 , 7);
            };

            System.Console.WriteLine(JogarDado());
             // Função<Parametro, Retorno> NomeDaFuncao
            Func<int, string> ConversorHex = numero =>  numero.ToString("X");
            System.Console.WriteLine(ConversorHex(1234));

             // Função<Parametro, Retorno> NomeDaFuncao
            Func<int, int, int, string>  
                formatarData = (dia, mes, ano) => 
                    String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            System.Console.WriteLine(formatarData(04,09,1987));        

            }
        }
    }
