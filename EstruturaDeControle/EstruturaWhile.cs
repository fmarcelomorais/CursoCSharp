using System;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaWhile
    {
        public static void Executar(){
            int palpite = 0;
            Random random = new Random();
            int numeroSorteado = random.Next(1, 16);

            bool numeroEncontrado = false;
            int tentativaRestante = 5;
            int tentativas = 0;

            while(tentativaRestante > 0 && !numeroEncontrado){
                System.Console.WriteLine("Insira seu palpite");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativaRestante--;

                if(numeroSorteado == palpite){
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    System.Console.WriteLine($"Numero encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = corAnterior;
                }else if(palpite > numeroSorteado){
                        System.Console.WriteLine($"Numero Menor... Tente novamente - Tentativas {tentativaRestante} Restantes.");
                }else {
                        System.Console.WriteLine($"Numero Maior... Tente novamente - Tentativas {tentativaRestante} Restantes.");
                }
            }

            
        }
    }
}