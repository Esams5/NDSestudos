namespace Ex003
{
    class Pogram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 números: ");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D= int.Parse(Console.ReadLine());
            int dif = (A * B) - (C * D);
            
            Console.WriteLine("DIFERENCA= " + dif);

        }
        
    }
}

