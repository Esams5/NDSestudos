using System.Globalization;

namespace Proposto2
{
    class Program
    {
        static void Main()
        {
            Empregado funcionario;
            funcionario = new Empregado();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("IMPOSTO: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + funcionario);
            
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            funcionario.AumentarSalario(porc);

            Console.WriteLine("Dados atualizados: " + funcionario);


        }
    }
}

