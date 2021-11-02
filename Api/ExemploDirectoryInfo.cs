using System;
using System.IO;

namespace CursoCSharp.Api
{
    public class ExemploDirectoryInfo
    {
        public static void Executar(){
            var dirProjeto = @"~/Desktop/workspace/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if(!dirInfo.Exists){
                dirInfo.Create();
            }

            System.Console.WriteLine("== Arquivos ================");
                var arquivos = dirInfo.GetFiles();

                foreach(var arquivo in arquivos){
                    System.Console.WriteLine(arquivo);
                }

            System.Console.WriteLine("\n\n== Diretorios ================");
                var diretorios = dirInfo.GetDirectories();
                foreach(var diretorio in diretorios){
                    System.Console.WriteLine(diretorio);
                }
            System.Console.WriteLine("\n\n== Informações ================");
                var informacoes = dirInfo.GetFileSystemInfos();

                foreach(var info in informacoes){
                    System.Console.WriteLine("----------------");
                    System.Console.WriteLine($"Nome: {info.Name}");
                    System.Console.WriteLine($"Criação: {info.CreationTime}");
                    System.Console.WriteLine($"Extensão: {info.Extension}");
                }
        }
    }
}