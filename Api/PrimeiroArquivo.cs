using System;
using System.IO;
namespace CursoCSharp.Api
{
    public static class ExtensaoString{
        public static string ParseHome(this string path){
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Other) ?
            Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    public class PrimeiroArquivo
    {
        public static void Executar(){
            //var s = "\teste\testes\a.txt";
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            if(!File.Exists(path)){
                using (StreamWriter sw = File.CreateText(path)){
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("PRIMEIRO");
                    sw.WriteLine("ARQUIVO");
                }
            }
            //System.Console.WriteLine(path);
        }
    }
}