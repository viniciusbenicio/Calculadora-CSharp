﻿using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Primeiro valor: ");
            float n1 =  float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());


            float resultado = n1 + n2;

            Console.WriteLine($"Resultado da Soma: {resultado} ");



        }
    }
}