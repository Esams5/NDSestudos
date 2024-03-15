namespace Ex004
{
    class Progam
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine());
            double sal = valor * horas;
            
            Console.WriteLine("Number = " + num);
            Console.WriteLine(("SALARY = " + sal.ToString("F2")));

        }
    }
}

