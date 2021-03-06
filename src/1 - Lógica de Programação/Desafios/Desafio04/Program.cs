﻿using System;
using System.Globalization;

namespace Desafio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as informações do funcionário");
            Console.Write("Número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Valor que recebe por hora: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valor * horas;

            Console.WriteLine($"Número do funcionário: {numero} - Salário: R$ {salario.ToString("F2")}");
        }
    }
}
