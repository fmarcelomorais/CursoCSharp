using System;
using System.IO;

namespace CursoCSharp.Api
{
    public class LendoArquivos
    {
        public static void Executar(){
             var path = @"~/Lendo_arquivo.txt".ParseHome();

            if(!File.Exists(path)){
                using (StreamWriter sw = File.AppendText(path)){
                    sw.WriteLine("Produto; Preco; Qtde");
                    sw.WriteLine("Canete Bic Preta; 3.59; 80");
                    sw.WriteLine("Caderno Tilibra; 13.99; 20");
                    sw.WriteLine("Mochila Barbie; 53.89; 10");
                    sw.WriteLine("Estojo de lápis; 10.59; 120");
                    sw.WriteLine("Capa de Chuva; 23.99; 100");
                };                
            }

            try{
                using (StreamReader sr = new StreamReader(path)){
                    var texto = sr.ReadToEnd();
                    System.Console.WriteLine(texto);
                }
            } catch (Exception ex){
                System.Console.WriteLine(ex.Message);

            }
        }
    }
}