using System;
using System.IO;

namespace CursoCSharp.Api
{
    public class ExemploPath
    {
        public static void Executar(){
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um novo arquivo Criado");
                };

            }
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            System.Console.WriteLine(Path.GetExtension(arquivo));
            System.Console.WriteLine(Path.GetFileName(arquivo));
            System.Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));

        }
    }
}