namespace Estruturas
{
    class Program
    {
        static void Main()
        {
            Point p;
            p.X = 10;
            p.Y = 20;
            
            
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);
        }
    }
}

