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

            // Console.WriteLine("Qual ano estamos?");

            int anoAtual = DateTime.Now.Year;
            
            Console.WriteLine("Você ja fez aniversario em " + anoAtual + "??");
            Console.WriteLine("Responda com S(se for sim) e N (se for não)");
            string aniversario = Console.ReadLine();

            int idade = anoAtual - ano;
            if (aniversario == "S")
            {
                Console.WriteLine("Você tem a idade de: " + idade + " anos");
                
            }else {
                Console.WriteLine("Você tem a idade de: " + ( idade - 1 )+ " anos");
            }


            int idadeSemana = idade * 12 * 4;
            Console.WriteLine("Sua idade convertida em semanas é de: " +  idadeSemana + " semanas");

        }
    }
}
