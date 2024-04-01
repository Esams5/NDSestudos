namespace Calculadora
{
    class Program
    {
        static void Main()
        {
           /* int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            * Usando ref */

           int a = 10;
           int triple;
           Calculator.Triple(a, out triple);
           Console.WriteLine(triple);


        }
    }
}

