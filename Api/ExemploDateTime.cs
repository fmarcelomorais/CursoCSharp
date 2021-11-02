using System;
using System.Collections.Generic;

namespace CursoCSharp.Api
{
    public class ExemploDateTime
    {
        public static void Executar(){
            var dateTime = new DateTime(year: 2021, month: 11, day: 2);
            System.Console.WriteLine(dateTime.Day);
            System.Console.WriteLine(dateTime.Month);
            System.Console.WriteLine(dateTime.Year);

            // sem horas
            var hoje = DateTime.Today;
            System.Console.WriteLine(hoje);
            var agora = DateTime.Now;
            System.Console.WriteLine(agora);
            System.Console.WriteLine(agora.Hour);
            System.Console.WriteLine(agora.Minute);
            System.Console.WriteLine(agora.Second);
            System.Console.WriteLine(agora.ToString("dd-MM-yyyy HH:mm:ms"));
        }
    }
}