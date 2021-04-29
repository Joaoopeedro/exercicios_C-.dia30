using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Qual é seu nome ?");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("Boa tarde " + nomePessoa + "!!" + "\n");

            Console.WriteLine("Quantos anos você tem?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int meses = idade * 12;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(meses + " :meses" );

            int anobissexto = idade * 366;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(anobissexto + " :dias em ano bissexto");
            
            int dias = idade * 365;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(dias + " :dias" );
            
            int horas = dias * 365;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(horas + " :horas");

            int minutos = horas * 60;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(minutos + " :min");

            
        }
    }
}
