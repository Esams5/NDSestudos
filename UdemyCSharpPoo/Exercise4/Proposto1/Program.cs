using System.Globalization;

namespace Proposto1
{
    class Program
    {
        static void Main()
        {
            Retangulo r;
            r = new Retangulo();
            
            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("ÁREA = " + r.Area());
            Console.WriteLine("PERÍMETO = " + r.Perimetro());
            Console.WriteLine("DIAGONAL = " + r.Diagonal());
            


        }
    }
}

