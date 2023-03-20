using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Somar();
            Substracao();   

        }

        static void Somar()
        {
            // Primeiro valor para realizar a soma.
            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            // Segundo valor para realizar a soma.
            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            //Resultado da soma dos dois valores n1 e n2.
            float resultado = n1 + n2;

            // Mostrando no Console uma string com o resultado.
            Console.WriteLine($"Resultado da Soma: {resultado} ");
        }

        static void Substracao()
        {
            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("-----------------");

            float resultado = n1 - n2;
            Console.WriteLine($"O Resultado dos valores: {resultado}");
        }
    }
}