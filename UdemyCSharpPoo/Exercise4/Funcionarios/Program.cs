using System.Globalization;

namespace Funcionarios
{
    class Program
    {
        static void Main()
        {
            Funcionario p1, p2;

            p1 = new Funcionario();
            p2 = new Funcionario();
            
            Console.WriteLine("Digite o nome e o salário do primeiro funcionário: ");
            p1.nome = Console.ReadLine();
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Digite o nome e o salário do segundo funcionário: ");
            p2.nome = Console.ReadLine();
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (p1.salario + p2.salario) / 2.00;
            
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}

