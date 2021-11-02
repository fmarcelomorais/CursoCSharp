using System;
using System.IO;

namespace CursoCSharp.Api
{
    public class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos){
            foreach(var caminho in caminhos){
                FileInfo arquivo = new FileInfo(caminho);

                if(arquivo.Exists){
                    arquivo.Delete();
                }
            }
        }
        public static void Executar(){
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);
            
            using (StreamWriter sw = File.CreateText(caminhoOrigem)){
                sw.WriteLine("Arquivo Original");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            System.Console.WriteLine($"Origem: {origem.Name}");
            System.Console.WriteLine($"Tamanho: {origem.Length}b");
            System.Console.WriteLine($"Só Leitura: {origem.IsReadOnly}");
            System.Console.WriteLine($"Nome Completo: {origem.FullName}");
            System.Console.WriteLine($"Extensao: {origem.Extension}");

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}