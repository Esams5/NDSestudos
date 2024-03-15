using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main()
        {
            Produto p1;
            p1 = new Produto();
            
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome:");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço:");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p1);
            
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            
            p1.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);
            
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            
            p1.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p1);
            


        }
    }
}

