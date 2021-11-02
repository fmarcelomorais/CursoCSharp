using System;
using System.IO;

namespace CursoCSharp.Api
{
    public class Diretorios
    {

        public static void Executar(){
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDest".ParseHome();
            var dirProjeto = @"~/Desktop/workspace/CursoCSharp".ParseHome();

            if(Directory.Exists(novoDir)){
                Directory.Delete(novoDir, true);
            }

            if(Directory.Exists(novoDirDestino)){
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            System.Console.WriteLine(Directory.GetCreationTime(novoDir));

            System.Console.WriteLine("== Pastas ==================");

            var pastas = Directory.GetDirectories(dirProjeto);
            foreach( var pasta in pastas){
                System.Console.WriteLine(pasta);
            }
            System.Console.WriteLine("\n\n== Arquivos =============");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos){
                System.Console.WriteLine(arquivo);
            }
            System.Console.WriteLine("\n\n== Arquivos =============");
            var dirRaiz = Directory.GetDirectoryRoot(dirProjeto);
            System.Console.WriteLine("Diretorio raiz " + dirRaiz);

            Directory.Move(novoDir, novoDirDestino);

        }

    }
}