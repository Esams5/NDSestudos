namespace Item4
{
    class Program
    {
        static void Main()
        {
            Produto4 p = new Produto4("TV", 500.00, 10);

            p.Nome = "TV 4k";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            
            


        }
        
    }
}