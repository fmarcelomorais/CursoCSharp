using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{

    class Produto{
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
        }
    }

    public class ColecoesList
    {
        public static void Executar(){
            var livro = new Produto("Meu Livro", 49.9);

            var carrinho = new List<Produto>(); // Fazer as Listas Homogeneas
            carrinho.Add(livro);

            var combo = new List<Produto>{
                new Produto("Camisa", 29.9),
                new Produto("Calça", 49.9),
                new Produto("Relogio", 129.9),
                new Produto("Gola Polo", 59.9),
                new Produto("Short", 39.9),
                new Produto("Cueca", 19.9),
            };

            carrinho.AddRange(combo);
            System.Console.WriteLine("Total de itens Cadastrados: " + carrinho.Count);

            foreach(var produto in carrinho){
                var index = carrinho.IndexOf(produto);
                System.Console.WriteLine($"Produto: {index + 1} - {produto.Nome} | Preço R${produto.Preco}");
            System.Console.WriteLine("===================================");
            }

            carrinho.RemoveAt(6); //Remove item especifico da lista

            System.Console.WriteLine("");
            System.Console.WriteLine("Total de itens Cadastrados: " + carrinho.Count);
            System.Console.WriteLine("===================================");
            foreach(var produto in carrinho){
                var index = carrinho.IndexOf(produto);
                System.Console.WriteLine($"Produto: {index + 1} - {produto.Nome} | Preço R${produto.Preco}");
            System.Console.WriteLine("===================================");
            }
        }
    }
}