﻿using System.Globalization;

namespace Condicional_Ternaria
{
    class Program
    {
        static void Main()
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

        }
    }
}

