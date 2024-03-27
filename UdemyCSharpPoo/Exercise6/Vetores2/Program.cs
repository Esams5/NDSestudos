using System.Globalization;

namespace Vetores2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto(name, price);
                //vect[i] = new Produto{Name = name, Price = price}; Instanciação automática caso não queira usar construtores

            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;

            }

            double media = soma / n;

            Console.WriteLine("Preço médio = " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}

