using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + "Qual o seu dia de nascimento?");
            int diaNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + "Qual o número do seu mês de nascimento?");
            int mesNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + "Qual seu ano de nascimento?");
            int anoNascimento = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;
            int mesAtual = DateTime.Now.Month;
            int diaAtual = DateTime.Now.Day;
            int idadeEmAnos = (((12-mesNascimento) *31 + (31 - diaNascimento) /*Todos os dias que viveu no ano de nascimento*/) + (((anoAtual-anoNascimento) - 1)*365 /*Todos os dias que viveu durante os anos, menos o de nascimento*/) + ((mesAtual*31) - (31 - diaAtual)/*Todos os dias que viveu no ano atual*/))/365;
            int idadeEmDias = ((12-mesNascimento) *31 + (31 - diaNascimento)) + (((anoAtual-anoNascimento) - 1)*365) + ((mesAtual*31) - (31 - diaAtual));

            Console.WriteLine("\n" + "Você tem " + idadeEmAnos + " anos de idade.\n");

            int idadeSemanas = idadeEmDias/7;
            Console.WriteLine("Sua idade é de aproximadamente " + idadeSemanas + " semanas.\n");
        }
    }
}
