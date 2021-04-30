using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do seu salario atual?");
            float salario = float.Parse(Console.ReadLine());

            if (salario < 500)
            {
                float salario_2 = (salario / 100) * 30;
                float salarioNovo = salario + salario_2;
                Console.WriteLine("Seu salário foi alterado para o valor de: " + salarioNovo);
            }else {
                Console.WriteLine("Você não teve alteracão no seu salário!");
            }

        }
    }
}


            
            
