using System;
using System.Collections.Generic;

namespace CursoCSharp.Api
{
    public class ExemploTimeSpan
    {
        public static void Executar(){
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 42);
            System.Console.WriteLine(intervalo);
        }
    }
}