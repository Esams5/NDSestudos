using System.Globalization;

namespace Item3
{
    class Program
    {
        static void Main()
        {
            Produto3 p = new Produto3("TV", 500.00, 10);

            p.SetNome("Tv 4K");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
            
            /*p.Quantidade = -10 não pode fazer isso se for privado na classe produto */


        }
        
    }
}