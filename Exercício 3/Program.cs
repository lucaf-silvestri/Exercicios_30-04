using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + "Qual o salário do funcionário atualmente?");
            int salario = int.Parse(Console.ReadLine());
            if (salario < 500)
            {
                double aumento = salario*0.3;
                double novoSalario = salario + aumento;
                Console.WriteLine("\n" + "O funcionário receberá um aumento de 30% em seu salário, equivalente a R$" + aumento + ".\n");
                Console.WriteLine("Passará a receber um novo salário de R$" + novoSalario + ".\n");
            }
            else
            {
                Console.WriteLine("\n" + "O salário do funcionário já está de acordo.\n");
            }
        }
    }
}
