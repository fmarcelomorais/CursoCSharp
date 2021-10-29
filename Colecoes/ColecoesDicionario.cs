using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    public class ColecoesDicionario
    {
        public static void Executar(){
            var filmes = new Dictionary<int, string>(); // Ano - Filme

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2010, "Batutinhas");
            filmes.Add(2003, "Coração Valente");
            filmes.Add(1989, "Lagoa-azul");


            if(filmes.ContainsKey(2000)){
            System.Console.WriteLine("2000: {0}", filmes[2000]);
            System.Console.WriteLine("2000: {0}", filmes.GetValueOrDefault(2000));

            }

            System.Console.WriteLine(filmes.ContainsValue("Maria"));
            System.Console.WriteLine($"Removeu? {filmes.Remove(2000)}");
            //var contem = filmes.ContainsKey(2000);

            filmes.TryGetValue(2000, out string filme2000);
            filmes.TryGetValue(2002, out string filme2002);

            System.Console.WriteLine($"Filme 2000: {filme2000}");
            System.Console.WriteLine($"Filme 2002: {filme2002}");
        }
    }
}