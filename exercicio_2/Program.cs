using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercicio_2");
            Console.WriteLine("Qual o ano do seu nascimento?");

            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual ano estamos?");
            int anoAtual = int.Parse(Console.ReadLine());

            int idade = anoAtual - ano;
            Console.WriteLine("Você tem a idade de: " + idade + " anos");

            int idadeSemana = idade * 12 * 4;
            Console.WriteLine("Sua idade convertida em semanas é de: " +  idadeSemana + " semanas");

        }
    }
}
