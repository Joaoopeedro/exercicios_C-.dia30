using System;

namespace exercicio_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Categorias de Nataçao");
            Console.WriteLine("Qual a sua idade?");
            int idadePessoa = int.Parse(Console.ReadLine());

            if (idadePessoa >= 5 && idadePessoa <= 7)
            {
                Console.WriteLine("Você pentence a categoria INFANTIL A");
            }
            if (idadePessoa >= 8 && idadePessoa <= 10)
            {
                Console.WriteLine("Você pentence a categoria INFANTIL B");
            }
            if (idadePessoa >= 11 && idadePessoa <= 13)
            {
                Console.WriteLine("Você pentence a categoria JUVENIL A");
            }
            if (idadePessoa >= 14 && idadePessoa <= 17)
            {
               Console.WriteLine("Você pentence a categoria JUVENIL B"); 
            } 
             if (idadePessoa >= 18)
            {
               Console.WriteLine("Você pentence a categoria SÊNIOR ");
            }
             
        }
    }
}
