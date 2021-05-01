using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + "Cálculo de idade em meses, dias, horas e minutos.\n");
            Console.WriteLine("Quantos anos de idade você tem?\n");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            int dias = idade * 365;
            int horas = idade * 8760;
            int minutos = idade * 525600;

            Console.WriteLine("\n" + "Você tem " + meses + " meses de idade");
            Console.WriteLine("Você tem " + dias + " dias de idade");
            Console.WriteLine("Você tem " + horas + " horas de idade");
            Console.WriteLine("Você tem " + minutos + " minutos de idade\n");
        }
    }
}