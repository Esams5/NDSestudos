using System.Globalization;

namespace Proposto3
{
    class Program
    {
        static void Main()
        {
            Aluno aluninho;
            aluninho = new Aluno();
            
            Console.Write("Nome do Aluno: ");
            aluninho.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluninho.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluninho.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluninho.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluninho.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluninho.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluninho.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }
            
            
        }
    }
}

