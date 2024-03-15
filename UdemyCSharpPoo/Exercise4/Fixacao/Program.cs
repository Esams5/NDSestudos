using System.Globalization;

namespace Fixacao
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Qual é a cotação do dólar? ");
            double cota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.DolarParaReal(cota, quant).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

